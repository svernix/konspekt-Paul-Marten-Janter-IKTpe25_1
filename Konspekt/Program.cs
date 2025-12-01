
//1. tuvasta sisu võrdlus tühja stringiga, string andmetüüp
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Reflection;

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

// HEAD

Console.WriteLine("Tere, kas sa tahad ära mõõta kasti või tünni");
string valik = Console.ReadLine();
if (valik == "tünn")
{
    Console.WriteLine("kas sa tead põhj araadiust (r) või põhja läbimõõtu (d)");
    string rvõid = Console.ReadLine();
    Console.WriteLine("Sisesta see mõõt");
    double mõõt = double.Parse(Console.ReadLine());
    if (rvõid == "d")
    {
        mõõt = mõõt / 2;
    }
    else if (rvõid != "r")
    {
        Console.WriteLine("Sisend ei ole tuntav");
    }
    Console.WriteLine("Kui kõrge on su tünn");
    int kõrgus = int.Parse(Console.ReadLine());
    Console.WriteLine("Kui paks on tünni kaas?");
    int kaanepaksus = int.Parse(Console.ReadLine());
    double tünnipõhiS = Math.PI * (mõõt * mõõt);
    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
    double küljepindala = tünnipõhiS * kõrgus;
    double kogupindala = (tünnipõhiS * 2) + küljepindala;
    Console.WriteLine($"Sinu tünn mahutab {mahtV} \nTünni küljepindala on {küljepindala} \nkogupindala aga on {kogupindala}");


}
else if (valik == "kast")
{
    Console.WriteLine("Kas su kast on kuubik(k) või risttahukas(r)");
    string kastitüüp = Console.ReadLine();
    if (kastitüüp == "k")
    {
        Console.WriteLine("Sisesta kasti külgpikkus");
        double külgA = double.Parse(Console.ReadLine());
        double kuubik = Math.Pow(külgA, 3);
        double küljepindala = (külgA * külgA) * 6;
        double diagonaal = külgA * Math.Sqrt(3);
        Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nkuubiku küljepindala on {küljepindala} \ndiagonaal aga on {diagonaal}");

    }
    else if (kastitüüp == "r")
    {
        Console.WriteLine("Mis on sinu kasti kõige pikkim külg");
        double pikkülg = double.Parse(Console.ReadLine());
        Console.WriteLine("Mis on sinu kasti kõige lühikekülg");
        double lühikekülg = double.Parse(Console.ReadLine());
        Console.WriteLine("Mis on sinu kasti kõrgus");
        double kõrgus = double.Parse(Console.ReadLine());
        double V = pikkülg * lühikekülg * kõrgus;
        double kogupindala = 2 * ((pikkülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkülg * kõrgus));
        double diagonaal = Math.Sqrt((pikkülg * pikkülg) + (lühikekülg * lühikekülg) + (kõrgus * kõrgus));
        Console.WriteLine($"Sinu kast mahutab {V} \nkasti küljepindala on {kogupindala} \ndiagonaal aga on {diagonaal}");

    }
}

Console.WriteLine("banana");
// Console -> adreseeritav moodul või objekti (Roheline)
// . -> midagi selle objekti seest, saamine windowsi kasuta pathis oleva slashiga
// - komakohtadega andmetüüpidel komakoha tähistamine
// WriteLine adreseeritav funktsioon objektist Console
// () -> sulupaar mis omab endas funktsioonile vajalikku infot
//   - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisisõn "ifi parameeter"
//   - kasutatakse ka matemaatilistes tehedes
// [] -> tähistava massiive
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
// - saab ka kasutada teksti sees muutujate kuvamiseks
// -> taane aitab aredajal aru saada millise koodiploki sees, miski on. Vajalik kompilaatorile.
// "banana" -> parameeter mis antakse funkstioonlie WriteLine töötlemiseks kaasa.
// ; -> iga koodilause lõppeb komakooloniga

int muutuja = 3;
// int -> muutuja nime ees olev andmetüübi kirjeldus, see näitab ära mis tüüpi andmed selle muutuja sees on
// = -> võrdlusmärk omistab sellele muutujale mingisuguse väärtuse
// 3 -> väärtus mis sellele muutujale omistatakse

