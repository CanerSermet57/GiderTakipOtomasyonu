using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Make Short Variables Names
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace GiderTakipOtomasyonu
{
    abstract class FormObject
    {
        public abstract void delete(string name);        
        public abstract void isNameUnique(string name);
        public abstract object findByName(string name);
        
    }
}
