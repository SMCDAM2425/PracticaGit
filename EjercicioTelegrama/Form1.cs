using System.Windows.Forms;
using System;

namespace EjercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama = txtTelegrama.Text;
            char tipoTelegrama;
            int numPalabras = textoTelegrama.Split(' ').Length;
            double coste;

            // Determinar el tipo de telegrama
            if (rbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else
            {
                tipoTelegrama = 'o';
            }

            // Calcular el coste
            if (tipoTelegrama == 'o') // Telegrama ordinario
            {
                if (numPalabras <= 10)
                {
                    coste = 3;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else // Telegrama urgente
            {
                if (numPalabras <= 10)
                {
                    coste = 6;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            // Mostrar el precio
            txtPrecio.Text = $"{coste:F2} euros";
        }
    }
}

