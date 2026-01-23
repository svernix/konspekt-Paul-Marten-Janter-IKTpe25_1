/*

//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?:");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("Sa ei sisestanud oma nime, sadface 😔");
}
else if (nimi != "")
{
    Console.WriteLine("Tere "+nimi+"! häpifeiss 😀😀 おはよう");
}
else
{
    Console.WriteLine("Tundmatu sisestus.");
}
//2 - vahemikud
Console.WriteLine(nimi+", mis on sinu vanus?:");
int kasutajavanus = int.Parse(Console.ReadLine());

//2.1 mitu tingimust pesastatud ifide abil
//if (kasutajavanus > 0)
//{
//    if (kasutajavanus < 18)
//    {
//        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
//    }
//    else
//    {
//        Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
//    }
//}

//2.2 mitu tingimust kasutades loogilist tehet "and"
if (kasutajavanus > 0 && kasutajavanus < 18)
{
    Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
}
else
{
    Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
}

//2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
double kasutajaPikkus = double.Parse(Console.ReadLine());

if (kasutajaPikkus < 1.00d)
{
    Console.WriteLine("Oled juntsu (Keemstar)");
}
else if (kasutajaPikkus < 1.25d && kasutajaPikkus >= 1.00d)
{
    Console.WriteLine("Oled peaaegu allameetrimees");
}
else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
{
    Console.WriteLine("OIOI, päkapikk enam ei olegi, "+nimi);
}
else if (kasutajaPikkus < 1.75d && kasutajaPikkus >= 1.5d)
{
    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte just natuke lühike");
}
else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75d)
{
    Console.WriteLine(nimi+", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö 😏'");
}
else
{
    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
}

//3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid
Console.WriteLine("tere, sisesta esimene liidetav arv");
int arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("tere, sisesta teine liidetav arv");
int arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("sisesta tehemärk: / * + - ^");
string tehtetyyp = Console.ReadLine();

int tulemus = 0;
if (tehtetyyp == "+")
{
    tulemus = arv1 + arv2;
}
if (tehtetyyp == "-")
{
    tulemus = arv1 - arv2;
}
if (tehtetyyp == "*")
{
    tulemus = arv1 * arv2;
}
if (tehtetyyp == "/")
{
    tulemus = arv1 / arv2;
}
if (tehtetyyp == "^")
{
    tulemus = (int)Math.Pow(arv1, arv2);
}

Console.WriteLine(tulemus);

//4 parool, if ja string andmetüüp
Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
string password = Console.ReadLine();
if (password == "simsalabim")
{
    Console.WriteLine("JES, parool on õige, oled sisse lubatud");
}
else if (password == "saatana" || password == "1234")
{
    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
}
else
{
    Console.WriteLine("Parool on vale");
}

//5 värvituvastus värvidele: punane oranz kollane roheline
// helesinine tumesinine lilla roosa pruun must ja valge
Console.WriteLine("Mis on sinu lemmikvärv?:");
string favColour = Console.ReadLine();
if (favColour == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favColour == "oranz")
{
    Console.WriteLine("Kahjuks ei ole oranz saadaval");
}
else if (favColour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favColour == "roheline")
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
}
else if (favColour == "helesinine")
{
    Console.BackgroundColor = ConsoleColor.Cyan;
}
else if (favColour == "tumesinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favColour == "lilla")
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
}
else if (favColour == "roosa")
{
    Console.WriteLine("Kahjuks roosat anda ei ole");
}
else if (favColour == "pruun")
{
    Console.BackgroundColor = ConsoleColor.DarkYellow;
}
else if (favColour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
}
else if (favColour == "must")
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
}
else
{
    Console.WriteLine("ei tea seda värvi");
}
Console.WriteLine("The colour has maybe changed!!!!!");
*/
/* ISESEISEV ÜLESANNE */

//# Kolija kalkulaator - Kirjuta programm mis:
//#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
//Console.WriteLine("Kas tahad mõõta ära kasti või tünni?");
//string valik = Console.ReadLine();
////#    - olenevalt kasutaja sisestusest küsib ta:
//if (valik == "tünn")
//{

//    //#    - - tünni jaoks:
//    //#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
//    Console.WriteLine("Kas sa tead tünni raadiust (r) või põhja läbimõõtu (d)");
//    string rvõid = Console.ReadLine();
//    Console.WriteLine("Sisesta see mõõt:");
//    double mõõt = double.Parse(Console.ReadLine());
//    if (rvõid == "d")
//    {
//        mõõt = mõõt / 2;
//    }
//    else if(rvõid != "r")
//    {
//        Console.WriteLine("Sisend ei ole tuntav");
//    }

//    //#    - - - tünni kõrgust
//    Console.WriteLine("Kui kõrge on su tünn");
//    int kõrgus = int.Parse(Console.ReadLine());

//    //#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
//    Console.WriteLine("kui paks on tünni kaas?");
//    int kaanepaksus = int.Parse(Console.ReadLine());

//    //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
//    double tünnipõhiS = Math.PI * (mõõt * mõõt);
//    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
//    double küljepindala = tünnipõhiS * kõrgus;
//    double kogupindala = (tünnipõhiS * 2) + küljepindala;
//    Console.WriteLine($"Sinu tünn mahutab {mahtV} \nTünni küljepindala on {küljepindala} \nKogupindala aga on{kogupindala}");
//}
////#    - - kasti jaoks:
//else if(valik == "kast")
//{
//    //#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
//    Console.WriteLine("Kas su kast on kuubik (k) või risttahukas (r)? ");
//    string kastitüüp = Console.ReadLine();
//    if (kastitüüp == "k")
//    {
//        //#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
//        Console.WriteLine("Sisesta kasti küljepikkus:");
//        double külgA = double.Parse(Console.ReadLine());
//        double kuubik = Math.Pow(külgA, 3);
//        double küljepindala = (külgA * külgA) * 6;
//        double diagonaal = külgA * Math.Sqrt(3);
//        Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on{diagonaal}");
//    }
//    //#    - - - - kui on risttahukas siis küsib kasutajalt:
//    else if (kastitüüp == "r")
//    {
//        //#    - - - - - pikima külje pikkust, 
//        Console.WriteLine("Mis on sinu kasti kõige pikim külg?:");
//        double pikkKülg = double.Parse(Console.ReadLine());

//        //#    - - - - - lühima külje pikkust ja
//        Console.WriteLine("Mis on sinu kasti kõige lühim külg?:");
//        double lühikekülg = double.Parse(Console.ReadLine());

//        //#    - - - - - kasti kõrgust
//        Console.WriteLine("Mis on sinu kasti kõrgus?:");
//        double kõrgus = double.Parse(Console.ReadLine());

//        //#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
//        double V = pikkKülg * lühikekülg * kõrgus;
//        double kogupindala = 2 * ((pikkKülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkKülg * kõrgus));
//        double diagonaal = Math.Sqrt((pikkKülg * pikkKülg) + (lühikekülg * lühikekülg) + (kõrgus * kõrgus));
//        Console.WriteLine($"Sinu kast mahutab {V} \nKasti küljepindala on {kogupindala} \nDiagonaal aga on{diagonaal}");
//    }

//}

