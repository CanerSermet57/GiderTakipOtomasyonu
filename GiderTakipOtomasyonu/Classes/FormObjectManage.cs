using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GiderTakipOtomasyonu.Classes
{
    class FormObjectManage
    {
        //Singleton Pattern Start
        private FormObjectManage(Panel mainPanel)
        {
            this.mainPanel = mainPanel;
        }
        public Panel mainPanel;
        private static FormObjectManage instance;
        public static FormObjectManage giveInstance(Panel mainPanel)
        {
            if (instance == null)
            {
                instance = new FormObjectManage(mainPanel);
            }
            return instance;
        }

        
        /*
        public Button createButton(string name,Size size,Point location)
        {            
            
        }      
        */
        




    }
}
