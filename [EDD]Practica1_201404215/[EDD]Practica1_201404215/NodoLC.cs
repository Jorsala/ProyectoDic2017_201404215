using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201404215
{
   public class NodoLC
    {

        private  String nombre;
        private String Pass;

        private NodoLC siguiente;
        private NodoLC anterior;

        //lo que tengo que crear son nodos de las otras estructuras

        private Pila pila;
        private Cola cola;

        public NodoLC() {

            pila = new Pila();
            cola = new Cola();
        }

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

        internal Pila Pila
        {
            get
            {
                return pila;
            }

            set
            {
                pila = value;
            }
        }

        internal Cola Cola
        {
            get
            {
                return cola;
            }

            set
            {
                cola = value;
            }
        }


    }
}
