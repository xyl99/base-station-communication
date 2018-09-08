namespace TCP_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKirim = new System.Windows.Forms.TextBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnKirim = new System.Windows.Forms.Button();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(55, 13);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(50, 20);
            this.TxtPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PORT";
            // 
            // TxtKirim
            // 
            this.TxtKirim.Location = new System.Drawing.Point(16, 58);
            this.TxtKirim.Name = "TxtKirim";
            this.TxtKirim.Size = new System.Drawing.Size(162, 20);
            this.TxtKirim.TabIndex = 2;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(197, 17);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 23);
            this.BtnOpen.TabIndex = 3;
            this.BtnOpen.Text = "Open Port";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnKirim
            // 
            this.BtnKirim.Location = new System.Drawing.Point(197, 56);
            this.BtnKirim.Name = "BtnKirim";
            this.BtnKirim.Size = new System.Drawing.Size(75, 23);
            this.BtnKirim.TabIndex = 4;
            this.BtnKirim.Text = "Send";
            this.BtnKirim.UseVisualStyleBackColor = true;
            this.BtnKirim.Click += new System.EventHandler(this.BtnKirim_Click);
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(12, 99);
            this.TxtStatus.Multiline = true;
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(312, 184);
            this.TxtStatus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 295);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.BtnKirim);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.TxtKirim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKirim;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnKirim;
        private System.Windows.Forms.TextBox TxtStatus;
    }
}

