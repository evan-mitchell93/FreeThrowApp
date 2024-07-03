namespace FreeThrowTracking;

public partial class FreeThrowPage : ContentPage
{
	public String ft_date;
	public FreeThrowPage(String date)
	{
        InitializeComponent();
        ft_date = date;
        FT_Date.Text = ft_date;
    }

}