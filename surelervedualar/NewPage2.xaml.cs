using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Threading.Tasks;
using static surelervedualar.düalar;
using static System.Net.WebRequestMethods;

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
new Dua ("Fatiha Suresi","Bismillahirrahmanirrahim\nElhamdülillahi rabbil alemin\nErrahmanirrahim\nMaliki yevmiddin\nÝyyake na'budu ve iyyake nasta'in\nÝhdinas siratal mustakim\nSiratallezine en'amte aleyhim gayril maðdubi aleyhim ve leddalin\n"),
new Dua("Nas Suresi", "Bismillahirrahmanirrahim\nKul e'ûzu birabbinnâs\nMeliki'n-nâs\nÝlahi'n-nâs\nMin þerril vesvâsil hannâs\nEllezî yüvesvîsü fî sudûrin-nâs\nMinel cinneti vennâs\n"),
new Dua("Felak Suresi", "Bismillahirrahmanirrahim\nKul e'ûzu birabbil felak\nMin þerrin mâ halak\nVe min þerrin gâsýkýn izâ vakab\nVe min þerrin nâffâsâti fil 'uqad\nVe min þerrin hâsidin izâ hasad\n"),
new Dua("Ýhlas Suresi", "Bismillahirrahmanirrahim\nKul huvallahu ehad\nAllahus-samed\nLem yelid ve lem yuled\nVe lem yekun lehu kufuven ehad\n"),
new Dua("Tebbet Suresi", "Bismillahirrahmanirrahim\nTebbet yeda ebî lehebin ve tebb\nMa aghna anhu mâluhu ve mâ keseb\nSayasle naran zâta leheb\nVe imra'atuhu hammâletel hatab\nFî cîdiha habelum min mesad\n"),
new Dua("Nasr Suresi", "Bismillahirrahmanirrahim\nÝzâ câe nasrullahi ve'l-feth\nVe raeyten nâse yadhulûne fî dîni llâhi efvâce\nFesabbih bihamdi rabbike ve istagfirhû innahu kâne tevvâbâ\n"),
new Dua("Kafirun Suresi", "Bismillahirrahmanirrahim\nKul yâ eyyuhâl-kâfirûn\nLâ a'budu mâ ta'budûn\nVe lâ entum âbidûne mâ a'bud\nVe lâ ene âbidum mâ abadtum\nVe lâ entum âbidûne mâ a'bud\nLekum dinukum veliyedîn\n"),
new Dua("Kevser Suresi", "Bismillahirrahmanirrahim\nÝnnâ atainâke kevser\nFe-salli lirabbike venhar\nÝnnâ þâni'eke huvel ebter\n"),
new Dua("Maun Suresi", "Bismillahirrahmanirrahim\nEraeyte ellezî yukazibu biddîn\nFezelike ellezî yed'u liyetime\nVe lâ yahuddu alel ta'âmi miskîn\nFewaylün lil musallîn\nEllezîne hum an salâtihim sahûn\nEllezîne yura'ûn\nVe yemna'ûne el-ma'ûn\n"),
new Dua("Fil Suresi", "Bismillahirrahmanirrahim\nElem tera keyfe fe'ale rabbüke bi ashabil fil\nElem yaj'al kaydahum fî tadlîl\nVe ersel aleyhim tayran abâbîl\nTirmihim bihijârati min sîcîl\nFecalhum keasfim makûl\n"),
new Dua("Kureyþ Suresi", "Bismillahirrahmanirrahim\nLi ila fi kureyþ\nÝla fîhîm rihletiþ-þitâi ve's-sayf\nFelya'budu rabbe hâzel beyt\nEllezî at'amahum min cû'în ve âmenahum min havf\n"),
new Dua("Asr Suresi", "Bismillahirrahmanirrahim\nVe'l-asr\nÝnnel insâne lefî husr\nÝllâ ellezîne âmenû ve amilus salihât\nVe tevasav bilhakki ve tevasav bis-sabr\n"),
new Dua("Asr Suresi", "Bismillahirrahmanirrahim\nVe'l-asr\nÝnnel insâne lefî husr\nÝllâ ellezîne âmenû ve amilus salihât\nVe tevasav bilhakki ve tevasav bis-sabr\n")
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
                        BackgroundColor = Color.FromRgba("#887675"),

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