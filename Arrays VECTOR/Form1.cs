using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_VECTOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnCargarVector_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int[] notas=new int[5];
            //Especificar notas
            notas[0] = 20;
            notas[1]=40;
            notas[2] = 60;
            notas[3] = 70;
            notas[4] = 50;

            int suma = 0;
            double promedio;

            //Proceso
            cboNotas.Items.Clear();
            //Recorrer vector
            for (int i = 0; i <= 4; i++)
            {
                //Mostrar notas en el combobox
                cboNotas.Items.Add(notas[i]);
                suma = suma + notas[i];
            }
            promedio = suma / 5;
            //Salida de Informacion 
            txtPromedio.Text=Convert.ToString(promedio);
            



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            cboNotas.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
