using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send_Messages
{
    public partial class SendForm : Form
    {
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
    }
}
