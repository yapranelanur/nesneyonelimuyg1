using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneyonelimodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç gün ödünç almak istediğinizi giriniz");
            string giris = Console.ReadLine();

            int gun;
            if (int.TryParse(giris, out gun))
            {
             if (gun>=1 && gun<=7)
             {
                    Console.WriteLine("Ödünç süresi geçerlidir.");
             }
                else
                {
                    Console.WriteLine("Hata 1 ile 7 arasında bir sayı giriniz ");
                }

            } 
            else
            {
                Console.WriteLine("Hata lütfen sayısal bir deger giriniz"); 
            }

        }
    }
}
