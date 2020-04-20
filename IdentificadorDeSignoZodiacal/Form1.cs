using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentificadorDeSignoZodiacal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int añoActual;//contendrá el año actual
            int edadDeLaPersona;//contendrá la edad de la persona luego de ser calculada
            int añoSeleccionado;
            int diaSeleccionado;
            int mesSeleccionado;
            
            añoSeleccionado = FechaDeNacimiento.SelectionRange.Start.Year;//contiene el año de nacimiento seleccionado
            diaSeleccionado = FechaDeNacimiento.SelectionRange.Start.Day;//contiene el día de nacimiento
            mesSeleccionado = FechaDeNacimiento.SelectionRange.Start.Month;//contiene el mes de nacimiento

            añoActual = DateTime.Today.Year;//contiene el año de la fecha actual
            edadDeLaPersona = añoActual - añoSeleccionado;//realiza el cálculo para obtener la edad de la persona
            lblEdadResultante.Text = edadDeLaPersona.ToString();

            lblCiudadanoDeOro.Visible = true;
            lblConfirmaciónCiudadanoDeOro.Visible = true;
            lblEdad.Visible = true;
            lblEdadResultante.Visible = true;
            lblSignoZodiacal.Visible = true;
            lblSignoZodiacalResultante.Visible = true;

            if (edadDeLaPersona >= 60)//determina si la persona es ciudadano de oro
            {
                lblConfirmaciónCiudadanoDeOro.Text = "SI";
            }
            else
            {
                lblConfirmaciónCiudadanoDeOro.Text = "NO";
            }


            if((diaSeleccionado >= 21 && mesSeleccionado == 3) || (diaSeleccionado <= 20 && mesSeleccionado == 4))
            {
                lblSignoZodiacalResultante.Text = "Aries";
            }
            else if((diaSeleccionado >= 21 && mesSeleccionado == 4) || (diaSeleccionado <= 21 && mesSeleccionado == 5))
            {
                lblSignoZodiacalResultante.Text = "Tauro";
            }
            else if((diaSeleccionado >= 22 && mesSeleccionado == 5) || (diaSeleccionado <= 21 && mesSeleccionado == 6))
            {
                lblSignoZodiacalResultante.Text = "Géminis";
            }
            else if((diaSeleccionado >= 22 && mesSeleccionado == 6) || (diaSeleccionado <= 23 && mesSeleccionado == 7))
            {
                lblSignoZodiacalResultante.Text = "Cáncer";
            }
            else if((diaSeleccionado >= 24 && mesSeleccionado == 7) || (diaSeleccionado <= 23 && mesSeleccionado == 8))
            {
                lblSignoZodiacalResultante.Text = "Leo";
            }
            else if ((diaSeleccionado >= 24 && mesSeleccionado == 8) || (diaSeleccionado <= 23 && mesSeleccionado == 9))
            {
                lblSignoZodiacalResultante.Text = "Virgo";
            }
            else if((diaSeleccionado >= 24 && mesSeleccionado == 9) || (diaSeleccionado <= 23 && mesSeleccionado == 10))
            {
                lblSignoZodiacalResultante.Text = "Libra";
            }
            else if((diaSeleccionado >= 24 && mesSeleccionado == 10) || (diaSeleccionado <= 22 && mesSeleccionado == 11))
            {
                lblSignoZodiacalResultante.Text = "Escorpio";
            }
            else if((diaSeleccionado >= 23 && mesSeleccionado == 11) || (diaSeleccionado <= 21 && mesSeleccionado == 12))
            {
                lblSignoZodiacalResultante.Text = "Sagitario";
            }
            else if((diaSeleccionado >= 22 && mesSeleccionado == 12) || (diaSeleccionado <= 20 && mesSeleccionado == 1))
            {
                lblSignoZodiacalResultante.Text = "Capricornio";
            }
            else if((diaSeleccionado >= 21 && mesSeleccionado == 1) || (diaSeleccionado <= 19 && mesSeleccionado == 2))
            {
                lblSignoZodiacalResultante.Text = "Acuario";
            }
            else if ((diaSeleccionado >= 20 && mesSeleccionado == 2) || (diaSeleccionado <= 20 && mesSeleccionado == 3))
            {
                lblSignoZodiacalResultante.Text = "Piscis";
            }
        }
    }
}
