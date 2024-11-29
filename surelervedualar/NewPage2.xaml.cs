using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static surelervedualar.d�alar;

namespace surelervedualar;

public partial class NewPage2 : ContentPage
{
    private bool butonlarYuklendi = false;
    public NewPage2()
    {
        InitializeComponent();
    }

    private List<Dua> sureler = new List<Dua>
        {

             new Dua ("1. Fatiha Suresi", "Bismillahirrahmanirrahim\nElhamd�lillahi rabbil alemin\nErrahmanirrahim\nMaliki yevmiddin\n�yyake na'budu ve iyyake nasta'in\n�hdinas siratal mustakim\nSiratallezine en'amte aleyhim gayril ma�dubi aleyhim ve leddalin\n" ),
                new Dua (  "2. Ayet-el K�rsi (Bakara 255)",  "Allahu la ilahe illa huve�l-hayyul-kayyum.\nLa te�huzuhu sinet�n ve la nevmun.\nLehu ma fissemavati ve ma filard�.\nMen zallez� ye�fe�u indeh� illa biiznih.\nYa'lemu ma beyne eyd�him ve ma halfeh�m.\nVe la y�h�t�ne bi�ey'in min ilmih� illa bime�a'.\nVas��a k�rsiyy�h�'s-semaavati ve'l-arz.\nVe la ye�duh� h�fzuhum� ve huve'l-aliyy�'l-az�m.\n"),
                new Dua (  "3. �hlas Suresi",  "Bismillahirrahmanirrahim\nKul huvallahu ehad\nAllahus-samed\nLem yelid ve lem yuled\nVe lem yekun lehu kufuven ehad\n" ),       
                new Dua (  "16. Yatmadan �nce Okunacak Dua", "Bismillahirrahmanirrahim\nE'�zu billahi min e�-�eytanir racim\nBismillahi'l-lezi l� yadurru ma'ismihi �ey'un fi'l-arzi ve la fi's-sem�i ve huve's-sem�'u'l-�al�m.\n" )
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
                        Margin = 20

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