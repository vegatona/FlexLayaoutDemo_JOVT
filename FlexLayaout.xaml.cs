namespace FlexLayaoutDemo_JOVT;

public partial class FlexLayaout : ContentPage
{
	public FlexLayaout()
	{
		InitializeComponent();
	}
    private void next_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new StackLayout());
    }
}