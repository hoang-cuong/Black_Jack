Random random = new Random();


string[] jelek = { "Kör", "Káró", "Treff", "Pikk" };
string[] ertekek = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Bubi", "Dáma", "Király", "Ász" };


string jatekosKartya1 = ertekek[random.Next(ertekek.Length)];
string jatekosKartya2 = ertekek[random.Next(ertekek.Length)];
string osztoKartya1 = ertekek[random.Next(ertekek.Length)];
string osztoKartya2 = ertekek[random.Next(ertekek.Length)];





int KartyaErtek(string lap)
{
    if (lap == "Ász") return 11;
    if (lap == "Király" || lap == "Bubi" || lap == "Dáma") return 10;
    if (int.TryParse(lap, out int szam)) return szam;
    return 0;
}
