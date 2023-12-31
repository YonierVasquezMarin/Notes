using Notes.Views.XamlSamples;

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
        await Navigation.PushAsync(new SliderPage());
    }

    async private void GoToGridDemoPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridDemo());
    }

    async private void GoToSharedPropertiesPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SharedProperties());
    }

    async private void GoToSliderTransformsPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SliderTransforms());
    }
}