//võimalikud andmetüübid
int a = 1; //täisarv
decimal b = 2.0M; //kümnendsüsteemis olev komakohaga arv
float c = 3.0f; //kümnendsüsteemis olev ujukomaga arv
double d = 4.0d; //kümnendsüsteemis olev komakohaga arv, sarnane decimaliga
char c1 = 'a'; //üksainus täht või tähemärk
string s = "tekst"; // iniloetaval kujul tekst
var x = "abc"; //ebamäärase tüübiga kohalik muutuja
var y = 123;
const int z = 3; //konstant-tüüpi muutujaid ei saa muuta, need on read-only
//void - void on andmetüüp, mida muutujatele anda ei saa. void on andmetüüp, mida kasutatakse meetodite jms
//signatuurides, et näidata tagastav andmetüübi puudumist. Tegemist on - sõna ostsese mõttes - mitte millegagi

//võimalikud komposiitandmetüübid
// [] -> Massiv on komosiitandmetüüp, mille sees saab olla mitu samat
//tüüpi lihtandmeid. Massiv tähistatakse kantsulgudega
//Massive saab olla ükskõik millist lihtandmetüüpi massive
//Massiivi tekitamisel tuleb ära öelda kui pikk või suur see massiiv on
//Massiiv saa olla koostatud ka teistes massiividest
//
// Esimene tekitusviis
int[] arvuMassiiv = new int[3]; //andmetüüp int väjendab et tegu on 
//täisarvutüüpi andmega ja kantsulud väljendavad et tegu ühtlasi ka
//massiiviga. nimeks on "arvuMassiiv" ja võrdusmärgiga, on esimene
//tekitusmoodus öelda et tegu on uue massiiviga kasutades kaitstud sõna
//"new", ja sellele järgneb massiivi pikkuse sätestus "int[3]" see
//tähendab et siin massiivis on 3 elementi, mis on täisarvud

int[] arvuMassiiv2 = [1, 2, 3]; // teine masiivi tekitusviis, kus järjendi
                                //pikkuse sätestamise asemel, pannakse
                                //elemendid kohe sisse järjendi pikkus
                                //tuletatakse elementide arvust
                                // -- massiivi sisemised meetodid:
int hasthismany = arvuMassiiv.Length; //massiivi meetod "Lenght" mille me
                                     //saame kasutusele võtta punkti abil,
                                     //loendab kokku, mitu elementi
                                     //järjendis parasjagu on.

// 2. loend:
//List <T> -> Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht-ja komposiitandmed.
//Loed-tüüpi andmeid tähistatakse
//Täiendava andmetüübikirjeldusega "List" mille järel noolsulgudesse asetatakse mis tüüpi andmed loendis on.
//Loendi tekitamisel, erinevalt massiivist, ei pea ütlema kui pikk loend on. Loendisse saab dünamiliselt
//elemente juurde juurde lisada, ehk tema pikkus ei ole fikseeritud.
//Sarnaselt massiiviga, saab loend omada endas, teisi loendeid.
   //Esimene teikitusviis:
List<int> arvutNimekiri = new List<int>(); //Amdmetüübi kirjeldus "List<>" näitab et tegu on loendiga, List
//noolsulgude vahel on loendis olevate andmete andmetüüp. muutuja nimeks on "arvutiNimekiri". Omistame sellesse
//muutujasse kaitstud sõna "new" abil uue tühjatäisarvuloendi sätestusega "List<int>()".
   //Teine tekikitusviis:
List<int> arvuNimekiri2 = new List<int>() {1,2,3}; //teine loendi tekitusviis, muutuja instantsieerimine
                                                   //võrdusmärgi ees on sama nagu esimesel, juurde tuleb ainult võrdusmärgi taga olevale sätestusele loogelised
                                                   //sulud kiis juva sinna asetatud elementidega. Enam ei ole tegu tühja nimekirjaga, vaid loendiga kus on kolm 
                                                   //elementi
   //Kolmas tekikitusviis:
List<int> arvuNimekiri3 = new List<int>(3); // kolmas loendi tekitusviis kus muutuja instantseerimine jääb
//samaks, aga, tavaliste sulgude vahel, sarnaselt massiiviga, saame anda loendile esialgse suuruse. Loend
//ise ei oma veel andmeid, aga loendis on kolm tühja elementi. Nimelt, on sätestusel, peale andmetüüpi
//kirjeldavaid noolsulge, paar tavalise sulge, mille sisse saab parameetrina panna loendi pikkus. ()

