using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu
{
    class FormButton : FormObject
    {
        //Singleton Pattern
        private FormButton(Panel mainPanel)
        {
            this.mainPanel = mainPanel;
        }

        public Panel mainPanel;
        private static FormButton instance;
        public static FormButton giveInstance(Panel mainPanel)
        {
            if (instance == null)
            {
                instance = new FormButton(mainPanel);
            }
            return instance;
        }
        public Button nesne;
        List<Tuple<Button, string>> nesneler = new List<Tuple<Button, string>>();

        public object create(string name, Size size, Point location,string text) 
        {
            isNameUnique(name);
            nesne = new Button();
            nesne.Location = location;
            nesne.Name = name;
            nesne.Size = size;
            nesne.Text = text;
            nesne.UseVisualStyleBackColor = true;
            mainPanel.Controls.Add(nesne);
            nesneler.Add(Tuple.Create(nesne, name));            
            return nesne;
        }


        public override void isNameUnique(string name)
        {
            foreach (var buton in nesneler)
            {
                if (buton.Item2 == name)
                {
                    throw new Exception("Name NOT Unique");
                }                
            }
        }

        public override object findByName(string name)
        {
            foreach (var buton in nesneler)
            {
                if (buton.Item2 == name)
                {
                    return buton.Item1;
                }
            }
            return null;
        }

        public override void delete(string nesneadi)
        {
            Button deletenesne = (Button) findByName(nesneadi);
            mainPanel.Controls.Remove(deletenesne);
        }

        
    }
}
