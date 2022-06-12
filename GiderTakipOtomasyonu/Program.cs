using GiderTakipOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            gtoDbContext gtoDb = new gtoDbContext();
            KullaniciDbContext kullaniciDbContext = new KullaniciDbContext();
            //gtoDb.Database.EnsureDeleted();
            //gtoDb.Database.EnsureCreated();
            //kullaniciDbContext.Database.EnsureDeleted();
            //kullaniciDbContext.Database.EnsureCreated();

            Application.Run(new Forms.Giris());
        }
    }
}
