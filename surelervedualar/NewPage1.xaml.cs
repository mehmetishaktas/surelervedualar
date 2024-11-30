using System.Linq;
using static surelervedualar.d�alar;

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

             new Dua ("1. Fatiha Suresi", "Bismillahirrahmanirrahim\nElhamd�lillahi rabbil alemin\nErrahmanirrahim\nMaliki yevmiddin\n�yyake na'budu ve iyyake nasta'in\n�hdinas siratal mustakim\nSiratallezine en'amte aleyhim gayril ma�dubi aleyhim ve leddalin\n" ),
                new Dua (  "2. Ayet-el K�rsi (Bakara 255)",  "Allahu la ilahe illa huve�l-hayyul-kayyum.\nLa te�huzuhu sinet�n ve la nevmun.\nLehu ma fissemavati ve ma filard�.\nMen zallez� ye�fe�u indeh� illa biiznih.\nYa'lemu ma beyne eyd�him ve ma halfeh�m.\nVe la y�h�t�ne bi�ey'in min ilmih� illa bime�a'.\nVas��a k�rsiyy�h�'s-semaavati ve'l-arz.\nVe la ye�duh� h�fzuhum� ve huve'l-aliyy�'l-az�m.\n"),
                new Dua (  "3. �hlas Suresi",  "Bismillahirrahmanirrahim\nKul huvallahu ehad\nAllahus-samed\nLem yelid ve lem yuled\nVe lem yekun lehu kufuven ehad\n" ),
                new Dua (  "4. Nas Suresi",  "Bismillahirrahmanirrahim\nKul e'uzu bi rabbin nas\nMelikin nas\n�lahin nas\nMin �erril vesvasil hannas\nEllez� y�vesvis� f� sud�rin nas\nMinal cinneti vennas\n" ),
                new Dua (  "5. Felak Suresi",  "Bismillahirrahmanirrahim\nKul e'uzu bi rabbil felak\nMin �errim� halak\nVe min �errin g�sik�n iz� vakab\nVe min �errin n�ff�s�ti f�l-�uqad\nVe min �errin h�sidin iz� hasad\n" ),
                new Dua (  "6. Sabah Duas�",  "Bismillahirrahmanirrahim\nElhamd�lillahillez� ahy�n� ba'de m� em�t�n� ve ileyhin n���r.\n" ),
                new Dua (  "7. Ak�am Duas�", "Bismillahirrahmanirrahim\nE'�zu billahi min e�-�eytanir racim\nBismillahi'l-lezi l� yadurru ma'ismihi �ey'un fi'l-arzi ve la fi's-sem�i ve huve's-sem�'u'l-�al�m.\n" ),
                new Dua (  "8. Seyahat Duas�", "Allah�mme inni esta�firuka min kulli dhambin.\nVe e'�zu bike min kulli �errin.\n" ),
                new Dua (  "9. R�z�k ��in Dua", "Allah�mme inni es�eleke min fadlike ve rahmetike ve min g�y�bi rahmetike.\n" ),
                new Dua (  "10. S�bh�nall�h� ve bihamdih�",  "S�bh�nall�h� ve bihamdih� adede halkih� ve r�d� nefseh� ve zinete ar�ih� ve midey�t kelim�tih�.\n" ),
                new Dua (  "11. La ilahe illallah",  "La ilahe illallah, vahdeh� l� �er�ke lehu, lehu ve levl�ke rabb�, evvel�n ve �h�r�n.\n" ),
                new Dua (  "12. Ev ��in Dua",  "Bismillah ilah�, min beyt-i mukaddes ve nefs-i �erifi.\n" ),
                new Dua (  "13. �ocuk ��in Dua",  "Rabbi inneee lim� enzelte ileyye min hayrin fak�r.\n" ),
                new Dua (  "14. Vefat Duas�",  "Allah�mme la tuharris�l� senin hidayetin.\n"),
                new Dua (  "15. A�k ve Sevgi ��in Dua", "Allah�mme ushr�h� f�, bihimre hemem �evveli ve h�lani.\n" ),
                new Dua (  "16. Yatmadan �nce Okunacak Dua", "Bismillahirrahmanirrahim\nE'�zu billahi min e�-�eytanir racim\nBismillahi'l-lezi l� yadurru ma'ismihi �ey'un fi'l-arzi ve la fi's-sem�i ve huve's-sem�'u'l-�al�m.\n" )
            };


        //  // Dualar� buton olarak ekleme
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Butonlar daha �nce eklenmi�se, tekrar eklemiyoruz
            if (!butonlarYuklendi)
            {
                LoadDualar();
                butonlarYuklendi = true;  // Butonlar�n y�klendi�ini i�aretle
            }
        }

        private void LoadDualar()
        {
            // stackLayout'un null olup olmad���n� kontrol et
            if (stackLayout != null)
            {
                // �ncelikle stackLayout'taki mevcut �ocuklar� temizleyelim (iste�e ba�l�)
                stackLayout.Children.Clear();

                foreach (var dua in dualar)
                {
                    // Ayn� dua zaten var m� diye kontrol et
                    bool butonVarMi = false;
                    foreach (var child in stackLayout.Children)
                    {
                        if (child is Button button && button.Text == dua.Adi)
                        {
                            butonVarMi = true;
                            break;
                        }
                    }

                    // E�er buton daha �nce eklenmediyse, yeni bir buton ekle
                    if (!butonVarMi)
                    {
                        Button duaButton = new Button
                        {
                            Text = dua.Adi,
                            FontSize = 20,
                            HorizontalOptions = LayoutOptions.Fill,
                            Margin = 20

                        };

                        // Butona t�klama olay� ekleme
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
                DisplayAlert("Hata", "StackLayout bulunamad�.", "Tamam");
            }
        }
    }
}







