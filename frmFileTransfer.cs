using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SecureFileTransfer
{
    public partial class frmFileTransfer : Form
    {
        public frmFileTransfer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //String strHostName = Dns.GetHostName();

            //// Find host by name
            //IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            //// Enumerate IP addresses
            //int nIP = 0;
            //foreach (IPAddress ipaddress in iphostentry.AddressList)
            //{
            //    comboBox1.Items.Add(ipaddress);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                string b = "";



                a = txtFile.Text.LastIndexOf('\\');
                b = txtFile.Text.Substring(a + 1, txtFile.Text.Length - (a + 1));

                string target = "\\\\" + textBox1.Text + "\\pc\\" + b;
                //string target = @"D:\";


                File.Copy(txtFile.Text, target);




                MessageBox.Show("Sent!");




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = ofd.FileName;
            }
        }
    }
}
