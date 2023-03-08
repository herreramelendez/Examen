using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Examen.Views;
using Examen.Models;

namespace Examen
{
    public partial class App : Application
    {
        static Controllers.ContactosController dbcon;
        public static Controllers.ContactosController DBCon
        {
            get
            {
                if (dbcon == null)
                {
                    var dbpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "Con.db3";
                    dbcon = new Controllers.ContactosController(Path.Combine(dbpath, dbname));
                }
                return dbcon;
            }
        }
       public App()
        {
            InitializeComponent();
           MainPage = new NavigationPage(new Views.PageInitial());
        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}
