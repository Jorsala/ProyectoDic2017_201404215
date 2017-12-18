using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _EDD_Practica1_201404215
{
    class Matriz
    {
       
        NodoMatriz inicio,finL,temporal;
        TextWriter archivo1;

        public Matriz() {
            
            inicio = null;
            temporal = inicio;

        }

        public void Insertar(NodoMatriz nuevo) {
            if (inicio == null)
            {
                inicio = nuevo;
                finL = nuevo;
                temporal = inicio;
                
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
                temporal.Abajo = nuevo;
                nuevo.Arriba = temporal;
             
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

        //crear matriz en base a tamaño solicitado
        public void crearMatriz(int dimx, int dimy ) {
            int contadorfi = 0;

            for (int i = 0; i < dimy; i++) {
               
                int contadorcol = 0;
                NodoMatriz nodoma;
                for (int j = 0; j < dimx; j++) {
                    
                    
                    nodoma = new NodoMatriz();
                    if (i == 0)
                    {
                        
                        Insertar(nodoma);
                        nodoma.Dato = contadorcol;
                        nodoma.Posx = j;
                        nodoma.Posy = i;
                        contadorcol++;
                        Console.Write( nodoma.Posy + "," + nodoma.Posx +"   ");

                    }
                    else {
                        
                        insertarAbajo(nodoma);
                        nodoma.Dato = contadorcol;
                        nodoma.Posx = j;
                        nodoma.Posy = i;
                        contadorcol++;
                        Console.Write(nodoma.Posy +","+nodoma.Posx + "   ");
                    }

                }
                Console.WriteLine(" ");
                contadorfi++;
               // Console.WriteLine("se creo un nodo de fila " + contadorfi);
                finL = null;

                
                while (temporal.Izquierda !=null) {
                    temporal = temporal.Izquierda;
                }
                if(i > 1 ) {
                    temporal = temporal.Abajo;
                }
                
            }
            //MessageBox.ShowMessageDiaglog("");

        }


        //para recorrer y graficar

        public void recorrerMatriz(int dimx, int dimy) {
            NodoMatriz temporal1,temporal2;
            int cont1 = 0;
            int cont2 = 0;
            temporal1 = inicio;
            temporal2 = inicio;

            archivo1 = new StreamWriter(@"C:\Users\Jorge Salazar\Desktop\archivo2.txt");
            archivo1.Write("Digraph U { \n");
            for (int i =0; i<dimy; i++) {
                for (int j =0;j<dimx; j++ ) {
                    archivo1.Write("Node" + cont1 + "[label=" + "\"" + temporal1.Dato + "\"]; \n");

                    if (temporal1 != null) {
                        //Console.WriteLine(temporal1.Posx  );
                        temporal1 = temporal1.Derecha;
                        
                        archivo1.Write(" Node" + cont1 + "->Node" + (cont1 + 1) + "\n");
                        archivo1.Write(" Node" + (cont1 + 1) + "->Node" + (cont1) + "\n");
                        cont1++;
                        

                    }


                }
                temporal2 = temporal2.Abajo;
                if (temporal2 == null)
                {
                    break;

                }
                else {
                    
                    temporal1 = temporal2;
                   //Console.WriteLine(temporal1.Posy);
                    //Console.Write("\n");
                }
                
                archivo1.Write(" Node" + (cont2+1 ) + "->Node" + (cont1+1 ) + "\n");
                archivo1.Write(" Node" + (cont1+1 ) + "->Node" + (cont2+1 ) + "\n");
                cont2++;
                //fin for X
            }
            //fin for Y
            archivo1.Write("}");
            archivo1.Close();
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Graphviz2.38\bin\dot.exe");
            startInfo.Arguments = "dot -Tpng \"C:/Users/Jorge Salazar/Desktop/archivo2.txt\" -o \"C:/Users/Jorge Salazar/Desktop/graph1.png\" ";
            Process.Start(startInfo);
        }
    }
}
