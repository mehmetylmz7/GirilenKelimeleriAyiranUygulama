using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenKelimeleriAyiranUygulama
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kac kelimeyi ayırmak ıstıyorsunuz..");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("lutfen {0}. kelimeyi giriniz.. ", i + 1);
                string s = Console.ReadLine();
                LetsReview(s);

            }

        }

        static void LetsReview(string s)
        {
            string evenStr = "";
            string oddStr = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenStr += s[i];

                }
                else
                {
                    oddStr += s[i];

                }
            }


            Console.WriteLine(evenStr + " " + oddStr);

            Console.ReadLine();

        }



    }
}
