using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201404215
{
    class NodoLC
    {

        private  String nombre;
        private String Pass;

        private NodoLC siguiente;
        private NodoLC anterior;

        public string Nombre
        {
            get{ return nombre;}
            set{ nombre = value;}
        }

        public string Pass1
        {
            get{ return Pass;}
            set{ Pass = value;}
        }

        public NodoLC Siguiente
        {
            get{return siguiente;}
            set{siguiente = value;}
        }

        public NodoLC Anterior
        {
            get{return anterior;}
            set{anterior = value;}
        }

        public NodoLC() {

            Nombre = "";
            Pass1 = "";

            Siguiente = new NodoLC();
            Anterior = new NodoLC();



        }
    }
}
