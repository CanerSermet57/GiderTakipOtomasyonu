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
        public FormButton()
        {

        }
        public Button button;

        public override void create()
        {
            button.Location = location;
            button.Name = name;
            button.Size = size;
        }        

        public override void update()
        {
            
        }

        public override void delete()
        {
            //formControls[].Controls.Clear();
        }

        public override void assignSize(Size size)
        {
            this.size = size;
        }

        public override void assignLocation(Point location)
        {
            this.location = location;
        }

        public override void assignName(string name)
        {
            this.name = name;
        }
    }
}
