namespace BusNerede2;

public partial class PopupPage : ContentPage
{
	public PopupPage()
	{
		InitializeComponent();
	}
    private async void OnCloseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}