// -- Loendi sisemised meetotid
arvuNimekiri3.Add(67); // Loendi meetod "Add()" lisab enne punkti olevale järjendile uue elemendi, element mida
//lisada on Add meetodi sulgude vahel. Elemnti saab lisada otse (amtud juhul "67") või muutujana - näiteks
//...Add(arv)
int loendiPikkus = arvuNimekiri3.Count(); //loendi meetod "Count()" loeb kokku mitu elementi järjendis on,
//meetod tagastab täisarvu mis vastab elementide kogusele.
bool KasSeeArvOn = arvuNimekiri3.Contains(3); // Loendi meetod "Contains()" otsib kogu järjendi seest elementi,
//mis vastab sulgude vahel olevate parameetrile, tagastab kas true või false - on leitud või ei ole. Tegemist
//on põhimõtteliselt foreach tsükliga, mis otsib kindlat parameetrit, töödeldest läbi, loendi
arvuNimekiri3.Remove(4); //Loendi meetod "Reomve()" eemaldab enne punkti olevast loendis, kindlal asukohal
//oleval elemendi. Sulgude vahel on parameetriks eemaldatav elemndi asukohajärjekorranumber.


//põhilised matemaatilised tehted
int liitimine = 1 + 1; //liitmine, kaks arvu kokku
int lahutamine = 1 - 1; // lahutad, esimese arvu teisest arvust maha
int korrutamine = 1 * 1; //korrutamine, korrutad essa arvu teisega
int jagamine = 1 / 1; // jagamine, jagad essa arvu teisega
double astendamine = Math.Pow(2, 2); // astendamine, esimene arv astendakse teisega
double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse

/* Matemaatilised tehted moodulist math */

Math.Round(d); //Moodulist "Math" kutsutakse punkt aabil esile meetod "Round". Sulgude vahel on ümardatav arv.
//Round ümardab sulgude vahel olevas muutujas asetseva arvu, vastavalt komakohtade parameetrile.
//Vaikeväärtusena lähima täisarvuni. 0-4 on allpool, 5-9 on ülespoole.
double newpi = Math.PI; //Moodulist "Math" kutsutakse punkti abil esile kaitstud väärtus, PI mis väljendab
                        //matemaatilist pi-d ning saab kasutada kui tavalist arv.
double astendus = Math.Pow(2, 2); //Moodulist "Math" kutsutakse punkti abil esile meetod "Pow" (power).
                                  //Sulgude vahel on kaks parameetrit, esime on neist Astendatav ja teine
                                  //astendaja. antud juhul oleks vastuseks 16.


int arv = 0; //sobib
string sõna = "abc";
string sisend_string = "abc";
// string string = "abc" ei sobi järgnevad sõnad;

//muutuja nimeks ei sobi järgnevad sõnad;
//abstract, as, base, bool, break, byte, case,
//catch, char, checked, class, const, continue, decimal,
//default, delgate, do, double, else, enum, event,
//explict, extern, false, finnaly, fixed, float, for
//foreach, goto, if, implicit, in, int,
// interface, internal, is, lock, long, namespace, new,
//null, object, operator, out, override, params,
//private, protected, public, readonly, ref , return, sybte,
//sealed, short, sizeof, stacklloc, staticm string, structm
//switch, this, throwm true, try, typoof, uint,
//ulong, uncheckd, unsafem ushort, using , virtual, void
//volatile, while.




//Ülesanne, kasutada süntaksiseletust, kirjelda komnetariga iga koodirida

int arv3 = 0;
//See on esimene arv, muutuja nime ees olev andmetüüp, see näitab ära mis tüüpi andmed selle muutuja sees on
// = -> võrdlusmärk omistab sellele muutujale mingisuguse väärtuse
// 0 -> väärtus mis sellele muutujale omistatakse

int arv4 = 0;
//See on teine arv, muutuja nime ees olev andmetüüp, see näitab ära mis tüüpi andmed selle muutuja sees on
// = -> võrdlusmärk omistab sellele muutujale mingisuguse väärtuse
// 0 -> väärtus mis sellele muutujale omistatakse

Console.WriteLine("Tere, palun sisesta esimene arv: ");
//Adresseerimine modulit "Console", punkti abil ütleme et kasutame 
//funktsiooni WriteLine, et kasutajale öelda sõnum mis asub funktsiooni 
//taga olevate sulhude vahel, antud rida lõppeb lauselõpumärgiga.

arv1 = int.Parse(Console.ReadLine());
// int -> muutuja nime ees olev andmetüübi kirjeldus,
//see näitab ära mis tüüpi andmed selle muutuja sees on.
// = -> võrdlusmärk omistab sellele muutujale mingisuguse väärtuse.
// 1 -> väärtus mis sellele muutujale omistatakse.
//Lause lõppeb lauselõpumärgiga.

Console.WriteLine("Tere, palun sisesta teine arv: ");
//Adresseerimine modulit "Console", punkti abil ütleme et kasutame 
//funktsiooni WriteLine, et kasutajale öelda sõnum mis asub funktsiooni 
//taga olevate sulhude vahel, antud rida lõppeb lauselõpumärgiga.

