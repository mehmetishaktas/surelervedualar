
namespace surelervedualar
{
    public partial class MainPage : ContentPage
    {
        private GunlukDiniSozler gunluksozler;
        public MainPage()
        {
            InitializeComponent();
            gunluksozler=new GunlukDiniSozler();
            string soz = gunluksozler.BugunDiniSoz();
            txtdinisoz.Text = soz;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }
        private void dualar(object sender,EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }
        private void hadisler(object sender,EventArgs e)
        {

        }
        private void sureler(object sender,EventArgs e)
        {

        }
        private void zikir(object senrde, EventArgs e)
        {

        }
    }

}
