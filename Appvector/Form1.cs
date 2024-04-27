using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Appvector
{
    public partial class Form1 : Form
    {
        clsVector v = new clsVector();
        public Form1()
        {
            InitializeComponent();
        }
        private void mostrarVector(){
            lblResultado.Text = "[";
            for (int i = 0; i < v.longitud(); i++)
            {
                lblResultado.Text = lblResultado.Text + v.obtenervalor(i) + " , ";
            }
            lblResultado.Text = lblResultado.Text + "]";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
        }
    }
}