arv2 = int.Parse(Console.ReadLine());
// int -> muutuja nime ees olev andmetüübi kirjeldus,
//see näitab ära mis tüüpi andmed selle muutuja sees on
// = -> võrdlusmärk omistab sellele muutujale mingisuguse väärtuse
// 1 -> väärtus mis sellele muutujale omistatakse
//Lause lõppeb lauselõpumärgiga.

Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
//Adresseerimine modulit "Console", punkti abil ütleme et kasutame 
//funktsiooni WriteLine, et kasutajale öelda sõnum mis asub funktsiooni 
//taga olevate sulhude vahel, antud rida lõppeb lauselõpumärgiga.

string tehtetyyp = Console.ReadLine();
// Tekitame muutuja "tehtetüüp", mille ette paneme andmetüübiks string, ehk
// ütleme et seal on tekst, ning võrdusmärgi abil omistame talle
// konsooli rea pealt loetu info, mis saame kasutades "Console" mooduli,
// ReadLine() funktsiooni. Lause lõppeb lauselõpumärgiga ; .

int tulemus = 0;
//instasieerime muutuja tulemus, mille andmetüübiks on int, ja omistame
//talle esi algu väärtuse 0. Lause lõpp lõpeb lauselõpumärgiga.

if (tehtetüüp == "+" /* tingimus siia*/)
//if->kood mis käivitub siis kui on tingimus õige.
//==-> kontrolib kas pool A on sama  mis pool B.
// teeme tingimuslause if, ning sulgude vahele kirjutame tingumuseks
//kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "+"
{
    tulemus = arv1 + arv2;
    //liitmine, kaks arvu kokku
}
//peale tingimusi on koodiplokk{} loogeliste sulgude vahel. koodiplokk
//sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd
//väärtuse liites kokku muutuja arv1 ja muutuja arv2. Lause lõppeb
//lauselõpumärrgiga sulgude sees. ei

if (tehtetüüp == "-" /* tingimus siia*/)
//if->kood mis käivitub siis kui on tingimus õige.
//==-> kontrolib kas pool A on sama  mis pool B.
// teeme tingimuslause if, ning sulgude vahele kirjutame tingumuseks
//kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "-"
{
    
    tulemus = arv1 - arv2;
    // lahutad, esimese arvu teisest arvust maha
}
//peale tingimusi on koodiplokk{} loogeliste sulgude vahel. koodiplokk
//sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd
//väärtuse liites kokku muutuja arv1 ja muutuja arv2. Lause lõppeb
//lauselõpumärrgiga sulgude sees. ei

if (tehtetüüp == "*" /* tingimus siia*/)
//if->kood mis käivitub siis kui on tingimus õige.
//==-> kontrolib kas pool A on sama  mis pool B.
// teeme tingimuslause if, ning sulgude vahele kirjutame tingumuseks
//kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "*"
   
{
        
    tulemus = arv1 * arv2;
    //korrutamine, korrutad essa arvu teisega
}
//peale tingimusi on koodiplokk{} loogeliste sulgude vahel. koodiplokk
//sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd
//väärtuse liites kokku muutuja arv1 ja muutuja arv2. Lause lõppeb
//lauselõpumärrgiga sulgude sees. ei

if (tehtetüüp == "/" /* tingimus siia*/)
{
//if->kood mis käivitub siis kui on tingimus õige.
//==-> kontrolib kas pool A on sama  mis pool B.
// teeme tingimuslause if, ning sulgude vahele kirjutame tingumuseks
//kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "/"
        
            
    tulemus = arv1 / arv2;
    // jagamine, jagad essa arvu teisega
}
//peale tingimusi on koodiplokk{} loogeliste sulgude vahel. koodiplokk
//sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd
//väärtuse liites kokku muutuja arv1 ja muutuja arv2. Lause lõppeb
//lauselõpumärrgiga sulgude sees. ei

if (tehtetüüp == "^")
//teeme tingimus lause if, ning sulgude vahel kirjutame tingimuseks
//kontrolli, kas muutuja "tehtetüüp" sisu on sama kui sõne "^"
{
    tulemus = (int)Math.Pow(arv1, arv2);
}
//peale tingimusi on koodiplokk{} loogeliste sulgude vahel. koodiplokk
//sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd
//väärtuse kasutades moodulist "Math" punkti abil funktsiooni "Pow()",
//selle sees on arv1 astendatavana esimene parameeter, ning arv2
//astendajana teine parameeter.
//Funktsiooni ees on kiirtesisendus kus funktsiooni väljund tesiendatakse
//(int) abil. Lause lõppeb lauselõpumärrgiga.

