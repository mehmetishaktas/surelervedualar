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
	private void sifirla(object sender, EventArgs e)
	{
		i = 0;
		zikir.Text = i.ToString();
		DisplayAlert("SIFIRLANDI","SIFIRLA","TAMAM");
			
	}
}