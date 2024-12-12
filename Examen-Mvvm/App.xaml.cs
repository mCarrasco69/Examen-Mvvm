//namespace Examen_Mvvm
//{
//    public partial class App : Application
//    {
//        public App()
//        {
//            InitializeComponent();

//            MainPage = new AppShell();
//        }
//    }
//}

using Microsoft.Maui.Controls;

namespace ExamenMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.MainPage(); // Asegúrate de que este es el namespace correcto
        }
    }
}
