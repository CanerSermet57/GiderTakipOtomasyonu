using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.Classes
{
    class FormObjectManage
    {
        //Singleton Pattern Start
        private FormObjectManage()
        {
        }
        private static FormObjectManage instance;
        public static FormObjectManage giveInstance()
        {
            if (instance == null)
            {
                instance = new FormObjectManage();
            }
            return instance;
        }


        //Not Completed
        Button createButton()
        {
            return null;
        }

        


    }
}
