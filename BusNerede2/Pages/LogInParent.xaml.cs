namespace BusNerede2;

public partial class LogInParent : ContentPage
{
	public LogInParent()
	{
		InitializeComponent();
	}

    private async void logInParent_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Home");

    }
}