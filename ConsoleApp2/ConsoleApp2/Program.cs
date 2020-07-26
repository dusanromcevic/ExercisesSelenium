using System;

namespace ConsoleApp2
{

    public class Osopa
    {
        public string Ime;
        public string Prezime;

        public void PrectaviSe()
        {
            Console.WriteLine("Zovem se " + Ime + " " + Prezime);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Osopa ja = new Osopa();

            ja.Ime = "Dusan";
            ja.Prezime = "Romcevic";
            ja.PrectaviSe();
        }
    }
}
