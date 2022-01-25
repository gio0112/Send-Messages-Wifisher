using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace Send_Messages
{
    public partial class SendForm : Form
    {
        public Microsoft.Office.Interop.Excel.Range EntireRow { get; }
        public SendForm()
        {
            InitializeComponent();
            SendLaterDate.Hide();
        }

        private void SendLaterRadio_CheckedChanged(object sender, EventArgs e)
        {
            SendLaterDate.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SendNowRadio_CheckedChanged(object sender, EventArgs e)
        {
            SendLaterDate.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Auth.LogOut())
            {
                this.Hide();
                var form = new LoginForm();
                form.Show();
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
          
        }
    }
}
