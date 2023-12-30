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

        button.Clicked += (sender, args) =>
        {
            Console.WriteLine("Button clicked!");
        };

        Content = button;
    }
}