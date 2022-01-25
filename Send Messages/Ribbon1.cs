using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Send_Messages
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            var form = new LoginForm();
            var sendForm = new SendForm();

            if (Auth.IsLogin())
                sendForm.Show();
            else
                form.Show();
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            
        }
    }
}
