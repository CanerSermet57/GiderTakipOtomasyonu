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
        public abstract Object create(string name, Size size, Point location);
        public abstract void update();
        public abstract void delete(string name);
        public abstract bool isNameUnique(string name);
        public abstract Object findByName(string name);
    }
}
