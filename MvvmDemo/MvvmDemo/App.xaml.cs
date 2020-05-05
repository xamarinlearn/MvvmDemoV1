using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmDemo
{
    public partial class App : Application
    {
       public static ViewModels.EmpleadoViewModel EVM;
        public App()
        {
            EVM = new ViewModels.EmpleadoViewModel();
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ListaEmpleados());
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
