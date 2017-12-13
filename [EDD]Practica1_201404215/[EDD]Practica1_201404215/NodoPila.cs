using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201404215
{
    class NodoPila
    {
 

       private NodoPila siguiente;
        private Matriz matriz;



       public NodoPila Siguiente
        {
            get{return siguiente;}
            set{siguiente = value;}
        }

       public Matriz Matriz
        {
            get
            {
                return matriz;
            }

            set
            {
                matriz = value;
            }
        }
    }
}