//Console.WriteLine("banana");
//// Console -> adresseritav moodul või objekt (Roheline)
//// . -> midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
////    - komakohtadega andmetüüpidel komakoha tähistamine.
//// WriteLine -> adresseritav funktsioon objektist Console
//// () -> sulupaar mis omab endas funktsioonile vajalikku infot
////     - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisiõnu "ifi parameeter"
////     - kasutatakse ka matemaatilistes tehetes
//// [] -> tähistab massiive
//// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
////     - saab ka kasutada teksti sees muutujate kuvamiseks
//    // -> taane aitab arendajal aru saada millise koodiploki sees, miski on. Vajalik ka kompilaatorile.
//// "banana" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
//// ; -> iga koodilause lõppeb komakooloniga
//// // -> kommentaaritingmärk üherealise kommentaari jaoks (kaks / märki)

//int muutuja = 3;
//// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on
//// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
//// 3 -> väärtus mis sellele muutujale omistatakse

//võimalikud lihtandmetüübid:
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1; // täisarv
        decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
        float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
        double d = 4.01d; // kümnendsüsteemis olev komakohaga arv, sarnane decimaliga
        char c1 = 'a'; // üksainus täht või tähemärk
        string s = "tekst"; // inimloetaval kujul tekst
        var x = "abc"; // ebamäärase tüübiga kohalik muutuja. 
        var y = 123;
        const int z = 3; // konstant-tüüpi muutujaid ei saa muuta, need on read-only
        //void - void on andmetüüp, mida muutujatele anda ei saa. void on andmetüüp, mida kasutatakse meetodite jms
        //signatuurides, et näidata tagastatava andmetüübi puudumist. Tegemist on - sõna otseses mõttes - mitte millegagi.

        //võimalikud komposiitandmetüübid:
        // 1. massiiv:
        // [] -> Massiiv on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi lihtandmeid. Massiivi tähistatakse kantsulgudega.
        //       Massiive saab olla ükskõik millist lihtandmetüüpi massiive.
        //       Massiivi tekitamisel tuleb ära öelda kui pikk või suur see massiiv on
        //       Massiiv saab olla koostatud ka teistest massiividest.
        //
        // Esimene tekitusviis:
        int[] arvuMassiiv = new int[3]; // andemtüüp int väljendab et tegu on täisarvutüüpoi andmega ja kantsulud väljendavad et tegu ühtlasi
                                        // ka massiiviga. nimeks on "arvuMassiiv" ja võrdusmärgiga, on esimene tekitusmoodus öelda et tegu on
                                        // uue massiiviga kasutades kaitsud sõna "new", ja sellele järgneb massiivi pikkuse sätestus "int[3]"
                                        // see tähendab et siin massiivis on 3 elementi, mis on täisarvud.
                                        // Teine tekitusviis:
        int[] arvuMassiiv2 = [1, 2, 3];   // teine massiivi tekitusviis, kus järjendi pikkuse sätestamise asemel, pannakse elemendid kohe sisse
                                          // järjendi pikkus tuletatakse elementide arvust
                                          // -- massiivi sisemised meetodid:
        int hasthismany = arvuMassiiv.Length; // massiivi meetod "Length" mille me saame kasutusele võtta punkti abil, loendab kokku, mitu
                                              // elementi järjendis parasjagu on

        // 2. loend:
        // List<T> -> Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend-tüüpi andmeid tähistatakse
        //            Täiendava andmetüübikirjeldusega "List" mille järel noolsulgudesse asetatakse mis tüüpi andmed loendis on.
        //            Loendi tekitamisel, erinevalt massiivist, ei pea ütlema kui pikk loend on. Loendisse saab dünaamiliselt elemente juurde
        //            lisada, ehk tema pikkus ei ole fikseeritud.
        //            Sarnaselt massiiviga, saab loend omada endas, teisi loendeid.
        //
        // Esimene tekitusviis:
        List<int> arvuNimekiri = new List<int>(); //Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, List noolsulgude vahel on loendis
                                                  //olevate andmete andmetüüp. muutuja nimeks on "arvuNimekiri". Omistame sellesse muutujasse 
                                                  //kaitstud sõna "new" abil uue tühja täisarvuloendi sätestusega "List<int>()". 
                                                  // Teine tekitusviis:
        List<int> arvuNimekiri2 = new List<int>() { 1, 2, 3 }; //teine loendi tekitusviis, muutuja instantsieerimine võrdusmärgi ees on sama nagu
                                                               //esimesel, juurde tuleb ainult võrdusamärgi taga olevale sätestusele loogelised
                                                               //sulud koos juba sinna asetatud elementidega. Enam ei ole tegu tühja nimekirjaga,
                                                               //vaid loendiga kus on kolm elementi.
                                                               // Kolmas tekitusviis:
        List<int> arvuNimekiri3 = new List<int>(3); //kolmas loendi tekitusviis kus muutuja instantsieerimine jääb samaks, aga, tavaliste sulgude
                                                    //vahel, sarnaselt massiiviga, saame anda loendile esialgse suuruse. Loend ise ei oma veel
                                                    //andmeid, aga loendis on kolm tühja elementi. Nimelt, on sätestusel, peale andmetüüpi
                                                    //kirjeldavaid noolsulge, paar tavalisi sulge, mille sisse saab parameetrina panna loendi
                                                    //pikkuse. ()
                                                    // -- Loendi sisemised meetodid:
        arvuNimekiri3.Add(67); // Loendi meetod "Add()" lisab enne punkti olevale järjendile uue elemendi, element mida lisada, on Add meetodi
                               // sulgude vahel. Elementi saab lisada otse (antud juhul "67") või muutujana - näiteks ...Add(arv);
        int loendiPikkus = arvuNimekiri3.Count(); // Loendi meetod "Count()" loeb kokku mitu elementi järjendis on, meetod tagastab täisarvu 
                                                  //mis vastab elementide kogusele.
        bool kasSeeArvOn = arvuNimekiri3.Contains(3); // Loendi meetod "Contains()" otsib kogu järjendi seest elementi, mis vastab sulgude vahel
                                                      // olevale parameetrile, tagastab kas true või false - on leitud või ei ole. Tegemist on
                                                      // põhimõtteliselt foreach tsükliga, mis otsib kindlat parameetrid, töödeldes läbi, kogu
                                                      // loendi.
        arvuNimekiri3.Remove(4); // Loendi meetod "Remove()" eemaldab enne punkti olevast loendist, kindlal asukohal oleva elemendi. Sulgude
                                 //vahel on parameetriks eemaldatava elemendi asukohajärjekorranumber.

        ////põhilised matemaatilised tehted
        //int liitmine = 1 + 1; // liitmine, kaks arvu kokku
        //int lahutamine = 1 - 1; // lahutamine, esimene arv maha teisest
        //int korrutamine = 1 * 1; //korrutamine, esimene arv korrutatakse teisega
        //int jagamine = 1 / 1; //jagamine, esimene arv jagatakse teisega
        //double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
        //double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse

        /* Matemaatilised tehted moodulist math */

        Math.Round(d); //Moodulist "Math" kutsutakse punkti abil esile meetod "Round". Sulgude vahel on ümardatav arv.
                       //Round ümardab sulgude vahel olevas muutujas asetseva arvu, vastavalt komakohtade parameetrile.
                       //Vaikeväärtusena, lähima täisarvuni. 0-4 on allapoole, 5-9 on ülespoole.
        double newpi = Math.PI; //Moodulist "Math" kutsutakse punkti abil esile kaitstud väärtus, PI mis väljendab matemaatilist
                                //pi-d ning saab kasutada kui tavaline arv.
        double astendus = Math.Pow(2, 2); //Moodulist "Math" kutsutakse punkti abil esile meetod "Pow" (power). Sulgude vahel on
                                          //Kaks parameetrit, esimene on neist Astendatav ja teine astendaja. antud jugul oleks
                                          //vastuseks 16.


        //int arv = 0; // sobib
        //string sõne = "abc"; //sobib
        //string string = "abc"; //ei sobi

        // muutuja nimeks ei sobi järgnevad sõnad:
        //abstract, as, base, bool, break, byte, case,
        //catch, char, checked, class, const, continue, decimal,
        //default, delegate, do, double, else, enum, event,
        //explicit, extern, false, finally, fixed, float, for
        //foreach, goto, if, implicit, in, int,
        //interface, internal, is, lock, long, namespace, new,
        //null, object, operator, out, override, params,
        //private, protected, public, readonly, ref, return, sbyte,
        //sealed, short, sizeof, stackalloc, static, string, struct,
        //switch, this, throw, true, try, typeof, uint,
        //ulong, unchecked, unsafe, ushort, using, virtual, void,
        //volatile, while.

        ////Ülesanne, kasutades süntaksiseletust, kirjelda kommentaariga iga koodirida
        Console.WriteLine("tere, sisesta esimene liidetav arv");
        //Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
        // mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
        int arv1 = int.Parse(Console.ReadLine());
        // instantsieerime muutuja "arv1", ning ütleme et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
        // mille saame kasutajalt Console.Readline() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
        // asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. Lause lõppeb lauselõpumärgiga ; .
        Console.WriteLine("tere, sisesta teine liidetav arv");
        //Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
        // mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
        int arv2 = int.Parse(Console.ReadLine());
        // instantsieerime muutuja "arv2", ning ütleme et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
        // mille saame kasutajalt Console.Readline() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
        // asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. Lause lõppeb lauselõpumärgiga ; .
        Console.WriteLine("sisesta tehemärk: / * + - ^");
        //Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
        // mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
        string tehtetyyp = Console.ReadLine();
        // tekitame muutuja "tehtetyyp", mille ette paneme andmetüübiks string ehk ütleme et seal on tekst, ning võrdusmärgi abil omistame talle
        // konsooli rea pealt loetu info, mis saame kasutades "Console" mooduli, ReadLine() funktsiooni. lause lõppeb lauselõpumärgiga ; ..

        int tulemus = 0;
        // instantsieerime muutuja tulemus, mille andmetüübiks on int, ja omistame talle esialgu väärtuse 0. Lause lõpp lõpeb lauselõpumärgiga
        if (tehtetyyp == "+")
        // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "+"
        {
            tulemus = arv1 + arv2;
        }
        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
        // muutuja arv1 ja muutuja arv2. Lause lõppeb lauselõpumärgiga sulgude sees.
        if (tehtetyyp == "-")
        // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "-"
        {
            tulemus = arv1 - arv2;
        }
        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus lahutades
        // muutujast arv1 muutuja arv2. Lause lõppeb lauselõpumärgiga sulgude sees.  
        if (tehtetyyp == "*")
        // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "*"
        {
            tulemus = arv1 * arv2;
        }
        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus korrutades
        // muutuja arv1 ja muutuja arv2 sisu omavahel kokku. Lause lõppeb lauselõpumärgiga sulgude sees.
        if (tehtetyyp == "/")
        // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "/"
        {
            tulemus = arv1 / arv2;
        }
        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus jagades
        // muutuja arv1 muutujaga arv2. Lause lõppeb lauselõpumärgiga sulgude sees.
        if (tehtetyyp == "^")
        // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "^"
        {
            tulemus = (int)Math.Pow(arv1, arv2);
        }
        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus kasutades
        // moodulist "Math" punkti abil funktsiooni "Pow()", selle sees on arv1 astendatavana esimene parameeter, ning arv2 astendajana teine parameeter.
        // Funktsiooni ees on kiirteisendus kus funktsiooni väljund teisendatakse täisarvuks (int) abil. Lause lõppeb lauselõpumärgiga sulgude sees.

        Console.WriteLine(tulemus);
        // Adresseerime moodulit "Console", ning kasutame sealt funktsiooni "WriteLine" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale tehte vastus.
        // lause lõppeb lauselõpumärgiga.


        Console.WriteLine("Sisesta ostusumma");
        double ostusumma = double.Parse(Console.ReadLine());
        if (ostusumma > 100)
        {
            Console.WriteLine("Saad 20% allahindlust!");
        }
        else if (ostusumma < 101 && ostusumma > 50)
        {
            Console.WriteLine("saad10%allahindlust");
        }
        else if (ostusumma < 51 && ostusumma > 20)
        {
            Console.WriteLine("Saad 5% allahindlust");
        }
        else if (ostusumma < 21)
        {
            Console.WriteLine("Allahindlust ei saa :C");
        }
        else if (ostusumma < 1)
        {
            Console.WriteLine("Sisestatud vigane arv");
        }

        //string kasutajaNimi = "";
        //do
        //{
        //    Console.WriteLine("Palun sisesta oma kasutajanimi");
        //    kasutajaNimi = Console.ReadLine();
        //}
        //while (kasutajaNimi != "user1");
        //if (kasutajaNimi == "user1")
        //{
        //    int ruuduSuurus = 0;

        //    do
        //    {
        //        Console.WriteLine("Kui suurt ruutu tahad?");
        //        ruuduSuurus = int.Parse(Console.ReadLine());
        //    } while (ruuduSuurus < 0 && ruuduSuurus > 20);
        //    char reaKujund = '▓';
        //    string üksRida = "";
        //    int tsükliMuutuja = ruuduSuurus;
        //    do
        //    {
        //        üksRida += "_" + reaKujund;
        //        tsükliMuutuja -= 1;
        //    } while (tsükliMuutuja != 0);
        //    tsükliMuutuja = ruuduSuurus;
        //    do
        //    {
        //        Console.WriteLine(üksRida);
        //        tsükliMuutuja -= 1;

        //    } while (tsükliMuutuja != 0);
        //    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
        //}

        /* tingimuslause osad */
        if (true) { } //kaitstud sõna if kutsub esile tingimuslause, mille tingimus on sulgude vahel ning millele järgneb
                      //koodiplokk tingimuse täitumisel teostatava koodiga
        else if (true) { } //kaitstud sõnad else ja if (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
                           //on samamoodi sulgude vahel, ning millele peab eelnema alati if või else if. Tingimuse täitumisel
                           //ja eelneva tingimuse mittetäitumisel teostatakse koodiploki sees olev kood
        else { } //kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas if või else if, ning mille koodi-
                 //ploki sisu täidetakse kõikide if ja else if sees olevate tingimuste läbikukkumisel.

        int option = 3; // -------
        switch (option) //"switch" on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saab if else-if asemel kasutada.
                        //Sulgude vahele käib muutuja nimi, mille põhjal tingimuslik ümberlülitus toimub. Siin sulgude vahel
                        //ei ole tingimus ise, vaid kõigest kontrollitav muutuja, või omakorda sulgude vahel muu tingimus.
        {               //pärast lülitusvalikut tuleb koodiplokk
            case 1:     //koodiploki sees on erinevad juhtumid. juhtumit kontrollitakse kaitstud sõna "case" abil. Antud juhul
                        //kontrollitakse, kas muutujas on väärtus 1, millele järgneb koolon ":"
                        //peale koolonit kirjeldatakse tehtav tegevus
                break;  //ja kui tegevus on täidetud, väljutakse kogu switch tegevusest kaitstud sõna "break"iga. Peale "break"i
                        //on lauselõpumärk ";"
            case 2:
                break;
            case 3:
                break;
            //juhtumeid võib olla mitmeid, antud juhul on neid kolm kindlalt, ja üks mida tehakse igal muul juhul.
            default:    //kaitstud sõna "default" avab juhtumi kui muutujas ei ole mitte ühtegi muud "case" juhtumi tingimust.
                break;  //Ka default lüppeb sõnaga "break;"
        }

        /* Sõne tööriistad jm tekstiga seotud */
        string alfa = "a\nb";    // \n -> tekitab ühe sõne sisse reamurde, sõne kus on üks "\n" omab kahte rida
        string beta = $"a {alfa} b"; // $  -> lubab kasutada muutujaid loogeliste sulgude vahel otse teksti sees

        /* Loogilised tehted */
        // && -> "and" loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) juhul kui
        //      mõlemal pool && märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
        // || -> "or" loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) siis kui
        //      vähemalt üks tingimus on täidetud. negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
        // !  -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus mis muidu tagastaks true, hüüumärgi
        //       puhul tagastab false, ja vastupidi - tulemus mis muidu tagastaks false, hüüumärgi puhul tagastab true.

        /* Võrdlusoperaatorid */
        // == -> on võrdne. Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt Võrdusmärkide teisel pool oleva
        //       objektiga. ei ole sama nagu üks võrdusmärk. üks võrdusmärk omistab, kaks võrdleb.
        // != -> ei ole võrdne. Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu teisel pool olev objekt.
        //       Võrdlusoperaator on kombinatsioon "on võrdne" operaatorist, ja loogilisest tehtest "not".
        // >  -> on suurem kui. Märgist vasakul pool olev objekt peaks olema suurem kui paremal pool olev objekt.
        // <  -> on väiksem kui. Märgist vasakul pool olev objekt peaks olema väiksem, kui paremal pool olev objekt.
        // >= -> on suurem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem
        //       kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
        // <= -> on väiksem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem
        //       kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.

        /* Omistusoperaatorid ja kiirtehted */
        int arv = 1;// =  -> üksik võrdusmärk omistab muutujale väärtuse.
        arv += 1;   // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
                    //       asendab tehet "arv = arv + 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest ("=")
        arv -= 1;   // -= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujast maha võrdusmärgi teisel pool oleva väärtuse.
                    //       asendab tehet "arv = arv - 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest ("=")
        arv *= 2;   // *= -> võrdusmärk mille ees on korrutusmärk *. automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva
                    //       arvu kordi. asendab tehet "arv = arv * 2". on kombinatsioon matemaatilisest tehtest "*" ja omistamisest ("=")
        arv /= 2;   // *= -> võrdusmärk mille ees on jagamismärk /. automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva
                    //       arvu osadeks. asendab tehet "arv = arv / 2". on kombinatsioon matemaatilisest tehtest "/" ja omistamisest
                    //       ("=")
        arv++;      // ++ -> on spetsiifiliselt ühe juurde liitmiseks lühivariant.
        arv--;      // -- -> on spetsiifiliselt ühe maha lahutamiseks lühivariant.

        /* Tsüklid */

        // 1. do-while
        int dw = 0;
        do // "do" on kaitstud sõna, mis alustab do-while tsüklit pärast mida on koodiplokk, ning ütleb et tee seda koodi
        {
            dw++;
        } while (dw != 5); //niikaua kuni while järel olevate sulgude vahel olev tingimus on täidetud.

        // 2. while
        int i = 1; //tsüklimuutuja mis kontrollib "while" tsükli tööd
        while (i < 5) //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab tihtipeale välist tsüklimuutujat
                      //antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, sulgude vahel, kontrollibki tingimuse abil, selle
                      //muutuja olekut. Siin kontrollitakse, et tsükkel ei oleks suurem kui 5, kui ta on, siis tsükli töö lõppeb.
        {
            //koodiplokk kus midagi tehakse
            i++; //ning seejärel muudetakse tsüklimuutuja "i" olekut, antud juhul liidetakse 1 juurde
        }

        // 3. for
        int kogus = 6; //muutuja mida tsükkel kasutab töötlemiseks mingisugusel kujul
        for (int k = 0; k < kogus; k++) // kaitstud sõna "for" alustab for tsüklit, pärast mida on sulud, mille vahel on kõik tsükli töö jaoks
                                        // vajalik info. esimene parameeter tekitab tsükli töö jaoks muutuja "int k = 0;", teine parameeter on
                                        // tingimuslause mis kontrollib tingimuse täitumist "k < kogus;" ning kolmas inkrementeerib tekitatud
                                        // muutujat "k++;". pane tähele et iga sulgude vahel oleva osa järel on lauselõpumärk. Tsükli tööd
                                        // kontrolliv tingimuslause koosneb kolmest reast, mitte ühest, nagu while, või do-while puhul.
        {                               // koodiplokk kus tehakse mingi tegevus
            Console.WriteLine(k);       // antud juhul on tegevuseks muutuja "k" arvu väljakuvamine
        }

        // 4. foreach
        int[] arvuLoend = { 3, 89, 123412, 7, 67 }; //massiiv mida foreach tsükkel kasutab, või töötleb mingil kujul.
        foreach (var arvInLoend in arvuLoend) // kaitstud sõna foreach alustab foreach tsükli. Pärast mida on sulud, mille vahel tekitatakse
                                              // ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. süntaksis olev
                                              // kaitstud sõna "in" väljendab et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend
                                              // muutuja hoiab endas just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nähtavat
                                              // tsüklimuutujat ega tingimust, tsükkel toimib niikaua kuni elemente jätkub ehk tsükli töö käib
                                              // iga üksiku elemendi kohta andmekogumis. Tsüklil ei ole vaja tsüklimuutujat, kuna talle on
                                              // sisse ehitatud vaikimisi elemndi järjestuse jälgimine. Niipalju kui andmeid on, ongi see,
                                              // mitu korda tsükkel käivitatakse.
        {                                     // {} koodiplokk kus tehakse mingi tegevus
            Console.WriteLine(arvInLoend);    // antud juhul kuvatakse välja ajutine muutuja, mille sees on loendi element. 
        }

        /* Castimine */

        // Castimine on viis, kuidas ühest andmetüübist teist saada. Castimist on kahte eri liiki, automaatne ja manuaalne.
        // Automaatne castmine toimub siis, kui teisendatakse väiksemast andmetüübist, suuremasse.
        // Manuaalne castimine toimub siis, kui tahetakse saada suuremast andmetüübist väiksemat.
        // Castitakse nii, et teisendatava muutuja ette, pannakse sulud koos soovitud andmetüübiga.

        double newData1 = 2.22d; //tekitame, või on olemas, suure mahuga andmed muutujas newData1. Tegu on double andmetega.
        float data1Float = (float)newData1; //"(float)" teisendab double tüüpi andmed float tüüpi andmeteks.
        long data1Long = (long)newData1; //"(long)" teisendab double tüüpi andmed long tüüpi andmeteks.
        int data1Int = (int)newData1; //"(int)" teisendab double tüüpi andmed int tüüpi andmeteks.
        char data1Char = (char)newData1;//"(char)" teisendab double tüüpi andmed char tüüpi andmeteks.

    }
    /* meetodid */

    // Meetodid on väljakutsutavad koodijupid. Meetodid teostavad tavaliselt mingeid funktsioone või tegevusi.
    // Meetodid lasevad programmeerijal taaskasutada oma eelnevalt kirjutatud koodi - write once use many times.
    // Meetodeid on kahte liiki - ühed, mis tagastavad andmeid mingisuguse töö tulemina, ja teised, mis ei tagasta
    // midagi, kuid omavad siiski mingit tegevust.

    // Meetodi signatuur:
    // Meetodi signatuur koosneb mitmest kindalt äramääratud omadusest, nendeks on:
    // - Juurdepääsu modifikaator mis ütleb ära, kust ja kuidas sellele meetodile juurde pääseda saab
    //   public - meetod on avalik ja kättesaadav ka teistes klassides peale selle, kus meetod ise asub.
    //   private - meetod on saadav ainult selles klassis, kus meetod ise asub.
    //   protected - meetod on saadav ainult selles klassis, kus meetod ise asub ja kõikides klassides millen on pärilus
    //               sellele klassile.
    //   internal - meetod on saadav ainult selles klassis ja ainult selles failis.
    // - Võib olla ka pandud static - meetod kuulub selle klassi juurde
    // - Tagastustüüp on modifikaator mis ütleb ära, mis tüüpi andmeid meetod tagasi annab kutsumise asukohta.
    //   Andmetüüp mida tagastada võib olla ükskõik milline liht või kombinatsioonandmetüüp, aga kui meetod ei tagasta
    //   üldse andmeid, pannakse selle asemel andmetüübiks "void". Kui meetodil on tagastustüüp mis on midagi muud kui
    //   void, on meetodi sees, iga toimiva koodisuuna lõpus, kaitstud sõna "return", return ütleb, et just see, on vaja
    //   väljakutseasukohta tagastada, ning peale returni on muutuja nimi tagastatava infoga. Peale return lauset, ei
    //   teostata mitte ühtegi muud meetodi sisu. Return toimib ka kui breakina, lõpetades siis aktiivse meetodi töö.

    // 1. tüüpi meetod - ei tagasta midagi
    public static void UusMeetod() //meetodi signatuur, mis omab juurdepääsumodifikaatorit "public", "static" ütleb et
                                   //ta on selle klassi oma, tagastustüüp "void" ütleb et andmeid meie meetod ei tagasta
                                   //ning pärast meetodi omadusi on meetodi nimi "UusMeetod" peale mida on sulud, kus
                                   //parameetreid ei ole. 
    {                              //pärast signatuuri on koodiplokk meetodi koodiga {}
        Console.WriteLine("Tere"); //Antud juhul meetod kuvab konsooli sõnumi.
    }
    // 2. tüüpi meetod - tagastab väärtuse
    int[] arvutatavadArvud = new int[] { 3, 67, 420 }; //Töödeldavad andmed, mis asuvad täisarvumassiivis, muutujanimega
                                                       //"arvutatavadArvud.
    public static int ArvutaKokku(int[] arvud) //Meetod, mille signatuuris on juurdepääsumodifikaator public, static
                                               //ütleb et meetod kuulub siia klassi, tagastustüüp "int" ütleb, et
                                               //programmis väljakutseasukohta tagastatakse täisarv, peale seda on
                                               //meetodi nimi "ArvutaKokku" ning sulgude vahel ootab meetod täisarvumassiivi
                                               //millele pannakse meetodi sees ajutine nimi arvud. Peale signatuuri on
                                               //koodiplokk {} tehtava koodiga.
    {
        int summa = 0; //Tekitatakse täisarvuandmetüüpi muutuja nimega "summa", kuhu esialgu omistatakse arv 0.
        foreach (int i in arvud) //foreach tsükliga käiakse kõik täisarvumassiivi "arvud" arvud läbi
        {
            summa += i; //ja muutujale summa lisatakse juurde, hetkel käidav element.
        }
        return summa; //pärast tsükli töö lõppu tagastakse "return" käsu abil, muutuja summa sisu.
    }

}
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arv1 = 5;
            int arv2 = 5;
            Console.WriteLine("Tere, palun sisesta esimene arv: ");
            arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Palun sisesta teine arv: ");
            arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / * ^^");
            string tehtetüüp = Console.ReadLine();
            int tehe = 0;
            if (tehtetüüp == "+" /*tingimus siia*/)
            {
                tehe = arv1 + arv2;
            }
            if (tehtetüüp == "-" /*tingimus siia*/) ;
            {
                tehe = arv1 - arv2;
            }
            if (tehtetüüp == "/" /*tingimus siia*/)
            {
                tehe = arv1 / arv2;
            }
            if (tehtetüüp == "*" /*tingimus siia*/)
            {
                tehe = arv1 * arv2;
            }

            if (tehtetüüp == "^^") /*tingimus siia*/
            {
                tehe = (int)Math.Pow(arv1, arv2);

            }
            Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");




        }
    }
}
string valik = "";
double pindala = 0;
Console.WriteLine("Tere, kas sinu tuba on kolmnurga,ristküiku või ringikujuline?");
valik = Console.ReadLine();
Console.WriteLine("Sisesta kujundi nimi: ");
if (valik == "kolmnurk")
{
    Console.WriteLine("Palun sisesta oma toa esimene külg");
    Console.WriteLine("Sisesta a_külg");
    double a_külg = int.Parse(Console.ReadLine());
    Console.WriteLine("Palun sisesta toa teine külg");
    Console.WriteLine("Sisesta b_külg");
    double b_külg = int.Parse(Console.ReadLine());
    Console.WriteLine("Palun sisesta toa kolmas külg.");
    Console.WriteLine("Sisesta c_külg");
    double c_külg = int.Parse(Console.ReadLine());
    pindala = (a_külg + b_külg + c_külg) / 2;
    Console.WriteLine($"Kolmnurga pindala on" + pindala + "ruutmeetrit");
}
else if (valik == "ristkülik")
{
    Console.WriteLine("Sisesta ristküliku pikkus");
    double pikkus = int.Parse(Console.ReadLine());
    Console.WriteLine("Sisesta ristküliku laius");
    double laius = int.Parse(Console.ReadLine());
    pindala = pikkus * laius;
    Console.WriteLine($"ristküliku pindala on" + pindala + "ruutmeetrit");
}
else if (valik == "ring")
{
    Console.WriteLine("Sisesta ringi raadius");
    double raadius = int.Parse(Console.ReadLine());
    pindala = Math.PI * Math.Pow(raadius, 2);
    Console.WriteLine($"ristküliku pindala on" + pindala + "ruutmeetrit");
}
Console.WriteLine("Sisesta ostusumma");
// Kasutamemoodulit "Console" ning punkti abil. moodulist saame funktsiooniga
//"Writeline" livada rea, mille järelolevate sulgude vahe on kuvatav tekst,
//ka omakorda jutumärkide vahel. Jutumärgid tähistavad sõnet.

