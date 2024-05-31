namespace BusNerede2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void logInSchoolID_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Children");

        }

    }

}
