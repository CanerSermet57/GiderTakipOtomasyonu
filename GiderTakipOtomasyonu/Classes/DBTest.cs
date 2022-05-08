using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiderTakipOtomasyonu  
{
    public class DBTest
    {
        private static int countid = 0;
        //Kisiler
        public int id { get; set; }
        public string adi { get; set; }
        public string tellNo { get; set; }
        public string faksNo { get; set; }
        public string adress { get; set; }
        public string bilgi { get; set; }

        public static DBTest createinstance(string adi,string tellNo, string faksNo,string adress, string bilgi)
        {
            DBTest dbtest = new DBTest();
            dbtest.id = countid;
            dbtest.adi = adi;
            dbtest.tellNo = tellNo;
            dbtest.faksNo = faksNo;
            dbtest.adress = adress;
            dbtest.bilgi = bilgi;
            countid++;
            return dbtest;
        }
    }
}