Console.WriteLine($"Tehte tulemus: {tulemus}");
//Adresseerimine modulit "Console", punkti abil ütleme et kasutame 
//funktsiooni WriteLine, et kasutajale öelda sõnum mis asub funktsiooni 
//taga olevate sulhude vahel, antud rida lõppeb lauselõpumärgiga.
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.




Console.WriteLine("Sisesta ostusumma");
// Adresseerimine modulit "Console", punkti abil ütleme et kasutame 
//funktsiooni WriteLine, et kasutajale öelda sõnum mis asub funktsiooni 
//taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.

double ostusumma = double.Parse(Console.ReadLine());
// Tekitame muutuja "ostusumma", mille ette paneme andmetüübiks double, ehk
// ütleme et seal on tekst, ning võrdusmärgi abil omistame talle
// konsooli rea pealt loetu info, mis saame kasutades "Console" mooduli,
// ReadLine() funktsiooni. Lause lõppeb lauselõpumärgiga ; .
if (ostusumma > 100)
//teeme tingimus lause if, ning sulgude vahel kirjutame tingimuseks
//kontrolli, kas ostusumma on suurem kui 100
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
{
    Console.WriteLine("Saad 20% allahindliust!");
    // Adresseerimine modulit "Console", punkti abil ütleme et kasutame 
    //funktsiooni WriteLine, et kasutajale öelda sõnum mis asub funktsiooni 
    //taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
}
else if (ostusumma < 101 && ostusumma > 50)
//teeme tingimus lause if, ning sulgude vahel kirjutame tingimuseks
//kontrolli, kas ostusumma on väiksem kui 101 ja suurem kui 50
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
{
    Console.WriteLine("Saad 10% allahindlust");
    // Adresseerimine modulit "Console", punkti abil ütleme et kasutame 
    //funktsiooni WriteLine, et kasutajale öelda sõnum mis asub funktsiooni 
    //taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
}
else if (ostusumma < 51 && ostusumma > 20)
//teeme tingimus lause if, ning sulgude vahel kirjutame tingimuseks
//kontrolli, kas ostusumma on väiksem kui 51 ja suurem kui 20
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
{
    Console.WriteLine("Saad 5% allahindlust");
    // Adresseerimine modulit "Console", punkti abil ütleme et kasutame 
    //funktsiooni WriteLine, et kasutajale öelda sõnum mis asub funktsiooni 
    //taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
}
else if (ostusumma > 21)
//teeme tingimus lause if, ning sulgude vahel kirjutame tingimuseks
//kontrolli, kas ostusumma on suurem kui 21
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
{
    Console.WriteLine("Allahindlust ei saa");
    // Adresseerimine modulit "Console", punkti abil ütleme et kasutame 
    //funktsiooni WriteLine, et kasutajale öelda sõnum mis asub funktsiooni 
    //taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
}
else if (ostusumma < 1)
//teeme tingimus lause if, ning sulgude vahel kirjutame tingimuseks
//kontrolli, kas ostusumma on väiksem kui 1
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
{
    Console.WriteLine("Sisestatud vigane arv");
    // Adresseerimine modulit "Console", punkti abil ütleme et kasutame 
    //funktsiooni WriteLine, et kasutajale öelda sõnum mis asub funktsiooni 
    //taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
}



//string kasutajanimi = "";
//do
//{
//    Console.WriteLine("Palun sisesta oma kasutajanimi");
//    kasutajanimi = Console.ReadLine();
//}
//while (kasutajanimi != "user1");
//if (kasutajanimi == "user1")
//{
//    int ruuduSuurus = 0;

//    do
//    {
//        Console.WriteLine("Kui suurt ruutu tahad?");
//        ruuduSuurus = int.Parse(Console.ReadLine());
//    } while (ruuduSuurus < 0 && ruuduSuurus > 20);
//    char reaKujund = 'a';
//    string üksRida = "";
//    int tsükliMuutuja = ruuduSuurus;
//    do
//    {
//        üksRida += 'a' + reaKujund;
//        tsükliMuutuja -= 1;
//    } while (tsükliMuutuja != 0);
//    tsükliMuutuja = ruuduSuurus;
//    do
//    {
//        Console.WriteLine(üksRida);
//        tsükliMuutuja -= 1;
//    } while (tsükliMuutuja != 0);
//}
/* tingimus osad */
if (true) { } //kaitstud sõna if kutsub esile tingimuslause, mille tingimus on
              //sulgude vahel ning millele järgneb koodiplokk tingimuse
              //täitumisel teostava koodiga
