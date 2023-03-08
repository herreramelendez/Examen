using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageContac : ContentPage
    {
        public PageContac()
        {
            InitializeComponent();
        }
        protected async void btnsalvar_Clicked(object sender, EventArgs e)
        {
            var con = new Models.Contacto
            {
                nombre = txtnombre.Text,
                telefono = txttelefono.Text,
                edad = edad.Text,
                pais = cbpais.SelectedItem.ToString(),
                nota = txtnota.Text,
               
            };


            if (await App.DBCon.SaveCon(con) > 0)
                await DisplayAlert("Aviso", "Contacto Ingresado", "OK");
            else
                await DisplayAlert("Aviso", "Error", "OK");

            var page = new Views.PageResultado();
            page.BindingContext = con;
            await Navigation.PushAsync(page);

        }
    }
}