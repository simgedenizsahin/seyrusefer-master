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

namespace seyrusefer
{
    public partial class Form2 : Form
    {
        seferislemleri seferislemleri = new seferislemleri();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void adminbutton_Click(object sender, EventArgs e)
        {

            string sadminname = adminname.Text;
            string sadminpass = adminpass.Text;

            if (sadminname == "deniz" && sadminpass == "deniz")
            {
                seferislemleri.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }



        }

        private void adminpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
