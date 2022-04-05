using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GiderTakipOtomasyonu
{
    class FormDateTimePicker : FormObject
    {
        private FormDateTimePicker(Panel mainPanel)
        {
            this.mainPanel = mainPanel;
        }
        public Panel mainPanel;
        private static FormDateTimePicker instance;
        public static FormDateTimePicker giveInstance(Panel mainPanel)
        {
            if (instance == null)
            {
                instance = new FormDateTimePicker(mainPanel);
            }
            return instance;
        }
        public DateTimePicker nesne;
        List<Tuple<DateTimePicker, string>> nesneler = new List<Tuple<DateTimePicker, string>>();


        public object create(string name, Size size, Point location, DateTime value)
        {
            isNameUnique(name);
            nesne = new DateTimePicker();
            nesne.Location = location;
            nesne.Name = name;
            nesne.Size = size;
            nesne.Value = value;
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
            DateTimePicker deletenesne = (DateTimePicker)findByName(nesneadi);
            mainPanel.Controls.Remove(deletenesne);
        }
    }
}
