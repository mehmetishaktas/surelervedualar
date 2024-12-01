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
        new Dua("1. Dua", "Bismillahirrahmanirrahim - Allah'�n ad�yla, Rahman ve Rahim olan Allah'a hamdolsun, O'na dua ederim. (Fatiha Suresi)"),
        new Dua("2. Dua", "Rabbena atina fi d-dunya haseneten ve fi'l-ahirati haseneten ve k�na azabe'n-nar - Ey Rabbimiz, bize d�nyada iyilik, ahirette de iyilik ver ve bizi ate�in azab�ndan koru. (Bakara 2:201)"),
        new Dua("3. Dua", "La ilahe illallah - Allah'tan ba�ka ilah yoktur. (Hadis)"),
        new Dua("4. Dua", "Subhanallahi ve bihamdihi, subhanallahil azim - Allah�� her t�rl� eksiklikten tenzih ederim, Allah en b�y�kt�r. (Hadis)"),
        new Dua("5. Dua", "Rabbana la tuzikh kulubena ba'de iz hedeytana ve heblena min ladunka rahmatan innaka entel vehhab - Ey Rabbimiz! Bizim kalplerimizi, do�ru yola ilettikten sonra sapt�rma, bize kat�ndan bir rahmet ver. ��phesiz ki Sen, �ok ba���layans�n. (Aal-i �mran 3:8)"),
        new Dua("6. Dua", "Rabbim, bana ve anneme rahmet et, onlar�n bana k���kken verdikleri gibi. (�brahim 14:41)"),
        new Dua("7. Dua", "Allahumme inni es�el�ke el-huda ve�t-tuqa ve�l-afafe ve�l-ghina - Allah��m, senden do�ru yolu, takvay�, iffet ve zenginli�i dilerim. (Sahih Muslim)"),
        new Dua("8. Dua", "Rabbana la tu'akhizna in nasina ev akhta'na - Ey Rabbimiz, e�er unutur ya da hata edersek, bizi sorumlu tutma. (Bakara 2:286)"),
        new Dua("9. Dua", "Rabbena gfirli ve li valideyye ve li'l-mu'minine yevme yekumul hisab - Ey Rabbimiz! Beni, annemi, babam� ve t�m m�minleri hesap g�n� affet. (�brahim 14:41)"),
        new Dua("10. Dua", "Hasbiyallahu la ilahe illa Huwa - Allah bana yeter, O'ndan ba�ka ilah yoktur. (At-Tawbah 9:129)"),
        new Dua("11. Dua", "�lahi, beni do�ru yolda, sevgiyle y�r�t ve her t�rl� s�k�nt�y�, dertleri benden uzakla�t�r. (Hadis)"),
        new Dua("12. Dua", "Bismillahi-allezi la yadurru ma'asmihi �ey'un fil ardi ve la fissama'i ve huve's-Sami'ul Alim - O Allah��n ad�yla ki, O'nun ad� an�ld���nda, yery�z�nde ve g�ky�z�nde hi�bir �ey zarar veremez. O, i�itendir, bilendir. (Hadis)"),
        new Dua("13. Dua", "Rabbim, beni do�ru yola ilet, ve senin r�zan� kazanmama yard�m et. (Fatiha Suresi)"),
        new Dua("14. Dua", "Ya Arhamarrahimin, bizleri affet, bizi do�ru yola ilet ve bizleri rahmetinle ku�at. (Hadis)"),
        new Dua("15. Dua", "Rabbena la tu'akhizna bi ma fa'alu - Ey Rabbimiz, bizim yapt���m�z i�ler y�z�nden bizi sorguya �ekme. (Araf 7:155)"),
        new Dua("16. Dua", "�yyaka na'budu ve iyyaka nasta'in - Sadece Sana ibadet eder ve sadece Senden yard�m dileriz. (Fatiha Suresi)"),
        new Dua("17. Dua", "Rabbim, bana ve aileme sa�l�k, huzur ve bereket ver. (Hadis)"),
        new Dua("18. Dua", "Ya Rabb, bizi zalimlerden ve zalimlerin tuzaklar�ndan koru. (Hadis)"),
        new Dua("19. Dua", "Rabbim, kalbimi iyile�tir, g�z�m� a�, zihinimi berrakla�t�r, ve ruhumu huzura erdir. (Hadis)"),
        new Dua("20. Dua", "Allahumme inni es�el�ke�l-Cennete ve ma yak�nu ileyha min kavlin ev amel - Allah��m, cenneti ve ona yakla�an her s�z ve ameli senden dilerim. (Sahih Muslim)"),
        new Dua("21. Dua", "Rabbana firlana zunubena ve kefir ann� sayyiatina ve tefafna ma'al-abrar - Ey Rabbimiz! G�nahlar�m�z� ba���la, k�t� i�lerimizi affet, ve bizi salihlerle birlikte �l�mden kurtar. (Aal-i �mran 3:193)"),
        new Dua("22. Dua", "Rabbi �rahli sadri ve yassirli emri - Ey Rabbim, g��s�m� geni�let, i�imi kolayla�t�r. (Taha 20:25)"),
        new Dua("23. Dua", "Ve le allakum tashkurun - Ve umar�m ��kredersiniz. (Bakara 2:23)"),
        new Dua("24. Dua", "Rabbim, i�imi kolayla�t�r ve �zerime d��eni eksiksiz yerine getirmemi sa�la. (Hadis)"),
        new Dua("25. Dua", "Subhaneke la ilme lena illa ma allemtene - Senin kudretin ne y�cedir! Bizim ancak bize ��rettiklerin kadar bilgimiz vard�r. (Bakara 2:32)"),
        new Dua("26. Dua", "Rabbana ve la tahmil aleyna isran kama hameltahu alellezine min kablina - Ey Rabbimiz, bizlere �ncekilere y�kledi�in gibi y�k y�kleme. (Bakara 2:286)"),
        new Dua("27. Dua", "Rabbim, bana g�nl�mdeki huzuru ve i�sel bar��� nasip et. (Hadis)"),
        new Dua("28. Dua", "Rabbim, bizleri iyilikle, do�rulukla ve d�r�stl�kle her i�te y�nlendir. (Hadis)"),
        new Dua("29. Dua", "Ya Rabbi, bizi d�nya imtihanlar�nda sab�rl� k�l, ve ahirette en g�zel yeri nasip et. (Hadis)"),
        new Dua("30. Dua", "Allah��m, beni sana y�nelten do�ru yollar� g�ster. (Hadis)"),
        new Dua("31. Dua", "Rabbim, ��phesiz Senin rahmetin sonsuzdur, beni affet ve bana ba���la. (Hadis)"),
        new Dua("32. Dua", "Allah�mme inni es�el�ke ilmen nafi�an ve rizken tayyiban ve amelen mutakabbelen - Allah��m, bana faydal� bilgi, helal r�z�k ve kabul edilen ameller ver. (Hadis)"),
        new Dua("33. Dua", "Ya Rabb, bana ve t�m M�sl�manlara yard�m et, sab�r ve direncimizi art�r. (Hadis)"),
        new Dua("34. Dua", "Rabbi yassir ve la tuassir, Rabbi temmim bi hayr - Ey Rabbim, i�imi kolayla�t�r, zorla�t�rma, ve hay�rla tamamla. (Hadis)"),
        new Dua("35. Dua", "Rabbim, her t�rl� s�k�nt�mda ve zorluklar�mda bana g�� ver. (Hadis)"),
        new Dua("36. Dua", "Rabbi atina mil ladunka rahmaten ve hayyir lana min emrina rafa - Ey Rabbim, kat�ndan bize bir rahmet ver ve i�lerimizi kolayla�t�r. (Al-Kahf 18:10)"),
        new Dua("37. Dua", "Allah�mme la mani�a lim� a'tayt, ve la mu�atiy lim� man�te - Allah��m, verdiklerini kimse engelleyemez, engellediklerini de kimse veremez. (Hadis)"),
        new Dua("38. Dua", "Bismillahi ellezi la yadurru ma�asmihi �ey��n fil ardi ve la fissama�i ve huve�s-Semi�ul Alim - Allah��n ad�yla, O�nun ad� an�ld���nda, ne yery�z�nde ne de g�ky�z�nde hi�bir �ey zarar veremez. (Hadis)"),
        new Dua("39. Dua", "Rabbim, bana do�ruyu g�sterecek ilham ver ve her t�rl� hay�rda bana yard�mc� ol. (Hadis)"),
        new Dua("40. Dua", "Rabbim, beni affet, g�nahlar�m� ba���la, ve bana cennetine en yak�n yeri nasip et. (Hadis)")
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
                            Margin = 20,
                            BackgroundColor =Color.FromRgba("#887675"),

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







