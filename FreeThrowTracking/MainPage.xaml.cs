namespace FreeThrowTracking
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //Start button will automatically create a page for tracking 
        //The current date's statistics
        private void GoToToday(object sender, EventArgs e)
        {
            String? Today = DateTime.Today.ToString("d");
            Navigation.PushAsync(new FreeThrowPage(Today));
            App.DataRepository.Init();
        }

        //Manage Roster will load page for adding/removing/editing player details
        private void GoToRoster(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RosterManagementPage());
        }
    }

}
