using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace BusNerede2;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}

    private void submitNewPassword_Clicked(object sender, EventArgs e)
    {

    }

    private void OnToggled(object sender, ToggledEventArgs e)
    {
        bool isToggled = e.Value;

    }


}