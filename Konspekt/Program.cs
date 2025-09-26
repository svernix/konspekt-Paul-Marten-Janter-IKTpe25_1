
//1. tuvasta sisu võrdlus tühja stringiga, string andmetüüp
using System;
using System.ComponentModel.Design;

Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("Sa ei sisestanud oma nime, sadface😢");
}
else if (nimi != "")
{
    Console.WriteLine("Tere " + nimi + "! häpifeiss 😊😊");
}
else
{
    Console.WriteLine("Tundmatu sisestus.");
}
//2- vahemikud
Console.WriteLine(nimi + ", mis on sinu vanus");
int kasutajavanus = int.Parse(Console.ReadLine());

//2.1 mitu tingimust pesastatud ifide abil
//if  (kasutajavanus > 0)
//   {        
//    if (kasutajavanus < 18)
//    {
//        Console.WriteLine("Enerks ei saa, oled alakas, Monsterist ilma 😢");
//    }
//    else
//    {
//        Console.WriteLine("Yippie ! saad monsut osta 😊");
//    }
//}

//2.2 mitu tingimust kasutades loogilist tehet "and"
if (kasutajavanus >0 && kasutajavanus < 18)
{
    Console.WriteLine("Enerksi  ei saa, oled alakas, Monsterist ilma");
}
else
{
    Console.WriteLine("Yippie ! saad monsut osta");
}

//2.3 mittu vahemiku if/else-if abil, andmetüüp double/float/decimal
Console.WriteLine($"Sisesta oma pikkus ka {nimi} ! ");
double kasutajapikkus = double.Parse(Console.ReadLine());

