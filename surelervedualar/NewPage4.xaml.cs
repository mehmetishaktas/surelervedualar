namespace surelervedualar;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
		InitializeComponent();
	}
	int i = 0;
    private void artýr(object sender, EventArgs e)
	{
		i++;
		zikir.Text =i.ToString();
	}
}