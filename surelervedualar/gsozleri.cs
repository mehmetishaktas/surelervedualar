using System;
using System.Collections.Generic;

public class GunlukDiniSozler
{
    private List<string> diniSozler;

    public GunlukDiniSozler()
    {
        diniSozler = new List<string>
        {
            "Allah, sabredenlerle beraberdir.",
            "Gerçekten, Allah’ın rahmeti çok geniştir.",
            "İman edenler ve salih ameller işleyenler için cennet vaat edilmiştir.",
            "Kim Allah’a ve ahiret gününe iman ederse, güzel söz söylesin ya da sussun.",
            "Her şeyin hayırlısı, Allah’ın rızasını kazanmaktır.",
            "Sadaka, kalbi temizler ve Allah’ın sevgisini kazandırır.",
            "Rabbiniz, rahmeti geniş olandır. Onun affı her şeyi kuşatmıştır."
        };
    }

    public string BugunDiniSoz()
    {
        Random rand = new Random();
        int index = rand.Next(diniSozler.Count);
        return diniSozler[index];
    }
}
