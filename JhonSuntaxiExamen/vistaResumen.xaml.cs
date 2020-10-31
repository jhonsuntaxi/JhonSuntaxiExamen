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
    public partial class vistaResumen : ContentPage
    {
        public vistaResumen(string nombre, string usuario, string cuotas)
        {
            double diferencia = Convert.ToDouble(cuotas) * 3;
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtCuotas.Text = cuotas.ToString();
            txtTotak.Text = diferencia.ToString();
        }
    }
}