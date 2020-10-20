using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin_Virtual
{
    public static class CalculatorPozitie
    {
        // deoarece atunci cand dai location la un obiect trebuie sa dai coltul din stanga sus
        public static Point ColtStangaSus( Control container, Control obiect)
        {
            return new Point((container.Width - obiect.Width) / 2, (container.Height - obiect.Height) / 2);
        }
    }
}
