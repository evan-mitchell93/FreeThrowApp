using FreeThrowTracking.Maui.Data;

namespace FreeThrowTracking
{
    public partial class App : Application
    {
        public static DataRepository DataRepository { get; set; }
        public App(DataRepository dataRepo)
        {
            InitializeComponent();

            DataRepository = dataRepo;
            MainPage = new AppShell();
        }
    }
}
