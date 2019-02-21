using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaartspel
{
    class SpeelKaart

    {

        //properties

        int waarde;

        Symbool symbool;

        bool isZichtbaar;



        //constructor

        public SpeelKaart(int waarde, Symbool symbool, bool isZichtbaar)

        {

            Waarde = waarde;

            Symbool = symbool;

            IsZichtbaar = isZichtbaar;

        }



        //methodes (werkwoorden)

        public void Draaien()

        {

            if (IsZichtbaar)

            {

                IsZichtbaar = false;

            }

            else

            {

                IsZichtbaar = true;

            }

        }



        public string Tonen()

        {

            String returnValue = "kaart is onzichtbaar";

            ;

            if (IsZichtbaar)

            {

                returnValue = Symbool + "-" + Waarde;

            }

            return returnValue;

        }





        //getset

        private int Waarde

        {

            get { return this.waarde; }

            set { this.waarde = value; }

        }



        private Symbool Symbool

        {

            get { return this.symbool; }

            set { this.symbool = value; }

        }



        public bool IsZichtbaar

        {

            get { return this.isZichtbaar; }

            set { this.isZichtbaar = value; }

        }

    }

}

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Spel

{

enum Symbool

{

Harten,

Klaver,

Ruiten,

Schoppen

}

}

===================================



using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Spel

{

class Program

{

static void Main(string[] args)

{

//objecten

SpeelKaart kaart1 = new SpeelKaart(2, Symbool.Harten, true);

SpeelKaart kaart2 = new SpeelKaart(5, Symbool.Klaver, false);

SpeelKaart kaart3 = new SpeelKaart(10, Symbool.Schoppen, true);



kaart2.Draaien();

Console.WriteLine(kaart1.Tonen() + " / " + kaart2.Tonen() + "/" + kaart3.Tonen();

Console.Read();



}

}

}
