using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecureFileTransfer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void encryptDecryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncryptFile.frmEncryption frm = new EncryptFile.frmEncryption();
            frm.Show();
        }

        private void fileTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFileTransfer frm = new frmFileTransfer();
            frm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
