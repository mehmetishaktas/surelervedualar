using System.Linq;
using static surelervedualar.düalar;

namespace surelervedualar
{
    public partial class NewPage1 : ContentPage
    {
        private bool butonlarYuklendi = false;
        public NewPage1()
        {
            InitializeComponent();


        }
        private List<Dua> dualar = new List<Dua>
        {

             new Dua ("1. Fatiha Suresi", "Bismillahirrahmanirrahim\nElhamdülillahi rabbil alemin\nErrahmanirrahim\nMaliki yevmiddin\nÝyyake na'budu ve iyyake nasta'in\nÝhdinas siratal mustakim\nSiratallezine en'amte aleyhim gayril maðdubi aleyhim ve leddalin\n" ),
                new Dua (  "2. Ayet-el Kürsi (Bakara 255)",  "Allahu la ilahe illa huve’l-hayyul-kayyum.\nLa te’huzuhu sinetün ve la nevmun.\nLehu ma fissemavati ve ma filardý.\nMen zallezî yeþfe’u indehû illa biiznih.\nYa'lemu ma beyne eydîhim ve ma halfehüm.\nVe la yühîtûne biþey'in min ilmihî illa bimeþa'.\nVasý’a kürsiyyühü's-semaavati ve'l-arz.\nVe la yeûduhû hýfzuhumâ ve huve'l-aliyyü'l-azîm.\n"),
                new Dua (  "3. Ýhlas Suresi",  "Bismillahirrahmanirrahim\nKul huvallahu ehad\nAllahus-samed\nLem yelid ve lem yuled\nVe lem yekun lehu kufuven ehad\n" ),
                new Dua (  "4. Nas Suresi",  "Bismillahirrahmanirrahim\nKul e'uzu bi rabbin nas\nMelikin nas\nÝlahin nas\nMin þerril vesvasil hannas\nEllezî yüvesvisü fî sudûrin nas\nMinal cinneti vennas\n" ),
                new Dua (  "5. Felak Suresi",  "Bismillahirrahmanirrahim\nKul e'uzu bi rabbil felak\nMin þerrimâ halak\nVe min þerrin gâsikýn izâ vakab\nVe min þerrin nâffâsâti fîl-‘uqad\nVe min þerrin hâsidin izâ hasad\n" ),
                new Dua (  "6. Sabah Duasý",  "Bismillahirrahmanirrahim\nElhamdülillahillezî ahyânâ ba'de mâ emâtânâ ve ileyhin nûþûr.\n" ),
                new Dua (  "7. Akþam Duasý", "Bismillahirrahmanirrahim\nE'ûzu billahi min eþ-þeytanir racim\nBismillahi'l-lezi lâ yadurru ma'ismihi þey'un fi'l-arzi ve la fi's-semâi ve huve's-semî'u'l-‘alîm.\n" ),
                new Dua (  "8. Seyahat Duasý", "Allahümme inni estaðfiruka min kulli dhambin.\nVe e'ûzu bike min kulli þerrin.\n" ),
                new Dua (  "9. Rýzýk Ýçin Dua", "Allahümme inni es’eleke min fadlike ve rahmetike ve min güyûbi rahmetike.\n" ),
                new Dua (  "10. Sübhânallâhî ve bihamdihî",  "Sübhânallâhî ve bihamdihî adede halkihî ve rýdâ nefsehî ve zinete arþihî ve mideyât kelimâtihî.\n" ),
                new Dua (  "11. La ilahe illallah",  "La ilahe illallah, vahdehû lâ þerîke lehu, lehu ve levlâke rabbâ, evvelûn ve âhýrûn.\n" ),
                new Dua (  "12. Ev Ýçin Dua",  "Bismillah ilahî, min beyt-i mukaddes ve nefs-i þerifi.\n" ),
                new Dua (  "13. Çocuk Ýçin Dua",  "Rabbi inneee limâ enzelte ileyye min hayrin fakîr.\n" ),
                new Dua (  "14. Vefat Duasý",  "Allahümme la tuharrisûlâ senin hidayetin.\n"),
                new Dua (  "15. Aþk ve Sevgi Ýçin Dua", "Allahümme ushrýhî fî, bihimre hemem þevveli ve hâlani.\n" ),
                new Dua (  "16. Yatmadan Önce Okunacak Dua", "Bismillahirrahmanirrahim\nE'ûzu billahi min eþ-þeytanir racim\nBismillahi'l-lezi lâ yadurru ma'ismihi þey'un fi'l-arzi ve la fi's-semâi ve huve's-semî'u'l-‘alîm.\n" )
            };


        //  // Dualarý buton olarak ekleme
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Butonlar daha önce eklenmiþse, tekrar eklemiyoruz
            if (!butonlarYuklendi)
            {
                LoadDualar();
                butonlarYuklendi = true;  // Butonlarýn yüklendiðini iþaretle
            }
        }

        private void LoadDualar()
        {
            // stackLayout'un null olup olmadýðýný kontrol et
            if (stackLayout != null)
            {
                // Öncelikle stackLayout'taki mevcut çocuklarý temizleyelim (isteðe baðlý)
                stackLayout.Children.Clear();

                foreach (var dua in dualar)
                {
                    // Ayný dua zaten var mý diye kontrol et
                    bool butonVarMi = false;
                    foreach (var child in stackLayout.Children)
                    {
                        if (child is Button button && button.Text == dua.Adi)
                        {
                            butonVarMi = true;
                            break;
                        }
                    }

                    // Eðer buton daha önce eklenmediyse, yeni bir buton ekle
                    if (!butonVarMi)
                    {
                        Button duaButton = new Button
                        {
                            Text = dua.Adi,
                            FontSize = 20,
                            HorizontalOptions = LayoutOptions.Fill,
                            Margin = 20

                        };

                        // Butona týklama olayý ekleme
                        duaButton.Clicked += (sender, e) =>
                        {
                            DisplayAlert(dua.Adi, dua.Icerik, "Tamam");
                        };

                        // Butonu stackLayout'a ekliyoruz
                        stackLayout.Children.Add(duaButton);
                    }
                }
            }
            else
            {
                DisplayAlert("Hata", "StackLayout bulunamadý.", "Tamam");
            }
        }
    }
}







