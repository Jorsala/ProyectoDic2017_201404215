using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201404215
{
    class NodoCola
    {
       private int Posx;
       private int Posy;
       private int dato;

       private NodoCola siguiente;

        public int Posx1
        {
            get{return Posx;}
            set{Posx = value;}
        }

        public int Posy1
        {
            get{return Posy;}
            set{Posy = value;}
        }

        public int Dato
        {
            get{return dato;}
            set{dato = value;}
        }

        public NodoCola Siguiente
        {
            get{return siguiente;}
            set{siguiente = value;}
        }

        public NodoCola() {

            Posx1 = 0;
            Posy1 = 0;
            Dato = 0;

            Siguiente = new NodoCola();

        }
    }
}
