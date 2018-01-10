using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmailLogger
{
    public partial class GmailLogger : Form
    {
        public GmailLogger()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            EmailSender.SendEmail(recipientText.Text,subjectText.Text,bodyText.Text,"");
        }

        private void Attachment_Click(object sender, EventArgs e)
        {

        }

        private void attachFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
