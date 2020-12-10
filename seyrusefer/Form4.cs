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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
            
            
                dataGridView1.Columns.Add("sefer", "Sefer No");
                dataGridView1.Columns.Add("sefer", "Nereden");
                dataGridView1.Columns.Add("sefer", "Nereye");
                dataGridView1.Columns.Add("sefer", "Tarih");
                dataGridView1.Columns.Add("sefer", "Saat");
                dataGridView1.Columns.Add("sefer", "Kapasite");
                dataGridView1.Columns.Add("sefer", "Kaptan");
                dataGridView1.Columns.Add("sefer", "Plaka");
                dataGridView1.Columns.Add("sefer", "Bilet Fiyatı");

            string[] lines = File.ReadAllLines(@"C:\Users\simge\OneDrive\Masaüstü\proje.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataGridView1.Rows.Add(row);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
