namespace surelervedualar;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
		InitializeComponent();
	}
	int i = 0;
    private void art�r(object sender, EventArgs e)
	{
		i++;
		zikir.Text =i.ToString();
	}
}