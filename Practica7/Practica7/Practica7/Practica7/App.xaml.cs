using Practica7.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Practica7
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            //Escribe aqui el nombre del View que deseas visualizar
            MainPage = new SoftInputModeAdjustPage();
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
