using MAUILite.Services;
using MAUILite.Views;

namespace MAUILite
{
    public partial class App : Application
    {
        public static ProductoRepository ProductoRepository { get; set; }
        public App()
        {
            InitializeComponent();
            ProductoRepository = new ProductoRepository();
            MainPage = new NavigationPage(new ProductoPage());
        }
    }
}



