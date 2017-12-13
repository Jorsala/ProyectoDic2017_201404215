using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201404215
{
    class Cola
    {
        NodoCola inicio;
        NodoCola fin;
        public Cola() {
            inicio = null;
            fin = null;
        }

        public void insertarCola(NodoCola nuevo) {

            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
                Console.WriteLine("se inserto un nodo "+ inicio.Dato.ToString());
            }
            else {
                nuevo.Siguiente = fin;
                fin = nuevo;
            }
        }
    }
}
