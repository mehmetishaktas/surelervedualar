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
        new Dua("1. Dua", "Bismillahirrahmanirrahim - Allah'ýn adýyla, Rahman ve Rahim olan Allah'a hamdolsun, O'na dua ederim. (Fatiha Suresi)"),
        new Dua("2. Dua", "Rabbena atina fi d-dunya haseneten ve fi'l-ahirati haseneten ve kýna azabe'n-nar - Ey Rabbimiz, bize dünyada iyilik, ahirette de iyilik ver ve bizi ateþin azabýndan koru. (Bakara 2:201)"),
        new Dua("3. Dua", "La ilahe illallah - Allah'tan baþka ilah yoktur. (Hadis)"),
        new Dua("4. Dua", "Subhanallahi ve bihamdihi, subhanallahil azim - Allah’ý her türlü eksiklikten tenzih ederim, Allah en büyüktür. (Hadis)"),
        new Dua("5. Dua", "Rabbana la tuzikh kulubena ba'de iz hedeytana ve heblena min ladunka rahmatan innaka entel vehhab - Ey Rabbimiz! Bizim kalplerimizi, doðru yola ilettikten sonra saptýrma, bize katýndan bir rahmet ver. Þüphesiz ki Sen, çok baðýþlayansýn. (Aal-i Ýmran 3:8)"),
        new Dua("6. Dua", "Rabbim, bana ve anneme rahmet et, onlarýn bana küçükken verdikleri gibi. (Ýbrahim 14:41)"),
        new Dua("7. Dua", "Allahumme inni es’elüke el-huda ve’t-tuqa ve’l-afafe ve’l-ghina - Allah’ým, senden doðru yolu, takvayý, iffet ve zenginliði dilerim. (Sahih Muslim)"),
        new Dua("8. Dua", "Rabbana la tu'akhizna in nasina ev akhta'na - Ey Rabbimiz, eðer unutur ya da hata edersek, bizi sorumlu tutma. (Bakara 2:286)"),
        new Dua("9. Dua", "Rabbena gfirli ve li valideyye ve li'l-mu'minine yevme yekumul hisab - Ey Rabbimiz! Beni, annemi, babamý ve tüm müminleri hesap günü affet. (Ýbrahim 14:41)"),
        new Dua("10. Dua", "Hasbiyallahu la ilahe illa Huwa - Allah bana yeter, O'ndan baþka ilah yoktur. (At-Tawbah 9:129)"),
        new Dua("11. Dua", "Ýlahi, beni doðru yolda, sevgiyle yürüt ve her türlü sýkýntýyý, dertleri benden uzaklaþtýr. (Hadis)"),
        new Dua("12. Dua", "Bismillahi-allezi la yadurru ma'asmihi þey'un fil ardi ve la fissama'i ve huve's-Sami'ul Alim - O Allah’ýn adýyla ki, O'nun adý anýldýðýnda, yeryüzünde ve gökyüzünde hiçbir þey zarar veremez. O, iþitendir, bilendir. (Hadis)"),
        new Dua("13. Dua", "Rabbim, beni doðru yola ilet, ve senin rýzaný kazanmama yardým et. (Fatiha Suresi)"),
        new Dua("14. Dua", "Ya Arhamarrahimin, bizleri affet, bizi doðru yola ilet ve bizleri rahmetinle kuþat. (Hadis)"),
        new Dua("15. Dua", "Rabbena la tu'akhizna bi ma fa'alu - Ey Rabbimiz, bizim yaptýðýmýz iþler yüzünden bizi sorguya çekme. (Araf 7:155)"),
        new Dua("16. Dua", "Ýyyaka na'budu ve iyyaka nasta'in - Sadece Sana ibadet eder ve sadece Senden yardým dileriz. (Fatiha Suresi)"),
        new Dua("17. Dua", "Rabbim, bana ve aileme saðlýk, huzur ve bereket ver. (Hadis)"),
        new Dua("18. Dua", "Ya Rabb, bizi zalimlerden ve zalimlerin tuzaklarýndan koru. (Hadis)"),
        new Dua("19. Dua", "Rabbim, kalbimi iyileþtir, gözümü aç, zihinimi berraklaþtýr, ve ruhumu huzura erdir. (Hadis)"),
        new Dua("20. Dua", "Allahumme inni es’elüke’l-Cennete ve ma yakýnu ileyha min kavlin ev amel - Allah’ým, cenneti ve ona yaklaþan her söz ve ameli senden dilerim. (Sahih Muslim)"),
        new Dua("21. Dua", "Rabbana firlana zunubena ve kefir annâ sayyiatina ve tefafna ma'al-abrar - Ey Rabbimiz! Günahlarýmýzý baðýþla, kötü iþlerimizi affet, ve bizi salihlerle birlikte ölümden kurtar. (Aal-i Ýmran 3:193)"),
        new Dua("22. Dua", "Rabbi þrahli sadri ve yassirli emri - Ey Rabbim, göðsümü geniþlet, iþimi kolaylaþtýr. (Taha 20:25)"),
        new Dua("23. Dua", "Ve le allakum tashkurun - Ve umarým þükredersiniz. (Bakara 2:23)"),
        new Dua("24. Dua", "Rabbim, iþimi kolaylaþtýr ve üzerime düþeni eksiksiz yerine getirmemi saðla. (Hadis)"),
        new Dua("25. Dua", "Subhaneke la ilme lena illa ma allemtene - Senin kudretin ne yücedir! Bizim ancak bize öðrettiklerin kadar bilgimiz vardýr. (Bakara 2:32)"),
        new Dua("26. Dua", "Rabbana ve la tahmil aleyna isran kama hameltahu alellezine min kablina - Ey Rabbimiz, bizlere öncekilere yüklediðin gibi yük yükleme. (Bakara 2:286)"),
        new Dua("27. Dua", "Rabbim, bana gönlümdeki huzuru ve içsel barýþý nasip et. (Hadis)"),
        new Dua("28. Dua", "Rabbim, bizleri iyilikle, doðrulukla ve dürüstlükle her iþte yönlendir. (Hadis)"),
        new Dua("29. Dua", "Ya Rabbi, bizi dünya imtihanlarýnda sabýrlý kýl, ve ahirette en güzel yeri nasip et. (Hadis)"),
        new Dua("30. Dua", "Allah’ým, beni sana yönelten doðru yollarý göster. (Hadis)"),
        new Dua("31. Dua", "Rabbim, þüphesiz Senin rahmetin sonsuzdur, beni affet ve bana baðýþla. (Hadis)"),
        new Dua("32. Dua", "Allahümme inni es’elüke ilmen nafi’an ve rizken tayyiban ve amelen mutakabbelen - Allah’ým, bana faydalý bilgi, helal rýzýk ve kabul edilen ameller ver. (Hadis)"),
        new Dua("33. Dua", "Ya Rabb, bana ve tüm Müslümanlara yardým et, sabýr ve direncimizi artýr. (Hadis)"),
        new Dua("34. Dua", "Rabbi yassir ve la tuassir, Rabbi temmim bi hayr - Ey Rabbim, iþimi kolaylaþtýr, zorlaþtýrma, ve hayýrla tamamla. (Hadis)"),
        new Dua("35. Dua", "Rabbim, her türlü sýkýntýmda ve zorluklarýmda bana güç ver. (Hadis)"),
        new Dua("36. Dua", "Rabbi atina mil ladunka rahmaten ve hayyir lana min emrina rafa - Ey Rabbim, katýndan bize bir rahmet ver ve iþlerimizi kolaylaþtýr. (Al-Kahf 18:10)"),
        new Dua("37. Dua", "Allahümme la mani’a limâ a'tayt, ve la mu’atiy limâ man’te - Allah’ým, verdiklerini kimse engelleyemez, engellediklerini de kimse veremez. (Hadis)"),
        new Dua("38. Dua", "Bismillahi ellezi la yadurru ma’asmihi þey’ün fil ardi ve la fissama’i ve huve’s-Semi’ul Alim - Allah’ýn adýyla, O’nun adý anýldýðýnda, ne yeryüzünde ne de gökyüzünde hiçbir þey zarar veremez. (Hadis)"),
        new Dua("39. Dua", "Rabbim, bana doðruyu gösterecek ilham ver ve her türlü hayýrda bana yardýmcý ol. (Hadis)"),
        new Dua("40. Dua", "Rabbim, beni affet, günahlarýmý baðýþla, ve bana cennetine en yakýn yeri nasip et. (Hadis)")
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
                            Margin = 20,
                            BackgroundColor =Color.FromRgba("#887675"),

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







