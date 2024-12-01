using static surelervedualar.düalar;

namespace surelervedualar;

public partial class NewPage3 : ContentPage
{
    private bool butonlarYuklendi = false;
    public NewPage3()
	{
		InitializeComponent();
	}
    private List<Dua> sureler = new List<Dua>
        {
            new Dua("1. Hadis", "Ýman, üç þeyle tamamlanýr: Allah'a inanmak, O'nun Resûlü'ne iman etmek, ve ahirete inanmak. (Sahih Muslim)"),
            new Dua("2. Hadis", "Kim bir kimseye eziyet ederse, Allah ona eziyet eder. (Sahih al-Bukhari)"),
            new Dua("3. Hadis", "En hayýrlýnýz, ahlâký en güzel olanýnýzdýr. (Sahih Muslim)"),
            new Dua("4. Hadis", "Kim Allah'a ve ahiret gününe iman ediyorsa, komþusuna eziyet etmesin. (Sahih al-Bukhari)"),
            new Dua("5. Hadis", "Ýki þey vardýr ki, onlardan her kim nasiplenirse, o kiþi gerçekten baþarýlý olmuþtur. Bunlar saðlýk ve boþ vakittir. (Sahih al-Bukhari)"),
            new Dua("6. Hadis", "Ýnsanlarýn en hayýrlýsý, insanlara en faydalý olandýr. (Sahih al-Bukhari)"),
            new Dua("7. Hadis", "Allah, güzel olan her þeyi sever. (Sahih Muslim)"),
            new Dua("8. Hadis", "Müslüman, diðer Müslümanlarýn elinden ve dilinden emin olduðu kiþidir. (Sahih al-Bukhari)"),
            new Dua("9. Hadis", "Ýlim öðrenmek her Müslümana farzdýr. (Sunan Ibn Majah)"),
            new Dua("10. Hadis", "Kim Allah'ý zikrederse, Allah da onu anar. (Sahih Muslim)"),
            new Dua("11. Hadis", "Gülmek, sadakadýr. (Sahih al-Bukhari)"),
            new Dua("12. Hadis", "Sabýr, imanýn yarýsýdýr. (Sahih Muslim)"),
            new Dua("13. Hadis", "Allah, kullarýný sevdiði zaman, onlarý imtihan eder. (Sahih al-Bukhari)"),
            new Dua("14. Hadis", "Kim insanlara affederse, Allah da ona affeder. (Sahih Muslim)"),
            new Dua("15. Hadis", "Gizli sadaka, açýk sadakadan daha faziletli olabilir. (Sahih al-Bukhari)"),
            new Dua("16. Hadis", "Kim bir insanýn gönlünü kazanýrsa, Allah da onun gönlünü kazanýr. (Sunan al-Tirmidhi)"),
            new Dua("17. Hadis", "Kim sabýr gösterirse, sabýr onun için en büyük ödüldür. (Sahih al-Bukhari)"),
            new Dua("18. Hadis", "Cennet, annelerin ayaklarý altýndadýr. (Sunan an-Nasa'i)"),
            new Dua("19. Hadis", "Herhangi bir þeyde ölçüyü aþmak israf sayýlýr. (Sahih al-Bukhari)"),
            new Dua("20. Hadis", "Zekat, kalbi temizler. (Sahih Muslim)"),
            new Dua("21. Hadis", "Kim Allah’a ve Resulü’ne iman eder ve salih ameller iþlerse, o kiþi kurtuluþa ermiþtir. (Sahih Muslim)"),
            new Dua("22. Hadis", "Ýki þey vardýr ki, onlarý eksik yapmak kiþiyi helak eder: Gereksiz yere konuþmak ve gözyaþýný boþuna dökmek. (Sahih al-Bukhari)"),
            new Dua("23. Hadis", "Kim bir müslümaný dünyada sevindirse, Allah da ona ahirette sevinç verir. (Sahih Muslim)"),
            new Dua("24. Hadis", "Sabýrlý insanlarýn sabrýný ödüllendirecektir. (Sahih Muslim)"),
            new Dua("25. Hadis", "Sadaka, kalbi temizler ve günahlarý siler. (Sunan Ibn Majah)"),
            new Dua("26. Hadis", "Her kim bir kötülük gördüðünde, onu eliyle düzeltmeye çalýþsýn; eðer buna gücü yetmezse, diliyle düzeltmeye çalýþsýn; buna da gücü yetmezse, kalbiyle buðz etsin. (Sahih Muslim)"),
            new Dua("27. Hadis", "Kim insanlara affederse, Allah ona daha büyük bir affedilme nasip eder. (Sahih Muslim)"),
            new Dua("28. Hadis", "Ýman, kardeþliktir. (Sahih al-Bukhari)"),
            new Dua("29. Hadis", "Müslüman, diðer Müslümanýn kardeþidir. (Sahih Muslim)"),
            new Dua("30. Hadis", "Bütün iþler, niyetlere baðlýdýr. (Sahih al-Bukhari)"),
            new Dua("31. Hadis", "Özür dilemek, insanýn deðerini artýrýr. (Sunan Abu Dawood)"),
            new Dua("32. Hadis", "Her iþte ölçü, dengeyi korumak gerekir. (Sahih Muslim)"),
            new Dua("33. Hadis", "Kim bir kapý açar, ona girmeyi dilerse, Allah ona her türlü nimet verir. (Sahih Muslim)"),
            new Dua("34. Hadis", "Cehennem, sabýrlý insanlarýn sabrýný ödüllendirecektir. (Sahih Muslim)"),
            new Dua("35. Hadis", "Kim Allah’a ve Resulü’ne itaat ederse, doðru yolda olmuþtur. (Sahih Muslim)"),
            new Dua("36. Hadis", "Her bir müslüman, baþkalarýna faydalý olmalýdýr. (Sahih al-Bukhari)"),
            new Dua("37. Hadis", "Ýnsanlara iyi davranmak, Allah’a olan sevgiyi artýrýr. (Sahih Muslim)"),
            new Dua("38. Hadis", "Gerçek zenginlik, mal-mülk deðil, gönül zenginliðidir. (Sahih al-Bukhari)"),
            new Dua("39. Hadis", "Bir insanýn baþýna gelen her þey, onun için bir imtihandýr. (Sahih Muslim)"),
            new Dua("40. Hadis", "Dünya, geçici bir eðlencedir, ahiret ise gerçek yaþamdýr. (Sahih al-Bukhari)")
            };
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

            foreach (var sre in sureler)
            {
                // Ayný dua zaten var mý diye kontrol et
                bool butonVarMi = false;
                foreach (var child in stackLayout.Children)
                {
                    if (child is Button button && button.Text == sre.Icerik)
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
                        Text = sre.Adi,
                        FontSize = 20,
                        HorizontalOptions = LayoutOptions.Fill,
                        Margin = 20,
                        BackgroundColor = Color.FromRgba("#887675")

                    };

                    // Butona týklama olayý ekleme
                    duaButton.Clicked += (sender, e) =>
                    {
                        DisplayAlert(sre.Adi, sre.Icerik, "Tamam");
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