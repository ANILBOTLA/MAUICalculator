using Calculator.Views;

namespace Calculator;

public partial class MenuPageItem : ContentPage
{
    public Type TitleType { get; set; }
    public Type TargetType { get; set; }

    public MenuPageItem()
    {

        Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
        InitializeComponent();
    }
}