if (kasutajapikkus < 1.00d)
{
    Console.WriteLine("Oled juntsu");
}
else if (kasutajapikkus < 1.25d && kasutajapikkus >= 1.00d)
{
    Console.WriteLine("Oled peaaegu allameetrimees");
}
else if (kasutajapikkus < 1.50d && kasutajapikkus >= 1.25d)
{
    Console.WriteLine("OIOI, päkapikk enam ei olegi, " + nimi);
}
else if (kasutajapikkus < 1.75d && kasutajapikkus >= 1.50d)
{
    Console.WriteLine(", oled enamasti standardpikkuses, kui mitte just natuke lühem " + nimi);
}
else if (kasutajapikkus < 2.00d && kasutajapikkus >= 1.75d)
{
    Console.WriteLine(nimi + ", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
}
else
{
    Console.WriteLine("Täielik tulnukas ! Kuidas pilved välja lähedalt?");
}

//3 kalkulaator ifi ja else-ifiga, int ja string andmetüübid
int arv1 = 0;
int arv2 = 0;
Console.WriteLine("Tere, palun sisesta esimene arv: ");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere, palun sisesta teine arv: ");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
string tehtetüüp = Console.ReadLine();
int tehe = 0;



if (tehtetüüp == "+" /*timgimus siia*/)
{
    tehe = arv1 + arv2;
}
if (tehtetüüp == "+" /* tingimus siia*/)
{
    tehe = arv1 + arv2;
}
if (tehtetüüp == "-" /* tingimus siia*/)
{
    tehe = arv1 - arv2;
}
if (tehtetüüp == "*" /* tingimus siia*/)
{
    tehe = arv1 * arv2;
}
if (tehtetüüp == "/" /* tingimus siia*/)
{
    tehe = arv1 / arv2;
}
Console.WriteLine($"Tehte tulemus: {tehe}");

//4. parool, if ja string andmetüüp
Console.WriteLine($"Palun vabandust {nimi}, aga programmi tööks on parooli vaja");
string password = Console.ReadLine();
if (password == "simsalabim")
{
    Console.WriteLine("JES, parool on õige, oled sisse lubatud");
}
else if (password == "saatana" || password == "1234")
{
    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole");
}
else
{
    Console.WriteLine("Parool on vale");
}

//5. värvituvastus
Console.WriteLine("Mis on sinu lemmik värv");
string favColour = Console.ReadLine();
if (favColour == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favColour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favColour == "valge")
{
    Console.BackgroundColor = ConsoleColor.White;
}
else if (favColour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
}
else if (favColour == "oranz")
{
    Console.WriteLine("kahjuks ei ole oranz saadaval");
}
else if (favColour == "pruun")
{
    Console.WriteLine("kahjuks ei ole pruun saadaval");
}
else if (favColour == "roheline")
{
    Console.BackgroundColor = ConsoleColor.Green;
}
else if (favColour == "helesinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favColour == "tumesinine")
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
}
else if (favColour == "lilla")
{
    Console.WriteLine("kahjuks ei ole lilla saadaval");
}
else if (favColour == "roosa")
{
    Console.WriteLine("kahjuks ei ole roosa saadaval");
}
else if (favColour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
}
else
{
    Console.WriteLine("ei tea seda värvi");
}
    Console.WriteLine("The colour has maybe changed!!!!!");

/* ISESEISEV ÜLESANNE */
//# Kolija kalkulaator - Kirjuta programm mis:
//# - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
//# - olenevalt kasutaja sisestusest küsib ta:
//# - - tünni jaoks:
//# - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
//# - - - tünni kõrgust
//# - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
//# - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
//# - - kasti jaoks:
//# - - - Kas kast on kuubiku kujuline või risttahuka kujuline
//# - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
//# - - - - kui on risttahukas siis küsib kasutajalt:
//# - - - - - pikima külje pikkust,
//# - - - - - lühima külje pikkust ja
//# - - - - - kasti kõrgust
//# - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)

//-
//Console.WriteLine("Tere, kas sa tahad ära mõõta pappkasti või õlitünni");
//string õlitünn = Console.ReadLine();
//string pappkasti = Console.ReadLine();
//if (string = "õlitünn")
//{
//    Console.WriteLine("kas sa tead põhj araadiust (r) või põhja läbimõõtu (d)");
//}
import math

def tyyni_arvutused():
    print("\nValisid õlitünni.")

    teadaolev = input("Kas sa tead põhja raadiust (r) või läbimõõtu (d)? (sisesta 'r' või 'd'): ").lower()
    if teadaolev == "r":
        r = float(input("Sisesta põhja raadius (r): "))
    elif teadaolev == "d":
        d = float(input("Sisesta põhja läbimõõt (d): "))
        r = d / 2
    else:
        print("Vigane sisestus.")
        return

    korgus = float(input("Sisesta tünni kõrgus: "))
    kaane_paksus = float(input("Sisesta kaane paksus: "))

    sisemine_korgus = korgus - kaane_paksus

    # Mahu arvutus (V = πr²h)
    maht = math.pi * r * *2 * sisemine_korgus

    # Küljepindala (A_külg = 2πrh)
    kylgpindala = 2 * math.pi * r * korgus

    # Kogupindala (A_kogu = külgpindala + 2 * põhja pindala)
    pohja_pindala = math.pi * r * *2
    kogu_pindala = kylgpindala + 2 * pohja_pindala

    print(f"\nTünni maht: {maht:.2f} ühikut³")
    print(f"Tünni küljepindala: {kylgpindala:.2f} ühikut²")
    print(f"Tünni kogupindala: {kogu_pindala:.2f} ühikut²")


def kastiarvutused():
    print("\nValisid pappkasti.")

    kujund = input("Kas kast on kuubik või risttahukas? (sisesta 'kuubik' või 'risttahukas'): ").lower()


    if kujund == "kuubik":
        kylg = float(input("Sisesta kuubi küljepikkus: "))
        maht = kylg * *3
        pindala = 6 * kylg * *2
        diagonaal = kylg * math.sqrt(3)

    elif kujund == "risttahukas":
        pikkus = float(input("Sisesta pikima külje pikkus: "))
        laius = float(input("Sisesta lühima külje pikkus: "))
        korgus = float(input("Sisesta kasti kõrgus: "))
        maht = pikkus * laius * korgus
        pindala = 2 * (pikkus * laius + pikkus * korgus + laius * korgus)
        diagonaal = math.sqrt(pikkus * *2 + laius * *2 + korgus * *2)

    else:
        print("Vigane sisestus.")
        return

    print(f"\nKasti maht: {maht:.2f} ühikut³")
    print(f"Kasti kogupindala: {pindala:.2f} ühikut²")
    print(f"Kasti pikim läbiv diagonaal: {diagonaal:.2f} ühikut")


def main():
    print("Tere tulemast Kolija kalkulaatorisse!")
    valik = input("Kas soovid mõõta pappkasti või õlitünni? (sisesta 'kast' või 'tünn'): ").lower()

    if valik == "tünn":
        tyyni_arvutused()
    elif valik == "kast":
        kastiarvutused()
    else:
        print("Vigane valik. Palun käivita programm uuesti ja vali 'kast' või 'tünn'.")

if __name__ == "__main__":
    main()