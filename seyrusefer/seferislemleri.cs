using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seyrusefer
{
    public partial class seferislemleri : Form
    {
        int gecmis = -1;
        int secili = -1;
        public seferislemleri()
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

        }

        //DataTable table = new DataTable();
        private void Formekle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("İzmir");
            comboBox1.Items.Add("Kocaeli");

            comboBox3.Items.Add("06.20");
            comboBox3.Items.Add("07.20");
            comboBox3.Items.Add("08.20");
            comboBox3.Items.Add("09.20");
            comboBox3.Items.Add("10.20");
            comboBox3.Items.Add("11.20");
            comboBox3.Items.Add("12.20");
            comboBox3.Items.Add("13.20");
            comboBox3.Items.Add("14.20");
            comboBox3.Items.Add("15.20");
            comboBox3.Items.Add("16.20");
            comboBox3.Items.Add("17.20");
            comboBox3.Items.Add("18.20");
            comboBox3.Items.Add("19.20");
            comboBox3.Items.Add("20.20");
            comboBox3.Items.Add("21.20");
            comboBox3.Items.Add("22.20");
            comboBox3.Items.Add("23.20");

            //table.Columns.Add("Sefer No",typeof(int));
            //table.Columns.Add( "Nereden",typeof(string));
            //table.Columns.Add( "Nereye", typeof(string));
            //table.Columns.Add( "Tarih", typeof(string));
            //table.Columns.Add( "Saat", typeof(string));
            //table.Columns.Add( "Kapasite", typeof(int));
            //table.Columns.Add( "Kaptan", typeof(string));
            ////table.Columns.Add( "Plaka", typeof(string));
            ////table.Columns.Add( "Bilet Fiyatı", typeof(int));

            //dataGridView1.DataSource = table;

        }



        private void button1_Click(object sender, EventArgs e)
        { 
            
            if (textBox1.Text.Trim() != "" && comboBox1.Text.Trim() != "" && comboBox2.Text.Trim() != "" && comboBox3.Text.Trim() != "" && dateTimePicker1.Text.Trim() != "" && textBox6.Text.Trim() != "" && textBox7.Text.Trim() != "" && textBox8.Text.Trim() != "" && textBox9.Text.Trim() != "")
            {
                dataGridView1.Rows.Add(1);
                int toplam = dataGridView1.Rows.Count;
                dataGridView1.Rows[toplam - 2].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[toplam - 2].Cells[1].Value = comboBox1.Text;
                dataGridView1.Rows[toplam - 2].Cells[2].Value = comboBox2.Text;
                dataGridView1.Rows[toplam - 2].Cells[3].Value = dateTimePicker1.Text;
                dataGridView1.Rows[toplam - 2].Cells[4].Value = comboBox3.Text;
                dataGridView1.Rows[toplam - 2].Cells[5].Value = textBox6.Text;
                dataGridView1.Rows[toplam - 2].Cells[6].Value = textBox7.Text;
                dataGridView1.Rows[toplam - 2].Cells[7].Value = textBox8.Text;
                dataGridView1.Rows[toplam - 2].Cells[8].Value = textBox9.Text;

                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker1.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";

            }
            else MessageBox.Show("TÜM ALANLARI DOLDURUNUZ");
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text == "Kocaeli")
            {   
                comboBox2.Items.Add("İstanbul");
                comboBox2.Items.Add("Ankara");
                comboBox2.Items.Add("İzmir");
            }

            if (comboBox1.Text != "Kocaeli")
            {
                comboBox2.Items.Add("Kocaeli");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else MessageBox.Show("Lütfen Bir Kayıt Seçiniz!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (secili != -1)
            {
                if (textBox1.Text.Trim() != "" && comboBox1.Text.Trim() != "" && comboBox2.Text.Trim() != "" && comboBox3.Text.Trim() != "" && dateTimePicker1.Text.Trim() != "" && textBox6.Text.Trim() != "" && textBox7.Text.Trim() != "" && textBox8.Text.Trim() != "" && textBox9.Text.Trim() != "")
                {
                    dataGridView1.Rows[secili].Cells[0].Value = textBox1.Text;
                    dataGridView1.Rows[secili].Cells[1].Value = comboBox1.Text;
                    dataGridView1.Rows[secili].Cells[2].Value = comboBox2.Text;
                    dataGridView1.Rows[secili].Cells[3].Value = dateTimePicker1.Text;
                    dataGridView1.Rows[secili].Cells[4].Value = comboBox3.Text;
                    dataGridView1.Rows[secili].Cells[5].Value = textBox6.Text;
                    dataGridView1.Rows[secili].Cells[6].Value = textBox7.Text;
                    dataGridView1.Rows[secili].Cells[7].Value = textBox8.Text;
                    dataGridView1.Rows[secili].Cells[8].Value = textBox9.Text;
                    

                }
                else MessageBox.Show("Tüm Alanları Doldurunuz.");
            }
            else MessageBox.Show("Bir Kayıt Listeleyiniz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                secili = dataGridView1.CurrentRow.Index;
            }
            else MessageBox.Show("Lütfen Bir Kayıt Seçiniz.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
            comboBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox7.Text = "";
            textBox7.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\simge\OneDrive\Masaüstü\proje.txt");
            for (int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                for(int j=0;j<dataGridView1.Columns.Count;j++)
                {
                    writer.Write( dataGridView1.Rows[i].Cells[j].Value.ToString() + ",");

                }
                
            }
            writer.Close();
            MessageBox.Show("Veri Aktarıldı.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gecmis = 1;
            
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



            //private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
            //{

            }

        private void button6_Click(object sender, EventArgs e)
        {
            if(gecmis == 1)
            { 
            int kayitsayisi;
            kayitsayisi = (dataGridView1.RowCount)-1;
            MessageBox.Show(kayitsayisi.ToString());
            }
            else MessageBox.Show("Önce Geçmiş Sefer Listeleyiniz!");

        }


    }
}
