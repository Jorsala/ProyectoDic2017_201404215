using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _EDD_Practica1_201404215
{
    public partial class Usuario : Form
    {
        ListaCircular list;
        NodoLC temp = new NodoLC();
        Matriz ma = new Matriz();
        public Usuario(ListaCircular lista)
        {
            InitializeComponent();
            list = new ListaCircular();
            list = lista;
           
           
        }
       

     

        private void button1_Click(object sender, EventArgs e)
        {
            list.recorrerLista(temp);
       
        }
    }
}
