using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotOrtalamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci notunuzu giriniz:");
            int not1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci notunuzu giriniz:");
            int not2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Üçüncü notunuzu giriniz:");
            int not3 = Convert.ToInt32(Console.ReadLine());
            

            int notOrtalamasi = (not1 + not2 + not3) / 3;

            if (notOrtalamasi > 80 && notOrtalamasi <= 100)
            {
                Console.WriteLine("Harf notunuz: A+");
                Console.ReadLine();

            }
            else if (notOrtalamasi >60 && notOrtalamasi <= 80)
            {
                Console.WriteLine("Harf notunuz: A");
                Console.ReadLine();
            }
            else if (notOrtalamasi >40 && notOrtalamasi <= 60)
            {
                Console.WriteLine("Harf notunuz: B+");
                Console.ReadLine();
            }
            else if(notOrtalamasi<=40)
            {
                Console.WriteLine("Harf notunuz: F");
                Console.ReadLine();
            }


        }
    }
}
