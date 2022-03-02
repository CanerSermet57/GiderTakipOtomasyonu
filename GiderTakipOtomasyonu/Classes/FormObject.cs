using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Make Short Variables Names
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace GiderTakipOtomasyonu.Classes.DerivedClasses
{
    abstract class FormObject
    {
        public int id;
        public string name;
        public Size size;
        public Point location;

        public abstract void assignSize(Size size);
        public abstract void assignLocation(Point location);
        public abstract void assignName(string name);

        public abstract void create();
        public abstract void update();
        public abstract void delete();
        

    }
}
