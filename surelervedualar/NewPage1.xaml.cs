using System.Security.Cryptography;

namespace surelervedualar;

public partial class NewPage1 : ContentPage
{

    public List<Dua> Dualar { get; set; }
    public NewPage1()
	{
        InitializeComponent();
        /*
        d.DuaService dua = new d.DuaService();
		var dualarr = dua.GetDualar();
		string alldualar = string.Join("\n\n", dualarr);
        DuaLabel.Text = alldualar;
        */
        // Dua verilerini olu�turuyoruz
        Dualar = new List<Dua>
            {
                new Dua { Id = "1. Fatiha Suresi", DuaMetni = "Bismillahirrahmanirrahim\nElhamd�lillahi rabbil alemin\nErrahmanirrahim\nMaliki yevmiddin\n�yyake na'budu ve iyyake nasta'in\n�hdinas siratal mustakim\nSiratallezine en'amte aleyhim gayril ma�dubi aleyhim ve leddalin\n" },
                new Dua { Id = "2. Ayet-el K�rsi (Bakara 255)", DuaMetni = "Allahu la ilahe illa huve�l-hayyul-kayyum.\nLa te�huzuhu sinet�n ve la nevmun.\nLehu ma fissemavati ve ma filard�.\nMen zallez� ye�fe�u indeh� illa biiznih.\nYa'lemu ma beyne eyd�him ve ma halfeh�m.\nVe la y�h�t�ne bi�ey'in min ilmih� illa bime�a'.\nVas��a k�rsiyy�h�'s-semaavati ve'l-arz.\nVe la ye�duh� h�fzuhum� ve huve'l-aliyy�'l-az�m.\n" },
                new Dua { Id = "3. �hlas Suresi", DuaMetni = "Bismillahirrahmanirrahim\nKul huvallahu ehad\nAllahus-samed\nLem yelid ve lem yuled\nVe lem yekun lehu kufuven ehad\n" },
                new Dua { Id = "4. Nas Suresi", DuaMetni = "Bismillahirrahmanirrahim\nKul e'uzu bi rabbin nas\nMelikin nas\n�lahin nas\nMin �erril vesvasil hannas\nEllez� y�vesvis� f� sud�rin nas\nMinal cinneti vennas\n" },
                new Dua { Id = "5. Felak Suresi", DuaMetni = "Bismillahirrahmanirrahim\nKul e'uzu bi rabbil felak\nMin �errim� halak\nVe min �errin g�sik�n iz� vakab\nVe min �errin n�ff�s�ti f�l-�uqad\nVe min �errin h�sidin iz� hasad\n" },
                new Dua { Id = "6. Sabah Duas�", DuaMetni = "Bismillahirrahmanirrahim\nElhamd�lillahillez� ahy�n� ba'de m� em�t�n� ve ileyhin n���r.\n" },
                new Dua { Id = "7. Ak�am Duas�", DuaMetni = "Bismillahirrahmanirrahim\nE'�zu billahi min e�-�eytanir racim\nBismillahi'l-lezi l� yadurru ma'ismihi �ey'un fi'l-arzi ve la fi's-sem�i ve huve's-sem�'u'l-�al�m.\n" },
                new Dua { Id = "8. Seyahat Duas�", DuaMetni = "Allah�mme inni esta�firuka min kulli dhambin.\nVe e'�zu bike min kulli �errin.\n" },
                new Dua { Id = "9. R�z�k ��in Dua", DuaMetni = "Allah�mme inni es�eleke min fadlike ve rahmetike ve min g�y�bi rahmetike.\n" },
                new Dua { Id = "10. S�bh�nall�h� ve bihamdih�", DuaMetni = "S�bh�nall�h� ve bihamdih� adede halkih� ve r�d� nefseh� ve zinete ar�ih� ve midey�t kelim�tih�.\n" },
                new Dua { Id = "11. La ilahe illallah", DuaMetni = "La ilahe illallah, vahdeh� l� �er�ke lehu, lehu ve levl�ke rabb�, evvel�n ve �h�r�n.\n" },
                new Dua { Id = "12. Ev ��in Dua", DuaMetni = "Bismillah ilah�, min beyt-i mukaddes ve nefs-i �erifi.\n" },
                new Dua { Id = "13. �ocuk ��in Dua", DuaMetni = "Rabbi inneee lim� enzelte ileyye min hayrin fak�r.\n" },
                new Dua { Id = "14. Vefat Duas�", DuaMetni = "Allah�mme la tuharris�l� senin hidayetin.\n" },
                new Dua { Id = "15. A�k ve Sevgi ��in Dua", DuaMetni = "Allah�mme ushr�h� f�, bihimre hemem �evveli ve h�lani.\n" },
                new Dua { Id = "16. Yatmadan �nce Okunacak Dua", DuaMetni = "Bismillahirrahmanirrahim\nE'�zu billahi min e�-�eytanir racim\nBismillahi'l-lezi l� yadurru ma'ismihi �ey'un fi'l-arzi ve la fi's-sem�i ve huve's-sem�'u'l-�al�m.\n" }
            };

        // BindingContext ayarland�
        BindingContext = this;


    }
}