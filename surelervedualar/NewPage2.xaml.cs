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
using static surelervedualar.d�alar;
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
new Dua ("Fatiha Suresi","Bismillahirrahmanirrahim\nElhamd�lillahi rabbil alemin\nErrahmanirrahim\nMaliki yevmiddin\n�yyake na'budu ve iyyake nasta'in\n�hdinas siratal mustakim\nSiratallezine en'amte aleyhim gayril ma�dubi aleyhim ve leddalin\n"),
new Dua("Nas Suresi", "Bismillahirrahmanirrahim\nKul e'�zu birabbinn�s\nMeliki'n-n�s\n�lahi'n-n�s\nMin �erril vesv�sil hann�s\nEllez� y�vesv�s� f� sud�rin-n�s\nMinel cinneti venn�s\n"),
new Dua("Felak Suresi", "Bismillahirrahmanirrahim\nKul e'�zu birabbil felak\nMin �errin m� halak\nVe min �errin g�s�k�n iz� vakab\nVe min �errin n�ff�s�ti fil 'uqad\nVe min �errin h�sidin iz� hasad\n"),
new Dua("�hlas Suresi", "Bismillahirrahmanirrahim\nKul huvallahu ehad\nAllahus-samed\nLem yelid ve lem yuled\nVe lem yekun lehu kufuven ehad\n"),
new Dua("Tebbet Suresi", "Bismillahirrahmanirrahim\nTebbet yeda eb� lehebin ve tebb\nMa aghna anhu m�luhu ve m� keseb\nSayasle naran z�ta leheb\nVe imra'atuhu hamm�letel hatab\nF� c�diha habelum min mesad\n"),
new Dua("Nasr Suresi", "Bismillahirrahmanirrahim\n�z� c�e nasrullahi ve'l-feth\nVe raeyten n�se yadhul�ne f� d�ni ll�hi efv�ce\nFesabbih bihamdi rabbike ve istagfirh� innahu k�ne tevv�b�\n"),
new Dua("Kafirun Suresi", "Bismillahirrahmanirrahim\nKul y� eyyuh�l-k�fir�n\nL� a'budu m� ta'bud�n\nVe l� entum �bid�ne m� a'bud\nVe l� ene �bidum m� abadtum\nVe l� entum �bid�ne m� a'bud\nLekum dinukum veliyed�n\n"),
new Dua("Kevser Suresi", "Bismillahirrahmanirrahim\n�nn� atain�ke kevser\nFe-salli lirabbike venhar\n�nn� ��ni'eke huvel ebter\n"),
new Dua("Maun Suresi", "Bismillahirrahmanirrahim\nEraeyte ellez� yukazibu bidd�n\nFezelike ellez� yed'u liyetime\nVe l� yahuddu alel ta'�mi misk�n\nFewayl�n lil musall�n\nEllez�ne hum an sal�tihim sah�n\nEllez�ne yura'�n\nVe yemna'�ne el-ma'�n\n"),
new Dua("Fil Suresi", "Bismillahirrahmanirrahim\nElem tera keyfe fe'ale rabb�ke bi ashabil fil\nElem yaj'al kaydahum f� tadl�l\nVe ersel aleyhim tayran ab�b�l\nTirmihim bihij�rati min s�c�l\nFecalhum keasfim mak�l\n"),
new Dua("Kurey� Suresi", "Bismillahirrahmanirrahim\nLi ila fi kurey�\n�la f�h�m rihleti�-�it�i ve's-sayf\nFelya'budu rabbe h�zel beyt\nEllez� at'amahum min c�'�n ve �menahum min havf\n"),
new Dua("Asr Suresi", "Bismillahirrahmanirrahim\nVe'l-asr\n�nnel ins�ne lef� husr\n�ll� ellez�ne �men� ve amilus salih�t\nVe tevasav bilhakki ve tevasav bis-sabr\n"),
new Dua("Asr Suresi", "Bismillahirrahmanirrahim\nVe'l-asr\n�nnel ins�ne lef� husr\n�ll� ellez�ne �men� ve amilus salih�t\nVe tevasav bilhakki ve tevasav bis-sabr\n")
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
                        BackgroundColor = Color.FromRgba("#887675"),

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