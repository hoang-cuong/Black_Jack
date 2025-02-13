Random random = new Random();
const int MAX = 21;

string[] jelek = { "Kör", "Káró", "Treff", "Pikk" };
string[] ertekek = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Bubi", "Dáma", "Király", "Ász" };
bool ujra = true;
while (ujra)
{
    Console.Clear();

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

if (jatekosOsszeg == MAX)
{
    if (osztoOsszeg == MAX)
    {
        Console.WriteLine("Döntetlen");
    }
    else
    {
        Console.WriteLine("Black Jack! Ön nyert");
        BlackJacke = true;
    }
}
if (osztoOsszeg == MAX)
{
    Console.WriteLine("Osztónak Black Jack! Ön veszített");
    BlackJacke = true;
}
if (!BlackJacke)
{
    Console.Write("(H)it or (S)tand? ");
    string hitOrStand = Console.ReadLine()!.ToUpper();
    while (hitOrStand == "H")
    {
        string jatekosKartyaSok = (ertekek[random.Next(ertekek.Length)]);
        jatekosOsszeg += KartyaErtek(jatekosKartyaSok);
        Console.WriteLine("Új kártyád: " + jelek[random.Next(jelek.Length)] + " - " + jatekosKartyaSok + ", Új összeg: " + jatekosOsszeg);

        if (jatekosOsszeg > MAX)
        {
            break;
        }
        Console.Write("Szeretnél még lapot húzni? (H/S): ");

        hitOrStand = Console.ReadLine()!.ToUpper();

    }
    if (hitOrStand == "S")
    {
        Console.WriteLine("Osztó második kártyája: " + jelek[random.Next(jelek.Length)] + " - " + osztoKartya2 + ", Új osszeg: " + osztoOsszeg);
        while (osztoOsszeg <= 16)
        {
            string osztoKartyaSok = ertekek[random.Next(ertekek.Length)];
            osztoOsszeg += KartyaErtek(osztoKartyaSok);
            Console.WriteLine("Osztó új kártyája: " + jelek[random.Next(jelek.Length)] + " - " + osztoKartyaSok + ", Új osszeg: " + osztoOsszeg);
        }

    }
    if (jatekosOsszeg > MAX) Console.WriteLine("Túl lépted a 21-et, vesztettél");
    else if (osztoOsszeg > MAX) Console.WriteLine("Túl lépte az osztó a 21-et, ön nyert");
    else if (jatekosOsszeg > osztoOsszeg) Console.WriteLine("Ön nyert");
    else if (jatekosOsszeg < osztoOsszeg) Console.WriteLine("Ön vesztett");
    else Console.WriteLine("Döntetlen");
 }
    Console.WriteLine("Szeretnél egy visszavágot? (I)gen (N)em");
    string igenNem = Console.ReadLine()!.ToUpper();
    if (igenNem == "I")
    {
        ujra = true;
    }
    else if (igenNem == "N")
    {
        ujra = false;
    }
}
int KartyaErtek(string lap)
    {
    if (lap == "Ász") return 11;
    if (lap == "Király" || lap == "Bubi" || lap == "Dáma") return 10;
    if (int.TryParse(lap, out int szam)) return szam;
    return 0;
    }
