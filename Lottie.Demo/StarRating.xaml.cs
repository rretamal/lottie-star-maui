using CommunityToolkit.Maui.Views;

namespace Lottie.Demo;

public partial class StarRating : Popup
{
	public StarRating()
	{
		InitializeComponent();
		
	}

	public async Task ShowStarAnimation() {
		await Task.Delay(400);

		star1.IsAnimationEnabled = true;

        await Task.Delay(1200);

        star2.IsAnimationEnabled = true;

        await Task.Delay(1200);

        star3.IsAnimationEnabled = true;
    }
}
