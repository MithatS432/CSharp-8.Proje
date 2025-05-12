using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapıları2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen haftanın kaçıncı günü olduğunu girin (1-7): ");
            int gun = int.Parse(Console.ReadLine());

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Bugün: Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Bugün: Salı");
                    break;
                case 3:
                    Console.WriteLine("Bugün: Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Bugün: Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Bugün: Cuma");
                    break;
                case 6:
                    Console.WriteLine("Bugün: Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Bugün: Pazar");
                    break;
                default:
                    Console.WriteLine("Geçersiz gün sayısı!");
                    break;
            }
        }
    }
}