double ostusumma = double.Parse(Console.ReadLine());
//Console.ReadLine toob ekraanile sõnumi, mis ütleb kasutajale, et ta peab sisestama summa
//Console.ReadLine vaatab üle kasutaja trükitud numbri
//Double.Parse muudab sisse trükitud arvu komakohaga arvuks, et saaks arvutada matemaatiliselt
// double ostusumma loob muutuja nimega ostusumma kuhu salestatakse kasutaja sisestatud arv.

if (ostusumma > 100)
//if (ostusumma > 100) Vaatab, kas ostusumma on suurem kui 100
//if kontrollib, kas tingimus on tõene või väär
//Kui on, siis teeb selle sees oleva käsu
{
    Console.WriteLine("Saad 20% allahindlust!");
    //Kui viimane sõnum on õige, siis tuuakse ekraanile sõnum
    // Koodiplokk sisaldab ühte rida, kus kasutame Console.Writeline moodulit, et saaksima kuvada sõnumi "Saad 20% allahindlust"
    // käsk Console.Writeline jääb "Console" moodulisse, mille kaudu saame teksti ekraanile trükkida
}
else if (ostusumma > 101 && ostusumma > 50)
//Teeme tingimuslause else if, mis kontrollib järgmist summakategooriat, kui eelmine if ei olnud tõene
// && tähednab "ja" ning mõlemad tingimused peavad kehtima
//Kas muutuja ostusumma on suurem kui 50 aga kindlasti väiksem või võrdne 100-ga, kuna eelmine if ei käivitunud
{
    Console.WriteLine("Saad 10% allahindlust!");
    // Koodiplokk {} sees trükib sõnumi kuvarile, et klient saab 10% soodustust
    //Adresseerimine moodulit "console", punkti abil ütleme, et kasutame sealt funktsiooni "WriteLine" koos sulgude vahel parameetriga tulemus, et kuvada sõnum "Saad 10% allahindlust"
    //lause lõppeb lauselõpumärgiga
}
else if (ostusumma > 51 && ostusumma > 20)
// Kui eelmised ei sobinud, vaadetakse üle, kas summa jääb 21-50 vahele
// && tähendab "ja" ning mõlemad tingimused peavad kehtima
//ostusumma algne hind võu kogusumma enne allahindlust.
{
    Console.WriteLine("Saad 5% allahindlust");
    //Kuvame sõnumi ekraanile 5% allahindluse kohta
    // Adresseerimine moodulit "Console", punkti abil ütleme, et kasutame sealt funkstiooni "WriteLine" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale sõnum "Saad 5% allahindlust"
    //lause lõppeb lauselõpumärgiga
}
else if (ostusumma < 21)
//Kontrollib, kas kasutaja trükitud ostusumma on väiksem kui 21
//Kui on, siis programm trükib ekraanile "Kahjuks soodustust ei saa".
//Kui ei ole, siis programm läheb edasi järgmise else if juurde.
{
    Console.WriteLine("Allahindlust ei saa");
    //Console käsuribale, et kus saaks programm teksti väljastada
    //Writeline on funtksioon, mis väljastab kuvarile teksti ja läheb edasi uuele reale
}
else if (ostusumma < 1)
// Kontrollib, kas ostusumma on väkseim kui 1, et vale trükk
// Kui jah, siis programm trükib ekraanile "Vigane arv sisestatud"
// Kui ei, siis programm lõpetab, sest tingimused on kontrollitud
{
    Console.WriteLine("Sisestatud vigane arv");
    //Console käsuribale, kus programm saab teskti väljastada
    // Writeline on funtksioon, mis väljastab kuvarile teksti ja läheb edasi uuele reale
    // Kui mitte ükski viimastest ostusummadest kontrolli tingimustest ei kehti, tähendab see, et kasutaja poolt sisestati vale arv ja programm ei lähe tööle
}
string kasutajaNimi = "";
string salasõna = "";
string õigeKasutajaNimi = "Paul";
string õigeSalasõna = "1234";

