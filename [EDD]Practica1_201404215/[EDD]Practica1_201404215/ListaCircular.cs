using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201404215
{
    class ListaCircular
    {
        NodoLC inicio;
        NodoLC fin;
  

        public ListaCircular() {

        }

        public void insertarLC(NodoLC nuevo) {
            if (inicio == null)
            {

                inicio = nuevo;
                fin = nuevo;

            }
            else {
                fin.Siguiente = nuevo;
                inicio.Anterior = nuevo;
                nuevo.Anterior = fin;
                nuevo.Siguiente = inicio;
                fin = nuevo; 
            }
        }
    }
}
