using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // var glol
        Queue<String> ColaNombre = new Queue<String>();
        void Agregar()
        {
            //agrgear cola
            ColaNombre.Enqueue(txtElemento.Text);
            //imprimir
            lbCola.Items.Clear();
            foreach(var item in ColaNombre)
            {
                lbCola.Items.Add(item);
                lbCola.Items.Add("_____________");
            }
            txtElemento.Clear();
            txtElemento.Focus();
        }

        void Imprimir()
        {
            lbCopiaCola.Items.Clear();
            foreach(var item in ColaNombre)
            {
                lbCopiaCola.Items.Add(item);
                lbCopiaCola.Items.Add("_____________");
            }
        }

        private void txtElemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                Agregar();
            }
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void rbCopiar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCopiar.Checked==true)
            {
                Imprimir();
            }
        }

        private void rbPop_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPop.Checked==true)
            {
                lbImprimir.Items.Add("Scado de lista" + ColaNombre.Dequeue());
                Imprimir();
            }
        }

        private void rbPeek_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPeek.Checked== true)
            {
                lbImprimir.Items.Add("Primer elemento" + ColaNombre.Peek());
                Imprimir();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                if(ColaNombre.Contains(txtBuscar.Text)==true)
                {
                    MessageBox.Show("Existe");
                }
                else
                {
                    MessageBox.Show("No existe");
                    
                }
                txtBuscar.Clear();
                txtBuscar.Focus();
            }
        }
    }
}
