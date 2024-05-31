namespace BusNerede2;

public partial class PopupPage2 : ContentPage
{
	public PopupPage2()
	{
		InitializeComponent();
	}

    private async void OnCloseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}