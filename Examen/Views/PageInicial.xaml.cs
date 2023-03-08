using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageInitial : ContentPage
    {
        public PageInitial()
        {
            InitializeComponent();
        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var pagecontac = new Views.PageContac();
            Navigation.PushAsync(pagecontac);
        }
        private void listaconta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listaconta.ItemsSource = await App.DBCon.GetListcon();

        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}