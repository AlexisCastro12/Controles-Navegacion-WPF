using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;

namespace WPFControlesYNavegacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            try
            {
                double xi, xf, h, x, y;
                int n;
                string fx;
                // chart1.Series.Clear();
                xi = double.Parse(tBxi.Text);
                xf = double.Parse(tBxf.Text);
                fx = tBfx.Text;
                n = chart1.Width;
                h = (xf - xi) / n;
                for (int k = 0; k < n; k++)
                {
                    x = xi + k * h;
                    y = fu(x, fx);
                    chart1.Series["Series1"].Points.AddXY(x, y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor llene todos los campos o escriba una funcion f(x) válida");
            }
}

        double fu(double x, string fx)
        {
                double r;
                ExpressionParser par1 = new ExpressionParser();
                par1.Values.Add("x", x);
                r = par1.Parse(fx);
                return r;   
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Castro.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
