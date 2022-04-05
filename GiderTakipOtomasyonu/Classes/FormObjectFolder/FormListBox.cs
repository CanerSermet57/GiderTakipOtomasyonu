using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GiderTakipOtomasyonu
{ 
    class FormListBox : FormObject
    {
        private FormListBox(Panel mainPanel)
        {
            this.mainPanel = mainPanel;
        }
        public Panel mainPanel;
        private static FormListBox instance;
        public static FormListBox giveInstance(Panel mainPanel)
        {
            if (instance == null)
            {
                instance = new FormListBox(mainPanel);
            }
            return instance;
        }
        public ListBox nesne;
        List<Tuple<ListBox, string>> nesneler = new List<Tuple<ListBox, string>>();


        public object create(string name, Size size, Point location, string[] items)
        {
            isNameUnique(name);
            nesne = new ListBox();
            nesne.Location = location;
            nesne.Name = name;
            nesne.Size = size;
            nesne.Items.AddRange(items);
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
            ListBox deletenesne = (ListBox)findByName(nesneadi);
            mainPanel.Controls.Remove(deletenesne);
        }
    }
}