do
{
    Console.Write("Mis on sinu nimi? ");
    kasutajaNimi = Console.ReadLine();

    if (kasutajaNimi != õigeKasutajaNimi)
    {
        Console.WriteLine("Isik pole registreerunud");
        continue;
    }

    Console.Write("Mis on parool? ");
    salasõna = Console.ReadLine();

    if (salasõna != õigeSalasõna)
    {
        Console.WriteLine($"{kasutajaNimi}, parool on vale");
    }

} while (kasutajaNimi != õigeKasutajaNimi || salasõna != õigeSalasõna);

Console.WriteLine($"Tere {kasutajaNimi}");


string[] loomad = new string[3];

int loend = 0;

while (loend < loomad.Length)
{
    Console.WriteLine($"Sisesta oma{loend + 1} lemmiklooma nimi");
    loomad[loend] = Console.ReadLine();
    loend++;
}

Console.WriteLine($"sisestasid {loend} lemmiklooma nimed");

int valik = 0;

do
{
    Console.WriteLine("Milline neist on su lemmikuim? (vali number 1-3)");
    valik = int.Parse(Console.ReadLine());
} while (valik < 1 || valik > 3);
Console.WriteLine($"Sinu lemmikuim loom on: {loomad[valik - 1]}");
//string kasutajaNimi = "";
//do
//{
//    Console.WriteLine("Palun sisesta oma kasutajanimi");
//    kasutajaNimi = Console.ReadLine();
//} while (kasutajaNimi != "Mihkel");
//if (kasutajaNimi == "Mihkel")
//{

