namespace Notes.Views;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();

        Button button = new Button
        {
            Text = "Navigate!",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        button.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new HelloXamlPage());
        };

        Content = button;
    }
}