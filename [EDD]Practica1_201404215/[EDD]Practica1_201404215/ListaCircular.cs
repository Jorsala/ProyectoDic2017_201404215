using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace _EDD_Practica1_201404215
{
    class ListaCircular
    {

        TextWriter archivo;
        NodoLC inicio = new NodoLC();
        NodoLC fin = new NodoLC();
        
        int contadorLista = 0;

        public ListaCircular() {
            inicio = null;
            fin = null;


        }

        public void insertarLC(NodoLC nuevo) {
            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
                inicio.Siguiente = inicio;
                inicio.Anterior = fin;
                Console.WriteLine("Se inserto un nodo en la lista vacia "+ nuevo.Nombre.ToString());
                
                contadorLista++;

            }
            else {
                fin.Siguiente = nuevo;
                inicio.Anterior = nuevo;
                nuevo.Anterior = fin;
                nuevo.Siguiente = inicio;
                fin = nuevo;
                contadorLista++;
                Console.WriteLine("Se inserto un nodo en la lista no vacia " + nuevo.Nombre);


                //NodoLC tempo = inicio;
                //while (tempo.Siguiente != inicio) {
                //    tempo = tempo.Siguiente;

                //}
                //tempo.Siguiente = nuevo;
                //nuevo.Siguiente = inicio;

            }
        }

        public void recorrerLista(NodoLC temporal) {
            temporal = inicio;
            archivo = new StreamWriter(@"C:\Users\Jorge Salazar\Desktop\archivo1.txt");
            archivo.Write("Digraph U { \n");
            int contador = 0;
            Console.WriteLine("el tamaño de la lista es " + contadorLista);

            if (temporal != null)
            {
                do
                {
                    Console.WriteLine("el nodo es " + temporal.Nombre);
                    archivo.Write("Node" + contador + "[label=" + "\"" + temporal.Nombre + "\"]; \n");
                    if (temporal.Siguiente != inicio)
                    {
                        archivo.Write(" Node" + contador + "->Node" + (contador + 1) + "\n");
                       archivo.Write(" Node" + (contador+1)+ "->Node" + (contador ) + "\n");
                    }
                    else {
                        archivo.Write("Node" + contador + "->Node0 \n");
                        archivo.Write("Node0->"  + "Node"+ contador+ " \n");
                    }
                    temporal = temporal.Siguiente;
                    contador++;


                } while (temporal != inicio); 



                //do
                //{
                //    Console.WriteLine("el nodo es " + temporal.Nombre);
                //    archivo.Write("Node" + contadorLista + "[label=" + "\"" + temporal.Nombre + "\"]; \n");
                //    if (temporal.Anterior != inicio)
                //    {
                //        archivo.Write(" Node" + contadorLista + "->Node" + (contadorLista - 1) + "\n");
                //    }
                //    else
                //    {
                //        archivo.Write("Node" + contadorLista + "->Node0 \n");
                //    }
                //    temporal = temporal.Anterior;
                //    contadorLista--;


                //} while (temporal != inicio);

                archivo.Write("}");
                archivo.Close();
                ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Graphviz2.38\bin\dot.exe");
                startInfo.Arguments = "dot -Tpng \"C:/Users/Jorge Salazar/Desktop/archivo1.txt\" -o \"C:/Users/Jorge Salazar/Desktop/graph.png\" ";
                Process.Start(startInfo);

            }
            else {
                Console.WriteLine("la lista esta vacia ");
                archivo.Write("}");
                archivo.Close();
                ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Graphviz2.38\bin\dot.exe");
                startInfo.Arguments = "dot -Tpng \"C:/Users/Jorge Salazar/Desktop/archivo1.txt\" -o \"C:/Users/Jorge Salazar/Desktop/graph.png\" ";
                Process.Start(startInfo);
            }

        }

        public void buscarNodoLC(String nombre, String Contra) {
            NodoLC temporal = inicio;
            while (temporal != inicio) {
                if (temporal.Nombre == nombre && temporal.Pass1 == Contra)
                {
                    Console.Write("El nodo si se encontro");
                    MessageBox.Show("Encontre el usuario");
                    break;
                }
                else {
                    Console.Write("el nodo no se encontro");
                }
                temporal =temporal.Siguiente;
                

            }
            //temporal es el nodo de los datos ingresados, que voy a usar para trabjar
            
        }
    }
}
