namespace EmailTester
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnableSsl = new System.Windows.Forms.CheckBox();
            this.txtRecipientEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.txtSmtpPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSmtpUsername = new System.Windows.Forms.TextBox();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSmtpHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message:";
            // 
            // btnSend
            // 
            this.btnSend.Image = global::EmailTester.Properties.Resources.IconEmail;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(274, 478);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(62, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(206, 478);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(62, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Navy;
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMessage.Location = new System.Drawing.Point(6, 474);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(164, 27);
            this.lblMessage.TabIndex = 9;
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.chkEnableSsl);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Controls.Add(this.txtRecipientEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSenderName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSenderEmail);
            this.groupBox1.Controls.Add(this.txtSmtpPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSmtpUsername);
            this.groupBox1.Controls.Add(this.txtSmtpPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSmtpHost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 521);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set and Test";
            // 
            // chkEnableSsl
            // 
            this.chkEnableSsl.AutoSize = true;
            this.chkEnableSsl.Location = new System.Drawing.Point(9, 32);
            this.chkEnableSsl.Name = "chkEnableSsl";
            this.chkEnableSsl.Size = new System.Drawing.Size(79, 19);
            this.chkEnableSsl.TabIndex = 1;
            this.chkEnableSsl.Text = "EnableSSL";
            this.chkEnableSsl.UseVisualStyleBackColor = true;
            // 
            // txtRecipientEmail
            // 
            this.txtRecipientEmail.Location = new System.Drawing.Point(103, 302);
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(233, 23);
            this.txtRecipientEmail.TabIndex = 8;
            this.txtRecipientEmail.TextChanged += new System.EventHandler(this.Labels_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Recipient Email:";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Location = new System.Drawing.Point(103, 259);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(233, 23);
            this.txtSenderName.TabIndex = 7;
            this.txtSenderName.TextChanged += new System.EventHandler(this.Labels_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sender Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sender Email:";
            // 
            // txtSenderEmail
            // 
            this.txtSenderEmail.Location = new System.Drawing.Point(103, 219);
            this.txtSenderEmail.Name = "txtSenderEmail";
            this.txtSenderEmail.Size = new System.Drawing.Size(233, 23);
            this.txtSenderEmail.TabIndex = 6;
            this.txtSenderEmail.TextChanged += new System.EventHandler(this.Labels_TextChanged);
            // 
            // txtSmtpPassword
            // 
            this.txtSmtpPassword.Location = new System.Drawing.Point(103, 179);
            this.txtSmtpPassword.Name = "txtSmtpPassword";
            this.txtSmtpPassword.Size = new System.Drawing.Size(233, 23);
            this.txtSmtpPassword.TabIndex = 5;
            this.txtSmtpPassword.TextChanged += new System.EventHandler(this.Labels_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Smtp Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Smtp Host:";
            // 
            // txtSmtpUsername
            // 
            this.txtSmtpUsername.Location = new System.Drawing.Point(103, 137);
            this.txtSmtpUsername.Name = "txtSmtpUsername";
            this.txtSmtpUsername.Size = new System.Drawing.Size(233, 23);
            this.txtSmtpUsername.TabIndex = 4;
            this.txtSmtpUsername.TextChanged += new System.EventHandler(this.Labels_TextChanged);
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.Location = new System.Drawing.Point(103, 95);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(233, 23);
            this.txtSmtpPort.TabIndex = 3;
            this.txtSmtpPort.TextChanged += new System.EventHandler(this.Labels_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Smtp Password:";
            // 
            // txtSmtpHost
            // 
            this.txtSmtpHost.Location = new System.Drawing.Point(103, 57);
            this.txtSmtpHost.Name = "txtSmtpHost";
            this.txtSmtpHost.Size = new System.Drawing.Size(233, 23);
            this.txtSmtpHost.TabIndex = 2;
            this.txtSmtpHost.TextChanged += new System.EventHandler(this.Labels_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Smtp Username:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(403, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Navy;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(314, 17);
            this.toolStripStatusLabel1.Text = "Developed By - Vikram Singh Saini (vs00saini@gmail.com)";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(103, 347);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(233, 111);
            this.txtMessage.TabIndex = 27;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 609);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(419, 609);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Tester";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMessage;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEnableSsl;
        private System.Windows.Forms.TextBox txtRecipientEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.TextBox txtSmtpPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSmtpUsername;
        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSmtpHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

