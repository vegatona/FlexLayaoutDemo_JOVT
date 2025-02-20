namespace FlexLayaoutDemo_JOVT;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}

    private void next_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsoluteLayout());
    }
}