else if (true) { } //kaitstud sõnad else ja if (else if) kutsuvad esile
                   //sekundaarse tingimuslause, mille tingimus on samamoodi
                   //sulgude vahel, ning millele peab eelnema alati if või else
                   //if. Tingimuse täitumisel ja eelneva tingimuse mittetäittumisel
                   //teostatakse koodiploki ees olev kood
else { } //kaitsutud sõna else  kutsub esile järeltingimuse, millele peab eelnema
         //kas if või else if, ning mille koodiploki sisu täidetakse kõikide if
         //ja else if sees olevate tingimuste läbikukumistel
int option = 3; // -------
switch (option) //"switchi" on kaitsutud sõna alternatiivse
                //tingimuskontrolli jaoks mida saab if else-if
                // asemel kasutada. Sulgude vahele käib muutuja nimi,
                //mille põhjal tingimuslik ümberlülitus toimub. Siin
                //sulgude vahel ei ole tingimus ise, vaid kõigest
                //kontrollitav muutuja, või omakorda sulgude
                //vahel muu tingimus. Pärast lülitusvalikut tuleb
                //koodiplokk. 
                
    case 1:  //koodiploki on erinevaid juhtumid. Juhtumit
             //kontrollitakse kaitsud süna "case" abil. Antud juhul
             //kontrollitakse, kas muutujas on väärtus 1, millele
             //järgneb kolon ";"
             //peale koolonit kirjeldatakse tehtav tegevus
        break; //ja kui tegevus on täidetud, väljutakse kogu switchist
               //tegevusest kaitstud sõna "break"-iga. Peale "break"-i
               //on lauselõppumärk ";"
    case 2:
        break;
    case 3:
        break;
              //juthtumeid võib olla mitmeid antud juhul on neid kolm
              //kindlalt, ja üks mida tehakse igal muul juhul.
    default: //kaitstud sõna "default" avab juhtumi kui muutujas
             //ei ole mitte ühtegi muud "case" juhtumi tingimust.
             // ka default lõppeb sõnaga
        break;
}

/* loogilised tehted*/
// &&  -> loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab
//positiivse vastuse (true) juhul kui mõlemal pool && märki olevad tingimused on
//täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
// || -> loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab
//positiivse vastuse (true) siis kui vähemalt üks tingimus on täidetud. Negatiivse
//vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
// ! -> loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks.
//Tulemus mis muidu tagastakse true, hüiumärgi puhul tagastab false, ja vastupidi
// -  tulemus mis muidu tagastab false, hüiumärgi puhul tagastab true.

/* võrdlusoperatoorid */
// == -> on võrdne. Võrdlusmärkide ühel pool olev objekt peab vaatama täpselt oma
//olemuselt. Võrdumärkide teisel pool oleva objektiga. ei ole sama nagu üks võrdusmärgi.
//üks võrdusmärk omistab, kaks võrdleb.
// != -> ei ole võrdne. Võrdlusmärgi ühel pool olev objekti *EI TOHI* olla samal
//kujul nagu teisel pool oleva objektiga. Võrdlusoperaator on kombinatsioon "on võrdne"
//operaatorist, ja loogilisest tehest "not".
// > -> on suurem kui. Märgist vasakul pool olev objekt peaks olema suurem, kui
//paremal pool olevobjekt.
// < -> on väiksem kui. Märgist vasakul pool olev objekt peaks olema väiksem, kui
//paremal pool olevobjekt.
// >= -> on suurem kui või võrdne kui. Märgist vasakul pool olev objekt peaks
//olema vähemalt võrnde või suurem kui paremal pool olev objekti. Operaator on
//kombinatsiooni "on võrdne" ja "on suurem kui" operatoritest.
// <= -> on väiksem kui või võrdne kui. Märgist vasakul poole olev objekt peaks
// peaks olema vähemalt võrdne või väiksem kui paremal pool olev objekt. Operaator
//on kombinatsiooni "on võrdne" ja "on väiksem kui" operatooritest.

/* Omistusoperaatorid ja kiirtehted */
int arv = 1;// = -> ükski võrdusmärk omistab muutujale väärtuse.
arv += 1;   // += -> võrdumärk mille ees on pluss, automaatselt liidab muutujale
            // otsa võrdusmärgi teisel pool oleva arvu. asendab tehete
            // "arv = arv + 1". on kombinatsioon matemaaatilise tehetest "+"
            //ja omsitamisest ("=")
            
int arv = 1;// = -> ükski võrdusmärk omistab muutujale väärtuse.
arv -= 1;   // += -> võrdumärk mille ees on miinus, automaatselt lauhtab muutujast
            // maha võrdusmärgi teisel pool oleva väärtuse. asendab tehete
            // "arv = arv - 1". on kombinatsioon matemaaatilise tehetest "-"
            //ja omsitamisest ("=")
            
