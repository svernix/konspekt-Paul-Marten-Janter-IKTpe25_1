
//1. tuvasta sisu võrdlus tühja stringiga, string andmetüüp
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

//4 parool, if ja string andmetüüp
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

//5 värvituvastus
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