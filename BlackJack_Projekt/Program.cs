Random random = new Random();


string[] jelek = { "Kör", "Káró", "Treff", "Pikk" };
string[] ertekek = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Bubi", "Dáma", "Király", "Ász" };


string jatekosKartya1 = ertekek[random.Next(ertekek.Length)];
string jatekosKartya2 = ertekek[random.Next(ertekek.Length)];
string osztoKartya1 = ertekek[random.Next(ertekek.Length)];
string osztoKartya2 = ertekek[random.Next(ertekek.Length)];

int jatekosOsszeg = KartyaErtek(jatekosKartya1) + KartyaErtek(jatekosKartya2);
int osztoElsoKartya = KartyaErtek(osztoKartya1);
int osztoOsszeg = KartyaErtek(osztoKartya1) + KartyaErtek(osztoKartya2);


Console.WriteLine("Első kártyád: " + jelek[random.Next(jelek.Length)] + " - " + jatekosKartya1 + ", Második kártyád: " + jelek[random.Next(jelek.Length)] + " - " + jatekosKartya2 + ", Összesen ennyi az értékük: " + jatekosOsszeg);
Console.WriteLine("Osztó első kártyája: " + jelek[random.Next(jelek.Length)] + " - " + osztoKartya1 + ", Összesen ennyi az értéke: " + osztoElsoKartya);


int KartyaErtek(string lap)
{
    if (lap == "Ász") return 11;
    if (lap == "Király" || lap == "Bubi" || lap == "Dáma") return 10;
    if (int.TryParse(lap, out int szam)) return szam;
    return 0;
}
