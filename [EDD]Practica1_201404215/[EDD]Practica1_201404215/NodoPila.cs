using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201404215
{
    class NodoPila
    {
       private int posx;
       private int posy;
       private int dato;

       private NodoPila siguiente;

        public int Posx
        {
            get{return posx;}
            set{posx = value;}
        }

        public int Posy
        {
            get{return posy;}
            set{posy = value;}
        }

        public int Dato
        {
            get{return dato;}
            set{dato = value;}
        }

       public NodoPila Siguiente
        {
            get{return siguiente;}
            set{siguiente = value;}
        }

        public NodoPila() {

            Posx = 0;
            Posy = 0;
            Dato = 0;

            Siguiente = new NodoPila(); 
        }
    }
}