//}


//int parool = 0;
//Console.WriteLine("Palun sisestage parool");
//parool = int.Parse(Console.ReadLine());
//while (parool > 1000 && parool < 9999)
//{
//    Console.WriteLine("Sinu parool sobib");
//}
//if (parool < 1000 && parool > 9999)
//{
//    Console.WriteLine("Vale parool! Parool peab olma neljakohaline arv");
//}


//int puuviljad = 5;
//for (int i = 0; i < puuviljad; i++)
//{
//    Console.WriteLine(i);
//}





//int[] arvuLoend = { 1, 2, 3, 4, 5 };
//foreach (var arvInLoend in arvuLoend)
//{
//    Console.WriteLine(arvInLoend);
//}

//Console.WriteLine("Tere kasutaja, mis on sinu nimi?");
//string nimi = "";
//nimi += Console.ReadLine();
//if (nimi != "Nipitiri") 
//{
//    Console.WriteLine("Sa pole Nipitiri, ootan ainult Nipitirit.");
//}

//Console.WriteLine("Tere kasutaja, kas sulle meeldivad tulbid?");
//string tulbid = "";
//tulbid = Console.ReadLine();
//if (tulbid != "jah")
//{
//    Console.WriteLine("Mulle ka :) ");
//}
//else 
//{
//    Console.WriteLine("Sorri mees ma ei saa sinust aru :( ");
//}