int arv = 1;// = -> ükski võrdusmärk omistab muutujale väärtuse.
arv *= 1;   // += -> võrdumärk mille ees on korrutusmärk, automaatselt korrutab muutuja
            // sisu võrdusmärgi teisel pool oleva arvu kordi. asendab tehete
            // "arv = arv * 1". on kombinatsioon matemaaatilise tehetest "*"
            //ja omsitamisest ("=")
            
int arv = 1;// = -> ükski võrdusmärk omistab muutujale väärtuse.
arv /= 1;   // += -> võrdumärk mille ees on jagamismärk /. automaatselt jagab muutuja
            // sisu võrdusmärgi teisel pool oleva arvu osadeks. asendab tehete
            // "arv = arv / 1". on kombinatsioon matemaaatilise tehetest "/"
            //ja omsitamisest ("=")
arv++;      //++ -> on spetsiifiliselt ühe juurde liitmiseks lühivariant.
arv--;      //-- -> onspetsiifiliselt phe maha lahutamiseks lühivariant.

/* Tsüklid */
// 1. do-while
int dw = 0;
do // "do" on kaitsutud sõna, mis alustab do-while tsüklit pärast mida on
{ //koodiplokk, ning ütleb et tee seda koodi
    dw++;
} while (dw != 5); //niikaua kuni while järel olevate silgude vahel olev tingimus
                //on täidetud
                // 2. While

int i = 1; //tsüklimuutuja mis kontrollib "while" tsükli tööd
while (i < 5) //"While" on kaitstud sõna mis alustab while tsükli
              //varianti, ilma "do"-ta, ning vajab tihtipeale
              //välist tsüklimuutujat antud juhul on selleks i.
              //Tsükli tingimus, mis peaöe "while" sõna on, sulgude
              //vahel, kontrollib tingimuse abil, selle muutuja
              //olekut. Siin kontrollitakse, et tsükkel ei oleks suurem
              // kui 5, kui ta on, siis tsükli töö lõpeb
           
{
    //koodiplokk kus midagi tehakse
    i++; //ning seejärel muudetakse tsüklimuutuja "i" olekut, antud
        //juhul liidetaks 1 juurde

}

// 3. for

int kogus = 6; //muutuja mida tsükkel kasutab töötlemiseks mingisugusel kujul
for (int k = 0; k < kogus; k++) //kaitstud sõna "for" alustab for tsüklit
                                //, pärast mida on sulud,mlle vahel on
                                //kõik tsükli töö jaoks vajalik info.
                                //esimene parameeter tekitab tsükli töö
                                //jaoks muutuja "int k = 0;", teine
                                //parameeter on tingimuslause mis kontrollib
                                //tingimuse täitumist "k < kogus;" ning
                                //kolmasinkrementeerib tekitatud muutuja
                                //"k++;". pane tähele et iga sulgude vahel
                                //oleva osa järel on lauselõpumäek. Tsükli
                                //tööd kontrolliv tingimuslause koosneb
                                //kolmest reast, mitte ühest, nagu while
                                //või do-while puhul. koodiplokk kus tehakse
                                //mingi tegevus. antud juhul on tegevuseks
                                //muutuja "k" arvu väljakuvamine
{
    Console.WriteLine(k);
}

// 4 foreach
int[] arvuloend = { 3, 89, 123412, 7, 67 }; //massiiv mida foreach tsükkel kastuab, või töötleb mingil kujul.
foreach (var arvInloend in arvuloend) //kaitstud sõna foreach alustab foreach tsükli. Pärast mida on suletud,
                                      //mitte vahel tekitatakse ajutine muutuja andmetüübiga "var" tööeldav
                                      //andmekogumi üksikelemendi kohta, ning var "arvInloend" muutuja hoiab
                                      //endas just peale sõna "in" oleva andmekogumi elemente jätkub ehk tsükli
                                      //töö  käib iga üksiku elemendi kohta andmekogumis. Tsüklil ei ole vaja
                                      //tsüklimuutujat, kuna talle on sisse ehitatud vaikimisi elemendi
                                      //järjestuse jälgimine. Niipalju kui andmeid on , ongi see , mittu korda
                                      //tsükkel käivitatakse.
{                                     // {} koodiplokk kus tehtakse mingi tegevus 
    Console.WriteLine(arvInloend);    // antud juhul huvatakse välja ajutine mutuja, mille sees on loendi element.
}

/* Castimine */

