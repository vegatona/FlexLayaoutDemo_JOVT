namespace FlexLayaoutDemo_JOVT;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}
    private void next_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Grid());
    }
}