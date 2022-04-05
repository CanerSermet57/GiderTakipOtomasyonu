using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace GiderTakipOtomasyonu
{
    class FormPanel : FormObject
    {
        private FormPanel(Panel mainPanel)
        {
            this.mainPanel = mainPanel;
        }
        public Panel mainPanel;
        private static FormPanel instance;
        public static FormPanel giveInstance(Panel mainPanel)
        {
            if (instance == null)
            {
                instance = new FormPanel(mainPanel);
            }
            return instance;
        }
        public Panel nesne;
        List<Tuple<Panel, string>> nesneler = new List<Tuple<Panel, string>>();


        public object create(string name, Size size, Point location)
        {
            isNameUnique(name);
            nesne = new Panel();
            nesne.Location = location;
            nesne.Name = name;
            nesne.Size = size;
            mainPanel.Controls.Add(nesne);
            nesneler.Add(Tuple.Create(nesne, name));
            return nesne;
        }


        public override void isNameUnique(string name)
        {
            foreach (var nesne in nesneler)
            {
                if (nesne.Item2 == name)
                {
                    throw new Exception("Name NOT Unique");
                }
            }
        }

        public override object findByName(string name)
        {
            foreach (var nesne in nesneler)
            {
                if (nesne.Item2 == name)
                {
                    return nesne.Item1;
                }
            }
            return null;
        }

        public override void delete(string nesneadi)
        {
            Panel deletenesne = (Panel)findByName(nesneadi);
            mainPanel.Controls.Remove(deletenesne);
        }
    }
}
