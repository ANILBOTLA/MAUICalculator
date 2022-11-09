using Calculator.Views;

namespace Calculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));

        MainPage = new FlyoutPageMain();

       
    }
}
