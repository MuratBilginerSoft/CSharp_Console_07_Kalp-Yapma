using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalp_Yapma
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            Console.WriteLine("İsminizi Giriniz");
            isim = Console.ReadLine();
            isim = isim.ToUpper();

            Console.Clear();

            for (int i = 0; i < 5; i++)
                Console.WriteLine();


            Console.WriteLine("                        ♥♥♥♥♥ ♥♥♥♥♥");

            int a = 1;

            for (int i = 17; i <= 19; i=i+2)
            {
                switch (a)

                {
                    case 1: Console.Write("                     "); break;

                    case 2: Console.Write("                    "); break;
                
                }

                for (int j = i; j >0 ; j--)
                {
                    Console.Write("♥");
                }

                Console.WriteLine();

                a++;
            }

            int c = 0;

            for (int b = 19; b >= 1; b=b-2)
            {
                switch (c)
                {
                    case 0: Console.Write("                    "); break;
                    case 1: Console.Write("              MURAT  "); break;

                    case 2: Console.Write("                      "); break;
                    case 3: { b = b - 2; Console.Write("                        "); break; }
                    case 4: { b = b - 2; Console.Write("                          "); break; }
                    case 5: Console.Write("                           "); break;
                    case 6: Console.Write("                            "); break;
                    case 7: Console.Write("                             "); break;
                
                
                }

                for (int j=b ; j>0 ; j--)
                {
                    Console.Write("♥"); 
                }

                if(c==1)
                    Console.Write(" "+isim);

                Console.WriteLine();

                c++;
            }

            Console.WriteLine("                 " + isim+ " SENİ ÇOK SEVİYORUM");

            Console.ReadKey();
        }
    }
}
