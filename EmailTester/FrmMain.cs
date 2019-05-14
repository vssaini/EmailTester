using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EmailTester.Code;
using EmailTester.Properties;

namespace EmailTester
{
    public partial class FrmMain : Form
    {
        private bool _mailSent;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            chkEnableSsl.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSSL"]);

            txtSmtpHost.Text = ConfigurationManager.AppSettings["SmtpHost"];
            txtSmtpPort.Text = ConfigurationManager.AppSettings["SmtpPort"];
            txtSmtpUsername.Text = ConfigurationManager.AppSettings["SmtpUsername"];
            txtSmtpPassword.Text = ConfigurationManager.AppSettings["SmtpPassword"];

            txtSenderEmail.Text = ConfigurationManager.AppSettings["SenderEmail"];
            txtSenderName.Text = ConfigurationManager.AppSettings["SenderName"];
            txtRecipientEmail.Text = ConfigurationManager.AppSettings["RecipientEmail"];
            txtMessage.Text = ConfigurationManager.AppSettings["Message"];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var c in groupBox1.Controls.OfType<TextBox>())
            {
                c.Text = string.Empty;
                errorProvider.SetError(c, string.Empty);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!AreTextsValid(groupBox1)) return;

            if (string.IsNullOrEmpty(txtMessage.Text)) return;

            lblMessage.Image = Resources.LoaderAqua;
            lblMessage.Text = Resources.InitiateMsg;
            lblMessage.ForeColor = Color.Navy;

            Application.DoEvents();
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Invoke((MethodInvoker)SendEmail);
        }

        private void bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (_mailSent)
            {
                lblMessage.ForeColor = Color.DarkGreen;
                lblMessage.Text = Resources.SuccessMsg;
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = Resources.ErrorMsg;
            }

            lblMessage.Image = null;
        }

        private void SendEmail()
        {
            var enableSsl = chkEnableSsl.Checked;
            var smtpHost = txtSmtpHost.Text;
            var smtpPort = Convert.ToInt32(txtSmtpPort.Text);
            var smtpUsername = txtSmtpUsername.Text;
            var smtpPassword = txtSmtpPassword.Text;
            var senderEmail = txtSenderEmail.Text;
            var senderName = txtSenderName.Text;
            var recipientEmail = txtRecipientEmail.Text;
            var messageBody = txtMessage.Text;

            _mailSent = Utility.SendEmail(enableSsl, smtpHost, smtpPort, smtpUsername, smtpPassword, senderEmail,
                recipientEmail, senderName, messageBody);
        }

        #region Helpers

        /// <summary>
        /// Show error for text controls if the text is blank.
        /// </summary>
        private bool CheckForEmpty(Control textBox)
        {
            bool valid;

            if (textBox.Text.Trim().Length > 0)
            {
                valid = true;
                errorProvider.SetError(textBox, string.Empty);
            }
            else
            {
                valid = false;
                errorProvider.SetIconPadding(textBox, 5);
                errorProvider.SetError(textBox, "Value can't be blank.");
            }

            return valid;
        }

        /// <summary>
        /// Common text changed for all textboxes in SetLabels tab.
        /// </summary>
        private void Labels_TextChanged(object sender, EventArgs e)
        {
            CheckForEmpty(sender as TextBox);
        }

        /// <summary>
        /// Check if all of the textboxes are valid in TabPage.
        /// </summary>
        private bool AreTextsValid(Control groupBox)
        {
            var valid = false;
            foreach (var c in groupBox.Controls.OfType<TextBox>())
            {
                valid = CheckForEmpty(c);
            }

            return valid;
        }

        #endregion
    }
}
