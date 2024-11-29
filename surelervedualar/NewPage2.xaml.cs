using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static surelervedualar.düalar;

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

             new Dua ("1. Fatiha Suresi", "Bismillahirrahmanirrahim\nElhamdülillahi rabbil alemin\nErrahmanirrahim\nMaliki yevmiddin\nÝyyake na'budu ve iyyake nasta'in\nÝhdinas siratal mustakim\nSiratallezine en'amte aleyhim gayril maðdubi aleyhim ve leddalin\n" ),
                new Dua (  "2. Ayet-el Kürsi (Bakara 255)",  "Allahu la ilahe illa huve’l-hayyul-kayyum.\nLa te’huzuhu sinetün ve la nevmun.\nLehu ma fissemavati ve ma filardý.\nMen zallezî yeþfe’u indehû illa biiznih.\nYa'lemu ma beyne eydîhim ve ma halfehüm.\nVe la yühîtûne biþey'in min ilmihî illa bimeþa'.\nVasý’a kürsiyyühü's-semaavati ve'l-arz.\nVe la yeûduhû hýfzuhumâ ve huve'l-aliyyü'l-azîm.\n"),
                new Dua (  "3. Ýhlas Suresi",  "Bismillahirrahmanirrahim\nKul huvallahu ehad\nAllahus-samed\nLem yelid ve lem yuled\nVe lem yekun lehu kufuven ehad\n" ),       
                new Dua (  "16. Yatmadan Önce Okunacak Dua", "Bismillahirrahmanirrahim\nE'ûzu billahi min eþ-þeytanir racim\nBismillahi'l-lezi lâ yadurru ma'ismihi þey'un fi'l-arzi ve la fi's-semâi ve huve's-semî'u'l-‘alîm.\n" )
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
                        Margin = 20

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