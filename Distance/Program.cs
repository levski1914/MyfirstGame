using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добре дошли в цветарски магазин ,,Букет,,");
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine(" ||----------------------------------||");
            Console.WriteLine(" ||     Каталог                      ||");
            Console.WriteLine(" ||----------------------------------||");
            Console.WriteLine(" ||     Букет                        ||");
            Console.WriteLine(" ||----------------------------------||");
            Console.WriteLine(" ||     Аранжировки - рязан цвят     ||");
            Console.WriteLine(" ||----------------------------------||");
            Console.WriteLine(" ||     Саксийни цветя               ||");
            Console.WriteLine(" ||----------------------------------||");
            Console.WriteLine(" ||     Свой букет                   ||");
            Console.WriteLine(" ||----------------------------------||");
            Console.WriteLine(" ||     Вина                         ||");
            Console.WriteLine(" ||----------------------------------||");
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            var choose = Console.ReadLine();
            if (choose == "Bouquet" || choose == "bouquet" || choose == "Букет" || choose == "букет")
            {
                Console.WriteLine("****************************************");
                Console.WriteLine("****************************************");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine(" ||                                  ||");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine(" ||                                  ||");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine(" ||                                  ||");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine(" ||                                  ||");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine(" ||                                  ||");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine(" ||                                  ||");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine("****************************************");
                Console.WriteLine("****************************************");
            }


            //----------------------------------VOwn bucketV----------------------------------   
            if (choose == "Свой букет" || choose == "Own bouquet")
            {
                Console.WriteLine("****************************************");
                Console.WriteLine("****************************************");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine(" ||          Хризантеми              ||");
                Console.WriteLine(" || Пролет/Лято цена:2.00лв /на брой ||");
                Console.WriteLine(" || Есен/Зима цена:3.75лв/на брой    ||");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine(" ||         Рози                     ||");
                Console.WriteLine(" || Пролет/Лято цена:4.10лв /на брой ||");
                Console.WriteLine(" || Есен/Зима цена:4.50лв/на брой    ||");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine(" ||         Лалета                   ||");
                Console.WriteLine(" || Пролет/Лято цена:2.50лв /на брой ||");
                Console.WriteLine(" || Есен/Зима цена:4.15лв/на брой    ||");
                Console.WriteLine(" ||----------------------------------||");
                Console.WriteLine("****************************************");
                Console.WriteLine("****************************************");
                Console.WriteLine("Избери цветя: ");
                var chooses = Console.ReadLine();
                var pricehris = 0.00;
                if (chooses == "Хризантеми" || chooses == "хризантеми")
                {
                    var brhrisantemiс = int.Parse(Console.ReadLine());

                    var seasonss = Console.ReadLine();
                    if (seasonss == "Spring" || seasonss == "Summer" || seasonss == "Пролет" || seasonss == "пролет" || seasonss == "Лято" || seasonss == "лято")
                    {
                        pricehris = brhrisantemiс * 2.00;

                    }
                    else if (seasonss == "Autumn" || seasonss == "Winter" || seasonss == "Зима" || seasonss == "зима" || seasonss == "Есен" || seasonss == "есен")
                    {
                        pricehris = brhrisantemiс * 3.75;
                    }

                }
                Console.WriteLine("{0:F2}", pricehris);

                if (chooses == "Рози" || chooses == "рози")
                {
                    var brrosess = int.Parse(Console.ReadLine());
                    var seas = Console.ReadLine();
                    var priceross = 0.00;
                    if (seas == "Spring" || seas == "Summer")
                    {
                        priceross = brrosess * 4.10;
                    }
                    else if (seas == "Autumn" || seas == "Winter")
                    {
                        priceross = brrosess * 4.50;
                    }
                }
                if (chooses == "Лалета" || chooses == "лалета")
                {

                }

                /*
                    var brhrisantemi = int.Parse(Console.ReadLine());
                    var brroses = int.Parse(Console.ReadLine());
                    var brlales = int.Parse(Console.ReadLine());
                    var seasons = Console.ReadLine();
                    var holydays = Console.ReadLine();
                    var bucket = brroses + brlales + brhrisantemi;
                    var pricebucket = brhrisantemi + brroses + brlales;

                    var hrizantemi = 0.00;
                    var roses = 0.00;
                    var laleta = 0.00;

                    if (seasons == "Spring" || seasons == "Summer")
                    {
                        hrizantemi = brhrisantemi * 2.00;
                        roses = brroses * 4.10;
                        laleta = brlales * 2.50;
                    }
                    else if (seasons == "Autumn" || seasons == "Winter")
                    {
                        hrizantemi = 3.75 * brhrisantemi;
                        roses = 4.50 * brroses;
                        laleta = 4.15 * brlales;
                    }
                    var sum = hrizantemi + roses + laleta;
                    if (holydays == "Y")
                    {
                        sum *= 1.15;
                    }
                    if (seasons == "Spring" && brlales >= 7)
                    {
                        sum *= 0.95;

                    }
                    if (seasons == "Winter" && brroses >= 10)
                    {
                        sum *= 0.9;
                    }
                    if (bucket >= 20)
                    {
                        sum *= 0.8;
                    }
                    Console.WriteLine("{0:F2}", sum + 2);
                }
                */
            }
        }
    }
}
