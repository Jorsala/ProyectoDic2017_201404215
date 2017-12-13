using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201404215
{
    class NodoCola
    {
     

       private NodoCola siguiente;
        private Matriz matrizCola;

        public NodoCola Siguiente


        {
            get{return siguiente;}
            set{siguiente = value;}
        }

        public Matriz MatrizCola
        {
            get
            {
                return matrizCola;
            }

            set
            {
                matrizCola = value;
            }
        }

        public NodoCola() {

          
            
          

        }
    }
}