//Console.WriteLine("Tere kasutaja, mitu tundi sa sel nädalal mängisid?");
//int mängutunnid = 0;
//mängutunnid = int.Parse(Console.ReadLine());
//if (mängutunnid == 0)
//{
//    Console.WriteLine("Kahju, et sul pole aega mängida.");
//}
//else if (mängutunnid < 10 && mängutunnid > 0)
//{
//    Console.WriteLine("Mõõdukas mängur oled");
//}
//else if (mängutunnid < 20 && mängutunnid > 10)
//{
//    Console.WriteLine("Natuke paljuks läheb, kodutööd kannatavad");
//}
//else if (mängutunnid < 40 && mängutunnid > 20)
//{
//    Console.WriteLine("Liiga palju mängid, kas kooli üldse jõuad?");
//}
//else if (mängutunnid < 40)
//{
//    Console.WriteLine("Siin peaks juba psühholoog sekkuma");
//}

//int jalgpalliMäng = 0;
//Console.WriteLine("Mis su viimase mängu tulemus on?");
//jalgpalliMäng = int.Parse(Console.ReadLine());
//switch (jalgpalliMäng)
//{
//    case 0:
//        Console.WriteLine("Pudrujalg oled v?");
//        break;
//    case 1:
//        Console.WriteLine("Täitsa okei");
//        break;
//    case 2:
//        Console.WriteLine("Nu see juba parem");
//        break;
//    case 3:
//        Console.WriteLine("Wow, Messi");
//        break;
//    case 4:
//        Console.WriteLine("Ei tunne sellist numbrit");
//        break;
//}
namespace IF_ELSEIF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Küsi kasutajalt tema pikkust
            //kui ta on lühem kui 0cm, ütle võimatu pikkus
            // kui ta on lühem kui 1m, ütle juntsu
            // kui ta on lühem kui 2m, ütle tavaline kolge
            // kui ta on pikem kui 2m, ütle hiiglane

            // küsi kasutajalt kui vana ta on
            // küsi kasutajalt praegust aastaarvu
            // lahuta aastast kasutaja vanus
            // kui kasutaja on sündinud 2025-2020, ütle talle kes sulle juba arvuti andis
            // kui kasutaja on sündinud 2020-2015, ütle talle skibidi sigmaless
            // kui kasutaja on sündinud 2015-2010, küsi talt kas ta tahab saada programmeerijaks
            // kui jah, ütle tubli
            // kui ei ütle kahju
            // kui kasutaja on sündinud enne 2010, küsi mitu rage comicsit ta täna oma redditi lugemise ajal leidis

            //küsi kasutajalt tema elukoha suunakoodi
            //kui suunaood on väiksem kui 5 tähte, ütle taööe 1 täht on üle
            // kui suunakoodis on 5 tähte, ütle "ahha nüüd tean kus elad"

            // küsikasutajalt kas ta töötab 
            // kui kasutaja vastab jah siis ütle tubli
            // kui kasutaja vastab otsin, siis ütle, loodan et saad varsti tööle c:

            // küsi kasutajalt tema parooli
            // seejärel küsi kasutajalt tema 2FA koodi
            // kui parool on vale, ütle sissepääs keelatud
            // kui parool on õige kontrolli 2FA koodi:
            // kui 2FA kood on lühem kui 6 tähte, ütle sissepääs on keelatud, kood on liiga lühike
            // kui 2FA kood on pikem kui 6 tähte, ütle sissepääs on keelatud, kood on liiga pikk
            // kui 2FA kood on 6 tähte , siis lase sisse öeldes "oled sissepääsenud"
            // NB: 2FA kood ei pea matchima eksisteeriva näitega parool


        }
    }
}
namespace sõled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string lause = "Tere hommikust, mul on monster otsas, kas ma võin veel magada?";
            //Console.WriteLine("lause pikkus on: " + lause.Length);
            //Console.WriteLine("See tekst on capslockis:" + lause.ToUpper());
            //Console.WriteLine("See tekst on väiketähtedes:" + lause.ToLower());
            //Console.WriteLine("Kas lauses on sõna \"magada\"+",lause.ToLower().Contains("magada"));

            List<string> list = new List<string>() { "auto", "kraav", "kruus" };
            string listkoos = "";
            foreach (var sõne in list)
            {
                listkoos += (" " + sõne.ToUpper() + ",");
            }
            Console.WriteLine(listkoos);

            string eesnimi = "Julius";
            string perekonnanimi = "Caesar";
            string amet = "Ohver";
            string kuuluskeiser = string.Concat(eesnimi, perekonnanimi, amet);
            Console.WriteLine(kuuluskeiser);
        }
    }
}
namespace castimine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double komakohagaarv = 9.45d;
            Console.WriteLine((int)komakohagaarv);
            int roundedarv = (int)Math.Round(komakohagaarv);
            Console.WriteLine(roundedarv);


            int arv = 35;
            string arvtekstina = arv.ToString();
            Console.WriteLine(arvtekstina);
            Console.WriteLine(arv);
            double arvdouble = 279346559d;
            int arvint = 0;
            arvint = (int)arvdouble;
            double uusdouble = arvint;
        }
        //kirjuta programm mis küsib kasutajalt meetrites tema pikkust (komakohtadega)
        //teisenda kasutaja pikkus sentimeetriteks
        //küsimine esialgu on tekstikujul (kasutaja sisestab teksti),
        //programm ise peab tekstist välja lugema komakohaga arvu
    }
}
string pikkusm = "";
Console.WriteLine("Sisesta oma pikkus");
pikkusm = Console.ReadLine();
float pikkusFm = float.Parse(pikkusm);
int pikkuscm = (int)pikkusFm * 100;
Console.WriteLine($"Sinu pikkus sentimeetrites on: {pikkuscm}");
namespace castimine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double komakohagaarv = 9.45d;
            Console.WriteLine((int)komakohagaarv);
            int roundedarv = (int)Math.Round(komakohagaarv);
            Console.WriteLine(roundedarv);


            int arv = 35;
            string arvtekstina = arv.ToString();
            Console.WriteLine(arvtekstina);
            Console.WriteLine(arv);
            double arvdouble = 279346559d;
            int arvint = 0;
            arvint = (int)arvdouble;
            double uusdouble = arvint;
        }
        //kirjuta programm mis küsib kasutajalt meetrites tema pikkust (komakohtadega)
        //teisenda kasutaja pikkus sentimeetriteks
        //küsimine esialgu on tekstikujul (kasutaja sisestab teksti),
        //programm ise peab tekstist välja lugema komakohaga arvu
    }
}
string pikkusm = "";
Console.WriteLine("Sisesta oma pikkus");
pikkusm = Console.ReadLine();
float pikkusFm = float.Parse(pikkusm);
int pikkuscm = (int)pikkusFm * 100;
Console.WriteLine($"Sinu pikkus sentimeetrites on: {pikkuscm}");


