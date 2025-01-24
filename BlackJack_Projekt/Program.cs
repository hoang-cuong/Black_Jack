Random random = new Random();


string[] jelek = { "Kör", "Káró", "Treff", "Pikk" };
string[] ertekek = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Bubi", "Dáma", "Király", "Ász" };

Console.WriteLine();
Console.WriteLine("                                        " + "Üdvözlünk a Blackjack kártya játékban!");
Console.WriteLine();
Console.WriteLine("Próbáld meg legyőzni az osztót úgy, hogy minél közelebb kerülj a 21-hez, de ne lépd túl.");
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("Nyomj meg egy gombot a játék indításához... \n");
Console.ReadKey();

string jatekosKartya1 = ertekek[random.Next(ertekek.Length)];
string jatekosKartya2 = ertekek[random.Next(ertekek.Length)];
string osztoKartya1 = ertekek[random.Next(ertekek.Length)];
string osztoKartya2 = ertekek[random.Next(ertekek.Length)];

int jatekosOsszeg = KartyaErtek(jatekosKartya1) + KartyaErtek(jatekosKartya2);
int osztoElsoKartya = KartyaErtek(osztoKartya1);
int osztoOsszeg = KartyaErtek(osztoKartya1) + KartyaErtek(osztoKartya2);


Console.WriteLine("Első kártyád: " + jelek[random.Next(jelek.Length)] + " - " + jatekosKartya1 + ", Második kártyád: " + jelek[random.Next(jelek.Length)] + " - " + jatekosKartya2 + ", Összesen ennyi az értékük: " + jatekosOsszeg);
Console.WriteLine("Osztó első kártyája: " + jelek[random.Next(jelek.Length)] + " - " + osztoKartya1 + ", Összesen ennyi az értéke: " + osztoElsoKartya);


bool BlackJacke = false;

if (jatekosOsszeg == 21)
{
    if (osztoOsszeg == 21)
    {
        Console.WriteLine("Döntetlen");
    }
    else
    {
        Console.WriteLine("Black Jack! Ön nyert");
        BlackJacke = true;
    }
}
if (osztoOsszeg == 21)
{
    Console.WriteLine("Osztónak Black Jack! Ön veszített");
    BlackJacke = true;
}
if (!BlackJacke)
{
    Console.Write("(H)it or (S)tand? ");
    string hitOrStand = Console.ReadLine()!.ToUpper();
}


int KartyaErtek(string lap)
{
    if (lap == "Ász") return 11;
    if (lap == "Király" || lap == "Bubi" || lap == "Dáma") return 10;
    if (int.TryParse(lap, out int szam)) return szam;
    return 0;
}
