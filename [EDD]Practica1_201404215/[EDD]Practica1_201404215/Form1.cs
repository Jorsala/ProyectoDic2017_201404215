using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _EDD_Practica1_201404215.Properties;

namespace _EDD_Practica1_201404215
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        ListaCircular list = new ListaCircular();
       
        NodoLC temp = new NodoLC();
        public void insertarenLista() {
            
       
        }


   

        public void button1_Click(object sender, EventArgs e)
        {
            NodoLC nuevo1 = new NodoLC();
            nuevo1.Nombre = txtUs.Text;
            nuevo1.Pass1 = txtPass.Text;

            list.insertarLC(nuevo1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.recorrerLista(temp);
        }
    }
}