namespace meetod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tervitus();
            string kasutajanimi = "";
            while (kasutajanimi == "")
            {
                Tervitus();
                Console.WriteLine("Palun sisesa oma kasutajanimi");
                kasutajanimi = Console.ReadLine();
            }
            Console.WriteLine("Mis on sinu nädalane eelarve?");
            float eelarve = 0.00f;
            bool kaskasutajanõustub = false;
            while (kaskasutajanõustub != true)
            {
                Console.WriteLine($"Praegune eelarve on {eelarve}, kas see on õige?");
                Console.WriteLine("Vasta kas jah või ei: ");
                string mistaütles = Console.ReadLine();
                if (mistaütles == "jah")
                {
                    kaskasutajanõustub = true;
                }
                SinuEelarvePäevas(eelarve, kasutajanimi);
            }
            Console.WriteLine($"{kasutajanimi} sinu eelarve on:{SinuEelarvePäevas(eelarve)}SinuEelarvePäevas(eelarve);
        }
        public static void Tervitus()
        {
            Console.WriteLine("'ommik");
        }
        public static int SinuEelarvePäevas(float eelarve, string kasutajanimi)
        {
            double eelarvepäevas = eelarve / 7;
            return (int)eelarvepäevas;
        }
    }
}

//Console.WriteLine("Joonistan sulle kolmnurga:");
//int kolmnurgaSuurus = int.Parse(Console.ReadLine());

