using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhonSuntaxiExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vistaLogin : ContentPage
    {
        public vistaLogin()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user_val = "estudiante2020";
            string pass_val = "uisrael2020";
            string usuario = txtUsuario.Text;
            string password = txtPasswd.Text;

            try
            {
                if (user_val == usuario && pass_val == password)
                {
                    await Navigation.PushAsync(new MainPage(user_val, pass_val));
                }
                else
                {
                    string mensaje = "Usuario o contraseña incorrectos";
                    await DisplayAlert("Mensaje de Alerta", mensaje, "Aceptar");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de Alerta", ex.Message, "Aceptar");
            }
        }
    }
}