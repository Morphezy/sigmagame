using System;
using System.Linq;
namespace Sigma {


    class Sigma
    {
        static void Main()
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Malyok dzhanym = new Malyok();
            Console.WriteLine($"Привет, {dzhanym.Neym}, хочешь проебать все свои деньги? Сейчас у тебя {dzhanym.Dengi} йубйов");

            const int MAX = 10;
            int oshibochki = 0;
            bool isActive = true;
            int genednum = numGen(MAX);
            
            while ( isActive){
                int inp;
                try
                {
                    Console.WriteLine("Widi 4islo");
                   inp = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                   Console.WriteLine("AUOOO DAUBAYOB, CHISLO VEDI");
                    continue;
                }
                    
                    isActive = Sopostawlenye(inp, genednum, ref oshibochki);
            }
        }

        static bool Sopostawlenye(int a, int b, ref int counter )
        {
            if (a == b)
            {
                counter = 0;
                Console.WriteLine("TI UGADAL URAAAAAA");
                return false;

            }
            else {
                Console.WriteLine("ti ne ugadal... shnyuka...");
                counter += 1;
                if(counter >= 3)
                {
                    Console.WriteLine("ZAEBAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAL, BAN NABUY");
                    return false; 
                }  
            }
            return true;
        }

        static int numGen(int maxran)
            {
                Random random = new Random();
                int generatedNum = random.Next(1, maxran+1);

                return generatedNum;
            }

    }
    class Malyok
    {
        public string Neym;
        public int Dengi;

        public Malyok() : this("Жаным", 100) { }

        public Malyok(string neym, int dengi) { 
            Neym = neym;
            Dengi = dengi;
        }
        
       


















    }

}