//Castimine on viis, kuidas ühest andmetüübist teist saada. Castimist on kahte eri liiki, automaatne ja
//manuaalne. Automaatne castimine toimub siis, kui teisendatakse väiksemast andmetüübist, suuremasse.
//Manuaalne castimine toimub siis, kui tahetatakse saada suuremast andmetüübist väiksemat.
//Castitakse nii, et teisendatava muutuja ette, pannakse sulud kos soovitud andmetüübiga.

double newData1 = 2.22d; //tekitame, või on olemas, suure mahuga andmed muutjas newData1. Tegu on double andmega
float data1Float = (float)newData1; // "(float)" teisendab double tüüpi andmed float tüüpi andmeteks.
long data1Long = (long)newData1; //"(long)" teisendab double tüüpi andmed long tüüpi andmeks
int data1Int = (int)newData1; //"(int)" teisendab double tüüpi andmed int tüüpi andmeks
char data1Char = (char)newData1; //"(char)" teisendab double tüüpi andmed char tüüpi andmeks

/* meetodid */

//Meetodid on välja kutsutavad koodijupid. Meetodi teostavad tavaliselt mingeid funktsioone või tegevusi.
//Meetodid lasevad programmeerijal taaskasutada oma eelnevat kirjutatud koodi - write once use many times
//Meetodeid on kahte liiki - ühed, mis tagastavad andmeid mingisugune töö tulemina, ja teised, mis ei tagasta
//midagi, kuid omavad siiski mingit tegevust

//Meetodi signatuur:
//Meetodi signatuur koosneb mitmest kindlalt äramääratud omaduses, nendeks on:
//Juurdepääsu modifikaator mis ütleb ära, kus ja kuidas sellele meetodile juurde pääseda saab
//Public - meetod on avalik ja kättesaadav ka teistes klassides peale selle, kus meetod ise asub
//Private - meetod on saadaval ainult selles klassis kus meetod ise asub
//Protected - meetod on saadaval ainult selles klassis, kus meetod ise asub ja kõikides  klassides millel on 
//päritlus sellele klassile
//Internal - meetod on saadaval ainult selles klassis ja ainult selles failis
// - võib olla ka pandud static - meetod kuulub selle klassi juurde
// - tagastustüüp on modifikaator mis ütleb ära, mis tüüpi andmeid meetod tagasi annab kutsumise asukohta.
//Andmetüüo mida tagastada võib olla ükskõik milline liht või kombinikatsioonitüüp, aga kui meetod ei tagasta
//üldse andmeid, pannakse selle asemel andmetüüpiks "void". Kui meetodil on tagastustüüp mis on midagi muud kui
//void, on meetodi sees, iga toimiva koodisõna lõpus, kaitstud sõna "return", return ütleb et just see on vaja
//väljakutseasukohta tagastada, ning peale returni on muutuja nimi tagastatava infoga. Peale return lauset ei
//teosta mitte ühtegi muud meetodi sisu. Return toiming ka kui breakina, lõpetades siis aktiivse meetodi töö


public static void UusMeetod() //meetodi signatuur, mis omab juurdepääsuufukaatorit "public", "static" ütleb
                              //et ta on selle klassi oma, tagastustüüp "void" ütleb et andmeid meie meetod ei
                              //tagasta ning pärast meetodi omadusi on meetodi nimi "UusMeetod" peale mida on
                              //sulud, kus parameetrid ei ole.
                              //pärast signatuur on koodiplokk meetodi koodiga {}
                              //Antud juhul meetod kuva konsooli sõnumi.
{
    Console.WriteLine("Tere");
}
//2. tüüpi meetod - tagastab väärtuse
int[] arvutataavadArvud = new int[](3, 67, 420);
public static int ArvutaKokku(int[] arvud) //Meetod mille signatuuris on juurdepääsumodifikaator public static
                                           //ütleb et meetod kuuluv siia klassi, tagastustüüp "int" ütleb et
                                           //programmis väljakutseasukohta tagastatakse täisarv, peale seda on
                                           //meetodi nimi "ArvutaKokku" ning sulgude vahel ootab meetod
                                           //täisarvumassivi millele pannakse meetodi sees ajutine nimi arvud.
                                           //Peale signatuuri on koodiplokk {} tehtava koodiga.
{
    int summa = 0; //Tekkitatakse täisarvuandmetüüpi muutuja nimega "summa", kuhu esialgu omistatakse arv 8.
    foreach (int i in arvud) //Foreach tsükliga käiakse kõik täisarvumassiivi "arvud" arvud läbi
    {
        summa += i; //ja muutujale summa lisatakse juurde, hetkel käidav element
    }
    return summa; //pärast tsükli töö lõppu tagastatakse "return" käsu abil, muutuja summa sisu
}

