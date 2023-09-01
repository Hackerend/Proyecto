using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int faltas,promedio,total;
            promedio = int.Parse(txtPromedio.Text);
            faltas = int.Parse(txtFalta.Text);
            if (promedio > 0 && faltas >= 0)
            {
                if (promedio > 10)
                {
                    MessageBox.Show(String.Format("No puedes ingresar numeros mayores que 10", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    txtEstado.Text = "Error";
                }
                if (faltas >= 10)
                {
                    promedio = promedio - 6;
                }
               else if (promedio >= 6 && promedio <= 10)
                {
                    txtEstado.Text = "Aprovado";
                }

                if (promedio < 6)
                {
                    txtEstado.Text = "Reprobado";
                }
                
            }
            else
            {
                MessageBox.Show(String.Format("No puedes ingresar numeros negativos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                txtEstado.Text = "Error";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEstado.Text = "";
            txtFalta.Text = "";
            txtPromedio.Text = "";
        }
    }
}