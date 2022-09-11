namespace MyTouchEffect;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = new SampleViewModel();
	}
}

