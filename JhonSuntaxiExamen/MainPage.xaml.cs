﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JhonSuntaxiExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string passwd)
        {
            string user = usuario;
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: " + usuario;
        }


        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double montoInicial = Convert.ToDouble(txtMonto.Text);
            double subCuota = 0;
            double cuota = 0;

            if (montoInicial > 0 && montoInicial < 1800)
            {
                subCuota = 1800 - montoInicial;
                cuota = ((subCuota * .05) + subCuota) / 3;
                txtMensual.Text = cuota.ToString();
            }
            else
            {
                txtMonto.Text = "";
                DisplayAlert("Mensaje de Alerta", "EL monto ingresado esta fuera del rango", "Aceptar");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string cuotas = txtMensual.Text;
            string usuario = lblUsuario.Text;

            if (txtMonto.Text == "" || txtNombre.Text == "" || txtMensual.Text == "")
            {
                await DisplayAlert("Mensaje de alerta", "Debe llenar todos los campos", "Aceptar");
            }
            else
            {
                await DisplayAlert("Mensaje de alerta", "Elemento guardado con exito", "Aceptar");
                await Navigation.PushAsync(new vistaResumen(nombre, usuario, cuotas));
            }

        }

    }
}
