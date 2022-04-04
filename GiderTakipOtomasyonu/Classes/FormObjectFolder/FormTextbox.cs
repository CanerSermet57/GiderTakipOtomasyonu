using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GiderTakipOtomasyonu
{
    class FormTextbox : FormObject
    {
        private FormTextbox(Panel mainPanel)
        {
            this.mainPanel = mainPanel;
        }
        public Panel mainPanel;
        private static FormTextbox instance;
        public static FormTextbox giveInstance(Panel mainPanel)
        {
            if (instance == null)
            {
                instance = new FormTextbox(mainPanel);
            }
            return instance;
        }
        public TextBox nesne;
        List<Tuple<TextBox, string>> nesneler = new List<Tuple<TextBox, string>>(); //hem butonu hemde ismini tutuyor


        public object create(string name, Size size, Point location, string text)
        {
            isNameUnique(name);
            nesne = new TextBox();
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
            TextBox deletenesne = (TextBox)findByName(nesneadi);
            mainPanel.Controls.Remove(deletenesne);
        }
    }
}
