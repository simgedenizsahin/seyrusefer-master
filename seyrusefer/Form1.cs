using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seyrusefer
{
    public partial class Form1 : Form
    {
        Form2 Form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.Show(); //Button'a tıkladığımız zaman form2'ye geçmesini sağlıyoruz

            this.Hide(); //Form2 açıldıktan sonra FORM1'ri gizliyoruz.

        }
    }
}
