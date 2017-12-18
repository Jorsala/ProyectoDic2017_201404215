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
            NodoMatriz temporalhor,temporalver;
            int x = 0;
            int y = 0;
            temporalhor = inicio;
            temporalver = inicio;

            archivo1 = new StreamWriter(@"C:\Users\Jorge Salazar\Desktop\archivo2.txt");
            archivo1.Write("Digraph U { \n");
            for (int i =0; i<dimy; i++) {
                for (int j =0;j<dimx; j++ ) {
                    archivo1.Write("Node" + x + "[label=" + "\"" + temporalhor.Dato + "\"]; \n");

                    if (temporalhor != null) {
                        //Console.WriteLine(temporal1.Posx  );
                        temporalhor = temporalhor.Derecha;
                        
                        archivo1.Write(" Node" + x + "->Node" + (x + 1) + "\n");
                        archivo1.Write(" Node" + (x + 1) + "->Node" + (x) + "\n");
                        x++;
                        

                    }


                }
                temporalver = temporalver.Abajo;
                if (temporalver == null)
                {
                    break;

                }
                else {
                    
                    temporalhor = temporalver;
                   //Console.WriteLine(temporal1.Posy);
                    //Console.Write("\n");
                }
                
                archivo1.Write(" Node" + (y+1 ) + "->Node" + (y+1 ) + "\n");
                archivo1.Write(" Node" + (x+1 ) + "->Node" + (y+1 ) + "\n");
                y++;
                //fin for X
            }
            //fin for Y
            archivo1.Write("}");
            archivo1.Close();
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Graphviz2.38\bin\dot.exe");
            startInfo.Arguments = "dot -Tpng \"C:/Users/Jorge Salazar/Desktop/archivo2.txt\" -o \"C:/Users/Jorge Salazar/Desktop/graph1.png\" ";
            Process.Start(startInfo);
        }










        public void recorrerMatriz1(int dimx, int dimy)
        {
            NodoMatriz temporalhor, temporalver, regresador;
            int x = 0;
            int y = 0;
            temporalhor = inicio;
            temporalver = inicio;
            

            archivo1 = new StreamWriter(@"C:\Users\Jorge Salazar\Desktop\archivo3.txt");
            archivo1.Write("Digraph U { \n");
            archivo1.Write("Node" + x + "[label=" + "\"" + temporalhor.Dato + "\"]; \n");



            for (int i =0; i < dimy; i++) {

                for (int j =0; j<dimx; j++) {

                    if(temporalhor != null) {
                        archivo1.Write("\"x = " + temporalhor.Posx + "\" " + "[pos= \"" + ((temporalhor.Posx + 1) * 150) + ","+ ((temporalhor.Posy+1)*-100) + "\"]" + ";\n");
                        temporalhor = temporalhor.Derecha;
                        x++;
                    }

                }
                temporalver = temporalver.Abajo;

                if (temporalver == null)
                {
                    break;

                }
                else
                {

                    temporalhor = temporalver;
                    archivo1.Write("\"y = " + temporalhor.Posx + "\" " + "[pos= \"" + ((temporalhor.Posx + 1) * 150) + "," + ((temporalhor.Posy + 1) * -100) + "\"]" + ";\n");
                    //Console.WriteLine(temporal1.Posy);
                    //Console.Write("\n");
                }
                y++;

            }


            

            archivo1.Write("}");
            archivo1.Close();
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Graphviz2.38\bin\dot.exe");
            startInfo.Arguments = "neato -Tpng \"C:/Users/Jorge Salazar/Desktop/archivo3.txt\" -o \"C:/Users/Jorge Salazar/Desktop/graph2.png\" ";
            Process.Start(startInfo);
        }

    }


}
