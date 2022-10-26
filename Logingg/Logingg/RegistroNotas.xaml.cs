using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Logingg
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnregistro_Clicked(object sender, EventArgs e)
        {
            string nonbre = txtNombre.Text;
            double nota1 = Convert.ToDouble(txtnota1.Text);
            double notaexam1 = Convert.ToDouble(txtnotaexam1.Text);
            double nota2 = Convert.ToDouble(txtnota2.Text);
            double notaexam2 = Convert.ToDouble(txtnotaexam2.Text);

            nota1 = nota1 * 0.3;
            notaexam1 = notaexam1 * 0.2;

            double notaParcial = nota1 + notaexam1;

            nota2 = nota2 * 0.3;
            notaexam2 = notaexam2 * 0.2;
            double notaParcial2 = nota2 + notaexam2;

            double notafinal = notaParcial + notaParcial2;

            if (notafinal >= 7)
            {

                DisplayAlert("FELICITACIONES", "ESTIMADO ESTUDIANTE " + nonbre + " NOTA FINAL ES: " + notafinal + " USTED APRUEBA EL SEMESTRE", "ACEPTAR");
            }
            else
            {
                DisplayAlert("ALERTA", "ESTIMADO ESTUDIANTE " + nonbre + " NOTA FINAL ES: " + notafinal + "  USTED REPRUEBA, RENDIR SUPLETORIO ", "CERRAR");
            }
        }

    }
}