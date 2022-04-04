using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GiderTakipOtomasyonu
{
    class FormPictureBox : FormObject
    {
        private FormPictureBox(Panel mainPanel)
        {
            this.mainPanel = mainPanel;
        }
        public Panel mainPanel;
        private static FormPictureBox instance;
        public static FormPictureBox giveInstance(Panel mainPanel)
        {
            if (instance == null)
            {
                instance = new FormPictureBox(mainPanel);
            }
            return instance;
        }
        public PictureBox nesne;
        List<Tuple<PictureBox, string>> nesneler = new List<Tuple<PictureBox, string>>();


        public object create(string name, Size size, Point location, Image image,PictureBoxSizeMode sizeMode)
        {
            isNameUnique(name);
            nesne = new PictureBox();
            nesne.Location = location;
            nesne.Name = name;
            nesne.Size = size;
            nesne.Image = image;
            nesne.SizeMode = sizeMode;
            mainPanel.Controls.Add(nesne);
            nesneler.Add(Tuple.Create(nesne, name));
            return nesne;
        }
        public object create(string name, Size size, Point location, Image image)
        {
            isNameUnique(name);
            nesne = new PictureBox();
            nesne.Location = location;
            nesne.Name = name;
            nesne.Size = size;
            nesne.Image = image;
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
            PictureBox deletenesne = (PictureBox)findByName(nesneadi);
            mainPanel.Controls.Remove(deletenesne);
        }
    }
}
