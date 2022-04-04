using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GiderTakipOtomasyonu
{
    class FormNumericUpDown : FormObject
    {
        private FormNumericUpDown(Panel mainPanel)
        {
            this.mainPanel = mainPanel;
        }
        public Panel mainPanel;
        private static FormNumericUpDown instance;
        public static FormNumericUpDown giveInstance(Panel mainPanel)
        {
            if (instance == null)
            {
                instance = new FormNumericUpDown(mainPanel);
            }
            return instance;
        }
        public NumericUpDown nesne;
        List<Tuple<NumericUpDown, string>> nesneler = new List<Tuple<NumericUpDown, string>>();


        public object create(string name, Size size, Point location, int value)
        {
            isNameUnique(name);
            nesne = new NumericUpDown();
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
            NumericUpDown deletenesne = (NumericUpDown)findByName(nesneadi);
            mainPanel.Controls.Remove(deletenesne);
        }
    }
}
