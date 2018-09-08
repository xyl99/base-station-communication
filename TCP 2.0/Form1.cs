using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace TCP_2._0
{
    public partial class Form1 : Form
    {
        TcpListener server;
        TcpClient client,client2;
        NetworkStream ns;
        Thread thread;
        string clientIpadress;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            Byte[] datakirim = new byte[1024];
            server = new TcpListener(int.Parse(TxtPort.Text));
            server.Start();
            MessageBox.Show("Server Ready");
            client = server.AcceptTcpClient();
            ns = client.GetStream();
            clientIpadress = IPAddress.Parse(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString())+"";
            TxtStatus.Text += clientIpadress + "=&gt; Connected";
            datakirim = Encoding.ASCII.GetBytes("Hi,, Kamu telah terkoneksi ke server ini");
            ns.Write(datakirim,0,datakirim.Length); 
            thread = new Thread(bacaData);
            thread.IsBackground = true;
            thread.Start();
        }

        private void bacaData()
        {
            while (true) {
                byte[] dataTerima = new byte[1024];
                   if (ns.Read(dataTerima, 0, dataTerima.Length) !=0){

                    UpdateLogTextFromThread(Encoding.ASCII.GetString(dataTerima));
                }
            }
        }
        delegate void UpdateLogTextThreadDelegate(string v);
        public void UpdateLogTextFromThread(string v)
        {
            TxtStatus.Invoke(new UpdateLogTextThreadDelegate(UpdateLogText), new object[] { v});
        }

        private void BtnKirim_Click(object sender, EventArgs e)
        {
            byte[] datakirim = new byte[1024];
            datakirim = Encoding.ASCII.GetBytes(TxtKirim.Text );
            ns.Write(datakirim,0,datakirim.Length);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
            ns.Close();
            client.Close();
            server.Stop();
        }

        private void UpdateLogText(string v)
        {
            TxtStatus.Text +=  v  ;
            TxtStatus.SelectionStart = TxtStatus.Text.Length;
            TxtStatus.ScrollToCaret();
        }
    }
}
