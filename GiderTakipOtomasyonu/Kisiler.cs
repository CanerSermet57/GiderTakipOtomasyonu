using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu
{
    public partial class Kisiler : Form
    {
        public Kisiler()
        {
            InitializeComponent();
        }

        private void Kisiler_Load(object sender, EventArgs e)
        {
            source.DataSource = DBTestListSix();
            dataGridView2.DataSource = source;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        int datagridviewsecilenid = -1;
        List<DBTest> dbTestList = new List<DBTest>();
        BindingSource source = new BindingSource();


        public List<DBTest> DBTestListSix()
        {            
            dbTestList.Add(DBTest.createinstance("Michael", "0", "00", "ad1", "noinf"));
            dbTestList.Add(DBTest.createinstance("Joana", "1", "00", "ad1", "noinf"));
            dbTestList.Add(DBTest.createinstance("Marbel", "2", "00", "ad1", "noinf"));
            dbTestList.Add(DBTest.createinstance("Charlotte", "3", "00", "ad1", "noinf"));
            dbTestList.Add(DBTest.createinstance("Sophia", "4", "00", "ad1", "noinf"));
            dbTestList.Add(DBTest.createinstance("Clara", "5", "00", "ad1", "noinf"));
            return dbTestList;
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            datagridviewsecilenid = e.RowIndex;
            if (checkBox1.Checked)
            {
                textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                richTextBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            
        }

        public void refreshdatagridview()
        {
            source.DataSource = dbTestList;
            source.ResetBindings(false);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(dbTestList.Count.ToString());
            dbTestList.Add(DBTest.createinstance(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, richTextBox1.Text));
            refreshdatagridview();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dbTestList[Convert.ToInt32(textBox5.Text)].adi = textBox1.Text;
            dbTestList[Convert.ToInt32(textBox5.Text)].tellNo = textBox2.Text;
            dbTestList[Convert.ToInt32(textBox5.Text)].faksNo = textBox3.Text;
            dbTestList[Convert.ToInt32(textBox5.Text)].adress = textBox4.Text;
            dbTestList[Convert.ToInt32(textBox5.Text)].bilgi = richTextBox1.Text;
            refreshdatagridview();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {

                dbTestList.RemoveAt(Convert.ToInt32(textBox5.Text));
                refreshdatagridview();
            }
        }
    }
}
