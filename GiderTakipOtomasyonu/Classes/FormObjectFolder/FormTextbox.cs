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
        public TextBox textbox;
        List<Tuple<TextBox, string>> textboxs = new List<Tuple<TextBox, string>>(); //hem butonu hemde ismini tutuyor


        public object create(string name, Size size, Point location, string text)
        {
            isNameUnique(name);
            textbox = new TextBox();
            textbox.Location = location;
            textbox.Name = name;
            textbox.Size = size;
            textbox.Text = text;
            mainPanel.Controls.Add(textbox);
            textboxs.Add(Tuple.Create(textbox, name));
            return textbox;
        }


        public override void isNameUnique(string name)
        {
            foreach (var textbox in textboxs)
            {
                if (textbox.Item2 == name)
                {
                    MessageBox.Show("oh no");
                    throw new Exception("Name NOT Unique");
                }
            }
        }

        public override object findByName(string name)
        {
            foreach (var textbox in textboxs)
            {
                if (textbox.Item2 == name)
                {
                    return textbox.Item1;
                }
            }
            return null;
        }

        public override void delete(string buttonname)
        {
            TextBox textBoxToBeDelete = (TextBox)findByName(buttonname);
            mainPanel.Controls.Remove(textBoxToBeDelete);
        }
    }
}
