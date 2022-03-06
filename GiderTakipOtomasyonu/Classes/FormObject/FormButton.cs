using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.Classes.DerivedClasses
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

        public Button button;
        List<Tuple<Button, string>> buttons = new List<Tuple<Button, string>>(); //hem butonu hemde ismini tutuyor

        public override Object create(string name, Size size, Point location) 
        {
            if (!isNameUnique(name))
            {
                throw new Exception("Name NOT Unique");
            }
            button = new Button();
            button.Location = location;
            button.Name = name;
            button.Size = size;
            mainPanel.Controls.Add(button);
            buttons.Add(Tuple.Create(button, name));
            return button;
        }


        public override bool isNameUnique(string name)
        {
            foreach (var buton in buttons)
            {
                if (buton.Item2 == name)
                {
                    return false;
                }                
            }
            return true;
        }

        public override void update()
        {
            
        }

        public override void delete(string buttonname)
        {
            Button buttonToBeDelete = (Button) findByName(buttonname);
            mainPanel.Controls.Remove(buttonToBeDelete);
        }

        public override Object findByName(string name)
        {
            foreach (var buton in buttons)
            {
                if (buton.Item2 == name)
                {
                    return buton.Item1;
                }
            }
            return null;
        }
    }
}
