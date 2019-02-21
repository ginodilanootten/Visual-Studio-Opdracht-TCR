using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobbelsteen
{
    class Dobbelsteen
    {
        //  Properties
        private int ogen = 0;

        //  Constructor ( Geen Type, zelfde naam als de class )
        public Dobbelsteen()
        {
        }

        //  Methodes ( Werkworden (waar je ik voor kan zetten ))
        public int Gooi()
        {
            Random random = new Random();
            Ogen = random.Next(1,7);

            return Ogen;
        }

        //  Gettersetter
        private int Ogen
        {
            get { return this.ogen;  }
            set { this.ogen = value; }
        }
    }
}
