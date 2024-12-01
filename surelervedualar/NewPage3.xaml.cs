using static surelervedualar.d�alar;

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
            new Dua("1. Hadis", "�man, �� �eyle tamamlan�r: Allah'a inanmak, O'nun Res�l�'ne iman etmek, ve ahirete inanmak. (Sahih Muslim)"),
            new Dua("2. Hadis", "Kim bir kimseye eziyet ederse, Allah ona eziyet eder. (Sahih al-Bukhari)"),
            new Dua("3. Hadis", "En hay�rl�n�z, ahl�k� en g�zel olan�n�zd�r. (Sahih Muslim)"),
            new Dua("4. Hadis", "Kim Allah'a ve ahiret g�n�ne iman ediyorsa, kom�usuna eziyet etmesin. (Sahih al-Bukhari)"),
            new Dua("5. Hadis", "�ki �ey vard�r ki, onlardan her kim nasiplenirse, o ki�i ger�ekten ba�ar�l� olmu�tur. Bunlar sa�l�k ve bo� vakittir. (Sahih al-Bukhari)"),
            new Dua("6. Hadis", "�nsanlar�n en hay�rl�s�, insanlara en faydal� oland�r. (Sahih al-Bukhari)"),
            new Dua("7. Hadis", "Allah, g�zel olan her �eyi sever. (Sahih Muslim)"),
            new Dua("8. Hadis", "M�sl�man, di�er M�sl�manlar�n elinden ve dilinden emin oldu�u ki�idir. (Sahih al-Bukhari)"),
            new Dua("9. Hadis", "�lim ��renmek her M�sl�mana farzd�r. (Sunan Ibn Majah)"),
            new Dua("10. Hadis", "Kim Allah'� zikrederse, Allah da onu anar. (Sahih Muslim)"),
            new Dua("11. Hadis", "G�lmek, sadakad�r. (Sahih al-Bukhari)"),
            new Dua("12. Hadis", "Sab�r, iman�n yar�s�d�r. (Sahih Muslim)"),
            new Dua("13. Hadis", "Allah, kullar�n� sevdi�i zaman, onlar� imtihan eder. (Sahih al-Bukhari)"),
            new Dua("14. Hadis", "Kim insanlara affederse, Allah da ona affeder. (Sahih Muslim)"),
            new Dua("15. Hadis", "Gizli sadaka, a��k sadakadan daha faziletli olabilir. (Sahih al-Bukhari)"),
            new Dua("16. Hadis", "Kim bir insan�n g�nl�n� kazan�rsa, Allah da onun g�nl�n� kazan�r. (Sunan al-Tirmidhi)"),
            new Dua("17. Hadis", "Kim sab�r g�sterirse, sab�r onun i�in en b�y�k �d�ld�r. (Sahih al-Bukhari)"),
            new Dua("18. Hadis", "Cennet, annelerin ayaklar� alt�ndad�r. (Sunan an-Nasa'i)"),
            new Dua("19. Hadis", "Herhangi bir �eyde �l��y� a�mak israf say�l�r. (Sahih al-Bukhari)"),
            new Dua("20. Hadis", "Zekat, kalbi temizler. (Sahih Muslim)"),
            new Dua("21. Hadis", "Kim Allah�a ve Resul��ne iman eder ve salih ameller i�lerse, o ki�i kurtulu�a ermi�tir. (Sahih Muslim)"),
            new Dua("22. Hadis", "�ki �ey vard�r ki, onlar� eksik yapmak ki�iyi helak eder: Gereksiz yere konu�mak ve g�zya��n� bo�una d�kmek. (Sahih al-Bukhari)"),
            new Dua("23. Hadis", "Kim bir m�sl�man� d�nyada sevindirse, Allah da ona ahirette sevin� verir. (Sahih Muslim)"),
            new Dua("24. Hadis", "Sab�rl� insanlar�n sabr�n� �d�llendirecektir. (Sahih Muslim)"),
            new Dua("25. Hadis", "Sadaka, kalbi temizler ve g�nahlar� siler. (Sunan Ibn Majah)"),
            new Dua("26. Hadis", "Her kim bir k�t�l�k g�rd���nde, onu eliyle d�zeltmeye �al��s�n; e�er buna g�c� yetmezse, diliyle d�zeltmeye �al��s�n; buna da g�c� yetmezse, kalbiyle bu�z etsin. (Sahih Muslim)"),
            new Dua("27. Hadis", "Kim insanlara affederse, Allah ona daha b�y�k bir affedilme nasip eder. (Sahih Muslim)"),
            new Dua("28. Hadis", "�man, karde�liktir. (Sahih al-Bukhari)"),
            new Dua("29. Hadis", "M�sl�man, di�er M�sl�man�n karde�idir. (Sahih Muslim)"),
            new Dua("30. Hadis", "B�t�n i�ler, niyetlere ba�l�d�r. (Sahih al-Bukhari)"),
            new Dua("31. Hadis", "�z�r dilemek, insan�n de�erini art�r�r. (Sunan Abu Dawood)"),
            new Dua("32. Hadis", "Her i�te �l��, dengeyi korumak gerekir. (Sahih Muslim)"),
            new Dua("33. Hadis", "Kim bir kap� a�ar, ona girmeyi dilerse, Allah ona her t�rl� nimet verir. (Sahih Muslim)"),
            new Dua("34. Hadis", "Cehennem, sab�rl� insanlar�n sabr�n� �d�llendirecektir. (Sahih Muslim)"),
            new Dua("35. Hadis", "Kim Allah�a ve Resul��ne itaat ederse, do�ru yolda olmu�tur. (Sahih Muslim)"),
            new Dua("36. Hadis", "Her bir m�sl�man, ba�kalar�na faydal� olmal�d�r. (Sahih al-Bukhari)"),
            new Dua("37. Hadis", "�nsanlara iyi davranmak, Allah�a olan sevgiyi art�r�r. (Sahih Muslim)"),
            new Dua("38. Hadis", "Ger�ek zenginlik, mal-m�lk de�il, g�n�l zenginli�idir. (Sahih al-Bukhari)"),
            new Dua("39. Hadis", "Bir insan�n ba��na gelen her �ey, onun i�in bir imtihand�r. (Sahih Muslim)"),
            new Dua("40. Hadis", "D�nya, ge�ici bir e�lencedir, ahiret ise ger�ek ya�amd�r. (Sahih al-Bukhari)")
            };
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

            foreach (var sre in sureler)
            {
                // Ayn� dua zaten var m� diye kontrol et
                bool butonVarMi = false;
                foreach (var child in stackLayout.Children)
                {
                    if (child is Button button && button.Text == sre.Icerik)
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
                        Text = sre.Adi,
                        FontSize = 20,
                        HorizontalOptions = LayoutOptions.Fill,
                        Margin = 20,
                        BackgroundColor = Color.FromRgba("#887675")

                    };

                    // Butona t�klama olay� ekleme
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
            DisplayAlert("Hata", "StackLayout bulunamad�.", "Tamam");
        }
    }
}