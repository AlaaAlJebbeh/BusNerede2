namespace BusNerede2;

public partial class Children : ContentPage
{
	public Children()
	{
		InitializeComponent();
	}

    private async void OnInfoButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new PopupPage());
    }
    private async void OnInfoButtonClicked2(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new PopupPage2());
    }
}