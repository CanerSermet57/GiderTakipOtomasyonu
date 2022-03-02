using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Make Short Variables Names
using Point = System.Drawing.Point;

namespace GiderTakipOtomasyonu.Classes.DerivedClasses
{
    abstract class FormObject
    {
        int id;
        string name;
        Point size;
        Point location;

        public abstract void create();
        public abstract void update();
        public abstract void delete();

    }
}
