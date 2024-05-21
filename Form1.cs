using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;

namespace ProyectoAlgebraLineal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validarButton_Click(object sender, EventArgs e)
        {
            string carnet = carnetTextBox.Text.Trim();

            // Verificar si el carnet tiene 9 dígitos
            if (carnet.Length != 9 || !EsNumero(carnet))
            {
                MessageBox.Show("El carnet ingresado no es válido. Debe tener 9 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si los primeros 4 dígitos están en el rango permitido
            int anio;
            if (!int.TryParse(carnet.Substring(0, 4), out anio) || anio < 2016 || anio > 2024)
            {
                MessageBox.Show("El año en el carnet ingresado no es válido. Debe estar entre 2016 y 2024.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar número de seguridad usando el algoritmo de ISBN-10
            int numSeguridad= GenerarNumSeguridad(carnet);

            // Concatenar el número de seguridad al carnet
            string carnetModificado = carnet + numSeguridad;

            // Mostrar el carnet modificado en el label
            carnetModificadoLabel.Text = carnetModificado;

            // Generar código QR
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(carnetModificado, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Mostrar código QR
            qrCodePictureBox.Image = qrCodeImage;
        }

        private bool EsNumero(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private int GenerarNumSeguridad(string carnet)
        {
            // Se asume que el carnet es válido y tiene 9 dígitos
            int suma = 0;
            for (int i = 0; i < carnet.Length; i++)
            {
                int digito = int.Parse(carnet[i].ToString());
                suma += digito * (i + 1); // Ponderación incremental
            }
            return suma % 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
