using FoxRedCompany.Views;

namespace FoxRedCompany
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContenPage();
        }
    }
}