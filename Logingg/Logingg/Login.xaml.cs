using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Logingg
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usu = "estudiante2022";
            string contra = "uisrael2022";

            string tusu = txtUsuario.Text;
            string tcontra = txtContrasena.Text;

            if (usu == tusu & contra == tcontra)
            {

                await DisplayAlert("BIENVENIDO", "USUARIO CORRECTO", "ACEPTAR");
                await Navigation.PushAsync(new Registro());
            }

            else
            {
                await DisplayAlert("ERROR", "USUARIO O CONTRASEÑA INCORRECTA", "CERRAR");
            }
        }
    }
}