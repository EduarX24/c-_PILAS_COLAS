using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pilas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //var globales
        Stack<String> PilaNombre = new Stack<String>();

        //metodo mostrar
        void Imprimir()
        {
            lbCopiaPila.Items.Clear();
            foreach(var item in PilaNombre)
            {
                lbCopiaPila.Items.Add(item);
                lbCopiaPila.Items.Add("________________");
            }
            
        }

        void Agregar()
        {
            //Agregar a pila
            PilaNombre.Push(txtElemento.Text);

            //mostrar en listbox
            lbPila.Items.Clear();
            foreach(var item in PilaNombre)
            {
                lbPila.Items.Add(item);
                lbPila.Items.Add("______________");
            }
            txtElemento.Clear();
            txtElemento.Focus();
        }

        private void txtElemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                Agregar();
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void rbCopy_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCopy.Checked==true)
            {
                Imprimir();
            }
        }

        private void rbPop_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPop.Checked== true)
            {
                lbImprimir.Items.Add("Popping/Desapilado: " + PilaNombre.Pop());
                Imprimir();
            }
        }

        private void rbPeek_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPeek.Checked == true)
            {
                lbImprimir.Items.Add("Primer Elemento en la pila: " + PilaNombre.Peek());
                Imprimir();
            }
        }
    }
}
