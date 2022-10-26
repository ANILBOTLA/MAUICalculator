namespace Calculator;

public partial class AppColor : ContentPage
{
    public AppColor()
    {
        InitializeComponent();
    }

  

    private void OnButtonClicked(Object sender, EventArgs e)
    {
        Button button = (Button)sender;
        Navigation.PushAsync(new UpdatedMain(button.BackgroundColor));

    }
}