//int i = 1;
//while(i <= kolmnurgaSuurus)
//{
//    Console.WriteLine();
//    int j = 1;
//    while (j<= i)
//    {
//        Console.WriteLine("_67");
//        j++;
//    }
//    i++;
//}
Console.WriteLine("Tere tulemast MobiFix parandusautomaati! Kuidas saan aidata?");
Console.WriteLine("0 - headaega\n1 - tahan telefoni parandada");
int kasutajavalik = int.Parse(Console.ReadLine());
while (kasutajavalik < 0 && kasutajavalik > 1) ;
{
    Console.WriteLine("Palun tee oma valik, kirjutades vastav arv,");
    kasutajavalik = int.Parse(Console.ReadLine());
}
if (kasutajavalik == 0)
{
    Console.WriteLine("Headaega, tulge jälle.");
}
else
{
    Console.WriteLine("Palun sisesta oma telegoni mudel, mida parandada soovid:");
    Console.WriteLine("1-iPhone\n2-Xiaomi\n3-Huawei\n4-Samsung");
    Console.WriteLine("Palun tee oma valik, kirjutades vastav arv,");
    int kasutajaTelefon = int.Parse(Console.ReadLine());
    while (kasutajaTelefon < 1 && kasutajaTelefon > 4)
    {
        kasutajaTelefon = int.Parse(Console.ReadLine());
        Console.WriteLine("Palun tee oma valik, kirjutades");
    }
    switch (kasutajaTelefon)
    {
        case 1:
            Console.WriteLine("Aitäh, oma iPhone saad tagas 1 nädala pärast");
            break;
        case 2:
            Console.WriteLine("Aitäh, sinu Xiaomi on valmis 2 kuu pärast");
            break;
        case 3:
            Console.WriteLine("Kahjuks me huaweid ei teeninda");
            break;
        case 4:
            Console.WriteLine("Sinu samsung saab valmis 2 päeva pärast");
            break;
        default:
            break;
    }
}

//Console.WriteLine("Tere kasutaja palun sisesta oma eesnimi");
//string nimi = "";
//do
//{
//    Console.WriteLine("sinu nimi on:");
//    nimi = Console.ReadLine();
//} while (nimi == "");

//Console.WriteLine("Tere kasutaja palun sisesta oma sünnikuupäev");
//string sünnikuupäev = "";

//int == "";
//{
//    Console.WriteLine("sinu sünnikuupäev on: ");
//    sünnikuupäev = Console.ReadLine();
//} while (sünnikuupäev == "") ;


Console.WriteLine("Tere kasutaja palun sisesta kõik inimesed, kes tulevad su sünnipäevale");



//Console.WriteLine("For tsükkel");

//int kogus = 5;
//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("🍎");
//    Console.Beep();
//}

string[] objectArray = new string[5]; //array, massiiv mitmest elemendist
int objectCount = 0; //loend kui palju kordi küsida
string temp = "no name"; // muutuja mis hetkel on "tühi"
while (objectCount < 5) // while tsükkel mis küsib nimesi
{
    Console.WriteLine("Sisesta järgmine lemmikloomanimi");
    string temp = Console.ReadLine(); // temp muutujasser väärtuse (mida me tahame) sisestamine
    objectArray.Append(temp); // massiivi, asukohal objectCount asetamine ajtises muutujast väärtuse
    objectCount++; // tsükli inktementatsioon
}
Console.WriteLine("Oled sisestanud järgnevad objektid"); // sõnum
for (int i = 0; i < objectArray.Length; i++)
{
    Console.WriteLine($"{i + 1} element on: {objectArray[i].ToString()}");
    // kuvame välja reanumbri koos vastava elemendiga, muutuja i abil
}
string õigenimi = "hundiexpress101";
string õigeParool = "Coca-Cola";
Console.WriteLine("Sisesta Parool");
string kasutajanimi1 = Console.ReadLine();
string valik;
if (kasutajanimi1 != õigenimi) ;
{
    Console.WriteLine("Kasutajat nimega" + kasutajanimi1 + "ei ole registeeriud");
}
Console.WriteLine("Sisesta parool");
string parool = Console.ReadLine();

if (parool != õigeParool) ;
{
    Console.WriteLine("Vale parool" + kasutajanimi1 + "!");
}
Console.WriteLine("Tere tulemast" + kasutajanimi1 + "!");
string[] lemmikloomad = new string[3];
int i = 0;

while (i < 3) ;
{
    Console.WriteLine("Sisesta oma lemmikloomanimi (" + (i + 1) + "/3");
    lemmikloomad[i] = Console.ReadLine();
}
Console.WriteLine("Milline on su lemmikum (1-3)");


using System.Diagnostics.CodeAnalysis;

string kasutajanimi = "";
do
{
    Console.WriteLine("Palun sisesta oma kasutajanimi");
    kasutajanimi = Console.ReadLine();
}
while (kasutajanimi != "user1");
if (kasutajanimi == "user1") ;
{
    int ruuduSuurus = 0;
    do
    {
        Console.WriteLine("Kui suurt ruutu tahad");
        ruuduSuurus = int.Parse(Console.ReadLine());
    } while (ruuduSuurus > 0 && ruuduSuurus < 20);
    char reakujund = 'D';
    string üksrida = "";
    int tsüklimuutuja = ruuduSuurus;
    do
    {
        üksrida += reakujund;
        tsüklimuutuja -= 1;
    } while (tsüklimuutuja != 0);
    tsüklimuutuja = ruuduSuurus;
    do
    {
        Console.WriteLine(üksrida);
        tsüklimuutuja -= 1;

    } while (tsüklimuutuja != 0);
}


string[] konsoolid = { "ps1", "nes", "n64" };

List<string> mängud = new List<string>();

//foreach (string konsool in konsoolid)
//{
//    Console.WriteLine(konsool);
//}

//for (int i = 0; i < konsoolid.Length; i++)
//{
//    Console.WriteLine(konsoolid[i]);
//}

string currentEntry = "";

while (currentEntry == "")
{
    Console.WriteLine("Sisesta mäng, või kirjuta \"ei taha\" kui soovid esitlust lõpetada");
    currentEntry = Console.ReadLine();
    if (currentEntry == "ei taha")
    {
        break;
    }
    mängud.Add(currentEntry);
    currentEntry = "";
}
foreach (var mäng in mängud)
{
    Console.WriteLine(mäng);
}
//kasutades ühte muud tsüklit ja/või ainult foreachi, küsi kasutajalt, tema lemmik värve
//kui kasuataja sisestab ei oska öelda, kuva konsoolil, musta tekstiga ja lemmikvärvi taustavärviga,
// igal real üks tema lemmikvärvidest.

Console.WriteLine("Mis on sinu lemmikvärvid? Sisesta palun ükshaaval \nKui rohkem värve ei ole \"rohkem pole\"");
List<string> kasutajaVärvid = new List<string>();

string sisestus = "";
do
{
    Console.WriteLine("Sisesta 1 värv korraga:");
    sisestus = Console.ReadLine();
    if (sisestus != "rohkem pole")
    {
        kasutajaVärvid.Add(sisestus);
    }

} while (sisestus != "rohkem pole");

foreach (var värv in kasutajaVärvid)
{
    switch (värv)
    {
        case "punane":
            Console.BackgroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("p u n a n e");
            break;
        case "oranz":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("kahjuks ei ole oranz saadaval");
            break;
        case "kollane":
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" k o l l a n e");
            break;
        case "roheline":
            Console.BackgroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" r o h e l i n e");
            break;
        case "helesinine":
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" h e l e s i n i n e");
            break;
        case "sinine":
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" s i n i n e");
            break;
        case "tumesinine":
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" t u m e s i n i n e ");
            break;
        case "lilla":
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" l i l l a");
            break;
        case "roosa":
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" r o o s a");
            break;
        case "must":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" m u s t");
            break;
        case "valge":
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" v a l g e");
            break;
        case "hall":
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" h a l l");
            break;
        default:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Sellist värvi ei tunne {värv}");
            break;
    }
}
