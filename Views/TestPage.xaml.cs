namespace Notes.Views;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();
    }

    async private void GoToHelloXamlPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HelloXamlPage());
    }

    async private void GoToSliderPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HelloXamlPage());
    }
}