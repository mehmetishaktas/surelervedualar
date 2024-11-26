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
        // Dua verilerini oluþturuyoruz
        Dualar = new List<Dua>
            {
                new Dua { Id = "1. Fatiha Suresi", DuaMetni = "Bismillahirrahmanirrahim\nElhamdülillahi rabbil alemin\nErrahmanirrahim\nMaliki yevmiddin\nÝyyake na'budu ve iyyake nasta'in\nÝhdinas siratal mustakim\nSiratallezine en'amte aleyhim gayril maðdubi aleyhim ve leddalin\n" },
                new Dua { Id = "2. Ayet-el Kürsi (Bakara 255)", DuaMetni = "Allahu la ilahe illa huve’l-hayyul-kayyum.\nLa te’huzuhu sinetün ve la nevmun.\nLehu ma fissemavati ve ma filardý.\nMen zallezî yeþfe’u indehû illa biiznih.\nYa'lemu ma beyne eydîhim ve ma halfehüm.\nVe la yühîtûne biþey'in min ilmihî illa bimeþa'.\nVasý’a kürsiyyühü's-semaavati ve'l-arz.\nVe la yeûduhû hýfzuhumâ ve huve'l-aliyyü'l-azîm.\n" },
                new Dua { Id = "3. Ýhlas Suresi", DuaMetni = "Bismillahirrahmanirrahim\nKul huvallahu ehad\nAllahus-samed\nLem yelid ve lem yuled\nVe lem yekun lehu kufuven ehad\n" },
                new Dua { Id = "4. Nas Suresi", DuaMetni = "Bismillahirrahmanirrahim\nKul e'uzu bi rabbin nas\nMelikin nas\nÝlahin nas\nMin þerril vesvasil hannas\nEllezî yüvesvisü fî sudûrin nas\nMinal cinneti vennas\n" },
                new Dua { Id = "5. Felak Suresi", DuaMetni = "Bismillahirrahmanirrahim\nKul e'uzu bi rabbil felak\nMin þerrimâ halak\nVe min þerrin gâsikýn izâ vakab\nVe min þerrin nâffâsâti fîl-‘uqad\nVe min þerrin hâsidin izâ hasad\n" },
                new Dua { Id = "6. Sabah Duasý", DuaMetni = "Bismillahirrahmanirrahim\nElhamdülillahillezî ahyânâ ba'de mâ emâtânâ ve ileyhin nûþûr.\n" },
                new Dua { Id = "7. Akþam Duasý", DuaMetni = "Bismillahirrahmanirrahim\nE'ûzu billahi min eþ-þeytanir racim\nBismillahi'l-lezi lâ yadurru ma'ismihi þey'un fi'l-arzi ve la fi's-semâi ve huve's-semî'u'l-‘alîm.\n" },
                new Dua { Id = "8. Seyahat Duasý", DuaMetni = "Allahümme inni estaðfiruka min kulli dhambin.\nVe e'ûzu bike min kulli þerrin.\n" },
                new Dua { Id = "9. Rýzýk Ýçin Dua", DuaMetni = "Allahümme inni es’eleke min fadlike ve rahmetike ve min güyûbi rahmetike.\n" },
                new Dua { Id = "10. Sübhânallâhî ve bihamdihî", DuaMetni = "Sübhânallâhî ve bihamdihî adede halkihî ve rýdâ nefsehî ve zinete arþihî ve mideyât kelimâtihî.\n" },
                new Dua { Id = "11. La ilahe illallah", DuaMetni = "La ilahe illallah, vahdehû lâ þerîke lehu, lehu ve levlâke rabbâ, evvelûn ve âhýrûn.\n" },
                new Dua { Id = "12. Ev Ýçin Dua", DuaMetni = "Bismillah ilahî, min beyt-i mukaddes ve nefs-i þerifi.\n" },
                new Dua { Id = "13. Çocuk Ýçin Dua", DuaMetni = "Rabbi inneee limâ enzelte ileyye min hayrin fakîr.\n" },
                new Dua { Id = "14. Vefat Duasý", DuaMetni = "Allahümme la tuharrisûlâ senin hidayetin.\n" },
                new Dua { Id = "15. Aþk ve Sevgi Ýçin Dua", DuaMetni = "Allahümme ushrýhî fî, bihimre hemem þevveli ve hâlani.\n" },
                new Dua { Id = "16. Yatmadan Önce Okunacak Dua", DuaMetni = "Bismillahirrahmanirrahim\nE'ûzu billahi min eþ-þeytanir racim\nBismillahi'l-lezi lâ yadurru ma'ismihi þey'un fi'l-arzi ve la fi's-semâi ve huve's-semî'u'l-‘alîm.\n" }
            };

        // BindingContext ayarlandý
        BindingContext = this;


    }
}