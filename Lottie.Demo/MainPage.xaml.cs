using CommunityToolkit.Maui.Views;

namespace Lottie.Demo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        btnRating.Clicked += BtnRating_Clicked;
	}

    private async void BtnRating_Clicked(object sender, EventArgs e)
    {
        var popup = new StarRating();
        this.ShowPopup(popup);
        await popup.ShowStarAnimation();
    }
}


