namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lause = "Tere hommikust, mul on mONSTER otsas, KAS ma võin VEEL magada";
            //Console.WriteLine("lause pikkus on: "+lause.Length);
            //Console.WriteLine("see tekst on capslockis: "+lause.ToUpper());
            //Console.WriteLine("see tekst on väiketähtedes:"+lause.ToLower());
            //Console.WriteLine("Kas lause sõna \"magada\"?:"+lause.ToLower().Contains("magada"));

            //List<string> list = new List<string>() { "auto","kraav","kruus"};
            //string listkoos = "";
            //foreach (var sõne in list)
            //{
            //    listkoos += (" " + sõne.ToUpper() + ",");
            //}
            //Console.WriteLine(listkoos);

            //string eesnimi = "Julius";
            //string perekonnanimi = "Caesar";
            //string amet = "Ohver";
            //string kuuluskeiser = string.Concat(eesnimi, perekonnanimi, amet);
            //Console.WriteLine(kuuluskeiser);

            //string kuuluskeiser2 = $"{eesnimi}, {perekonnanimi}, {amet} ";
            //Console.WriteLine($"{eesnimi}, {perekonnanimi}, {amet} ");
            //Console.WriteLine(kuuluskeiser2);

            string[] sõnadlauses = lause.Split(' ');
            foreach (var sõne in sõnadlauses)
            {
                Console.WriteLine(sõne);
            }
            string ükssõna = "Kuulilennuteetunneliluuk";
            Console.WriteLine(ükssõna[4]);
            Console.WriteLine(ükssõna.IndexOf("i"));

            Console.WriteLine(" \" ");

            Console.WriteLine("a\nb");

            Console.WriteLine("AAAA\tBBBB");
        }
    }
}
