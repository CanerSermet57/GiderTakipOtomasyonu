using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GiderTakipOtomasyonu
{
    class FormLabel : FormObject
    {
        private FormLabel(Panel mainPanel)
        {
            this.mainPanel = mainPanel;
        }
        public Panel mainPanel;
        private static FormLabel instance;
        public static FormLabel giveInstance(Panel mainPanel)
        {
            if (instance == null)
            {
                instance = new FormLabel(mainPanel);
            }
            return instance;
        }
        public Label nesne;
        List<Tuple<Label, string>> nesneler = new List<Tuple<Label, string>>(); //hem butonu hemde ismini tutuyor


        public object create(string name, Size size, Point location, string text)
        {
            isNameUnique(name);
            nesne = new Label();
            nesne.Location = location;
            nesne.Name = name;
            nesne.Size = size;
            nesne.Text = text;
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
            Label deletenesne = (Label)findByName(nesneadi);
            mainPanel.Controls.Remove(deletenesne);
        }
    }
}
