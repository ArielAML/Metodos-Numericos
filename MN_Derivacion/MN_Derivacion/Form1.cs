using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MN_Derivacion
{
    public partial class Form1 : Form
    {
        double x4=0, x3=0, x2=0, x1=0, x=0, xi=0, h=0, rderiv=0;
        string tipoDeriv, derivada, error;

        public Form1()
        {
            InitializeComponent();
        }

        private void tRdA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cbtdd.SelectedIndex = 0;
            cbder.SelectedIndex = 0;
            cberr.SelectedIndex = 0;
            cberr.Items.Clear();
            cberr.Items.Add("O(h^2)");
            cberr.Items.Add("O(h^4)");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void Calcular()
        {
            x4 = double.Parse(C4.Text);
            x3 = double.Parse(C3.Text);
            x2 = double.Parse(C2.Text);
            x1 = double.Parse(C1.Text);
            x = double.Parse(C.Text);
            tipoDeriv = cbtdd.Text.ToString();
            error = cberr.SelectedItem.ToString();
            derivada = cbder.SelectedItem.ToString();

            try
            {
                switch (tipoDeriv)
                {

                    case "Hacia adelante":
                        if (derivada =="Primer derivada")
                        {
                            if (error == "O(h)")
                            {
                                rderiv = ((ResolvFuncion(xi + h)) - (ResolvFuncion(xi))) / (2 * h);
                                tRdA.Text = rderiv.ToString();
                            }
                            else if (error == "O(h^2)")
                            {
                                rderiv = ((-ResolvFuncion(xi + (h * 2))) + (4 * ResolvFuncion(xi + h))) - (3 * ResolvFuncion(xi)) / (2 * h);
                                tRdA.Text = rderiv.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No hay O(h) diferentes en las opciones de derivacion hacia adelante");
                            }
                        }
                        else if (derivada == "Segunda derivada")
                        {
                            if (error == "O(h)")
                            {
                                rderiv = ((ResolvFuncion(xi + (2*h))) - (ResolvFuncion(xi+h))+ (ResolvFuncion(xi))) / (Math.Pow(h,2));
                                tRdA.Text = rderiv.ToString();
                            }
                            else if (error == "O(h^2)")
                            {
                                rderiv = ((-ResolvFuncion(xi + (3*h))) + (4 * ResolvFuncion(xi + (2*h))) - (5 * ResolvFuncion(xi+h))+(2*ResolvFuncion(xi))) / (Math.Pow(h,2));
                                tRdA.Text = rderiv.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No hay O(h) diferentes en las opciones de derivacion centrada");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hubo un raro error inesperado :O");
                        }
                        break;

                    case "Centrada":
                        if (derivada == "Primer derivada")
                        {
                            if (error == "O(h^2)")
                            {
                                rderiv = ((ResolvFuncion(xi + h)) - (ResolvFuncion(xi-h))) / (2 * h);
                                tRdA.Text = rderiv.ToString();
                            }
                            else if (error == "O(h^4)")
                            {
                                rderiv = ((-ResolvFuncion(xi + (h * 2))) + (8 * ResolvFuncion(xi + h)) - (8 * ResolvFuncion(xi-h))+(ResolvFuncion(xi-(2*h)))) /(12 * h);
                                tRdA.Text = rderiv.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No hay O(h) diferentes en las opciones de derivacion hacia adelante");
                            }
                        }
                        else if (derivada == "Segunda derivada")
                        {
                            if (error == "O(h^2)")
                            {
                                rderiv = (ResolvFuncion(xi + h) - (2*ResolvFuncion(xi)) + ResolvFuncion(xi-h)) / (Math.Pow(h, 2));
                                tRdA.Text = rderiv.ToString();
                            }
                            else if (error == "O(h^4)")
                            {
                                rderiv = (-ResolvFuncion(xi + (2 * h)) + (16 * ResolvFuncion(xi + h)) - (30 * ResolvFuncion(xi)) + (16 * ResolvFuncion(xi-h))-(ResolvFuncion(xi-(2*h)))) / (12*Math.Pow(h, 2));
                                tRdA.Text = rderiv.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No hay O(h) diferentes en las opciones de derivacion centrada");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hubo un raro error inesperado :O");
                        }
                        break;

                   case "Hacia atras":
                        if (derivada == "Primer derivada")
                        {
                            if (error == "O(h)")
                            {
                                rderiv = ((ResolvFuncion(xi)) - (ResolvFuncion(xi-h))) / (2 * h);
                                tRdA.Text = rderiv.ToString();
                            }
                            else if (error == "O(h^2)")
                            {
                                rderiv = ((3*ResolvFuncion(xi)) - (4 * ResolvFuncion(xi - h)) + (ResolvFuncion(xi-(2*h)))) / (2 * h);
                                tRdA.Text = rderiv.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No hay O(h) diferentes en las opciones de derivacion hacia adelante");
                            }
                        }
                        else if (derivada == "Segunda derivada")
                        {
                            if (error == "O(h)")
                            {
                                rderiv = ((ResolvFuncion(xi)) - (2*ResolvFuncion(xi - h)) + (ResolvFuncion(xi+(2*h)))) / (Math.Pow(h, 2));
                                tRdA.Text = rderiv.ToString();
                            }
                            else if (error == "O(h^2)")
                            {
                                rderiv = ((2*ResolvFuncion(xi)) - (5 * ResolvFuncion(xi -h)) + (4 * ResolvFuncion(xi + (2*h))) - (ResolvFuncion(xi-(3*h)))) / (Math.Pow(h, 2));
                                tRdA.Text = rderiv.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No hay O(h) diferentes en las opciones de derivacion centrada");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hubo un raro error inesperado :O");
                        }
                        break;

                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Los datos no han sido llenados correctamente");
            }
        }

        public double ResolvFuncion(double XI)
        {
            double funcion = ((Math.Pow(XI, 4) * x4) + (Math.Pow(XI, 3) * x3) + (Math.Pow(XI, 2) * x2) + (XI * x1) + x);
            return funcion;
        }
        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            C4.Clear();
            txi.Clear();
            th.Clear();
            tRdA.Clear();
        }

        private void cbtdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtdd.SelectedItem.ToString() == "Centrada")
            {
                cberr.Items.Clear();
                cberr.Items.Add("O(h^2)");
                cberr.Items.Add("O(h^4)");
                cberr.SelectedIndex = 0;
            }
            else
            {
                cberr.Items.Clear();
                cberr.Items.Add("O(h)");
                cberr.Items.Add("O(h^2)");
                cberr.SelectedIndex = 0; ;
            }
        }

        private void cbder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
