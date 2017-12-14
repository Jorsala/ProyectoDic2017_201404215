using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201404215
{
    class Matriz
    {
       
        NodoMatriz inicio,finL,temporal;

        public Matriz() {
            
            inicio = null;
            temporal = inicio;

        }

        public void Insertar(NodoMatriz nuevo) {
            if (inicio == null)
            {
                inicio = nuevo;
                finL = nuevo;
            }
            else {
                finL.Derecha = nuevo;
                nuevo.Izquierda = finL;
                finL = nuevo; 
            }

           
        }//fin de insertar

        public void insertarAbajo(NodoMatriz nuevo ) {
            if (finL == null)
            {
               
                finL = nuevo;
                inicio.Abajo = nuevo;
                nuevo.Arriba = inicio;
            }
            else
            {
                finL.Derecha = nuevo;
                nuevo.Izquierda = finL;
                temporal = temporal.Derecha;
                temporal.Abajo = nuevo;
                nuevo.Arriba = temporal;
                finL = nuevo;
            }
        }

        public void crearMatriz(int dimx, int dimy ) {
            for (int i = 0; i < dimy; i++) {
                for (int j = 0; j < dimx; j++) {
                    NodoMatriz nodoma = new NodoMatriz();
                    if (i == 0)
                    {
                        Insertar(nodoma);
                        
                    }
                    else {
                        insertarAbajo(nodoma);
                    }

                }
                finL = null;
                while (temporal.Izquierda !=null) {
                    temporal = temporal.Izquierda;
                }
                if(i != 0) {
                    temporal = temporal.Abajo;
                }
                
            }

        }
    }
}
