using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCustoViagem
{
    public partial class App : Application
    {
        public static ObservableCollection<Pedagio> ListaPedagios = new ObservableCollection<Pedagio>();

        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            MainPage = new NavigationPage(new DadosViagem));
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
