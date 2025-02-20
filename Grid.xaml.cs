namespace FlexLayaoutDemo_JOVT;

public partial class Grid : ContentPage
{
	public Grid()
	{
		InitializeComponent();
	}
    private void next_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayaout());
    }
}