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
            dataGridView1.DataSource = DBTestListSix();
        }


        public List<DBTest> DBTestListSix()
        {
            List<DBTest> dbTestList = new List<DBTest>();
            dbTestList.Add(DBTest.createinstance("Michael", "0", "00", "ad1", "noinf"));
            dbTestList.Add(DBTest.createinstance("Joana", "1", "00", "ad1", "noinf"));
            dbTestList.Add(DBTest.createinstance("Marbel", "2", "00", "ad1", "noinf"));
            dbTestList.Add(DBTest.createinstance("Charlotte", "3", "00", "ad1", "noinf"));
            dbTestList.Add(DBTest.createinstance("Sophia", "4", "00", "ad1", "noinf"));
            dbTestList.Add(DBTest.createinstance("Clara", "5", "00", "ad1", "noinf"));
            return dbTestList;
        }
    }
}
