using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201404215
{
    class Pila
    {

        NodoPila tope;
        NodoPila fin;
        
        public Pila() {
            tope = null;
            fin = null;
        }

        public void insertarPila(NodoPila nuevo) {
            if (tope == null)
            {
                tope = nuevo;
                fin = nuevo;
            }
            else {
                nuevo.Siguiente = fin;
                fin = nuevo;
            }

        }
    }
}
