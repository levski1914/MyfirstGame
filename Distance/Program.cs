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

            if (seasons == "Spring" || seasons == "Summer" )
            {
                hrizantemi = brhrisantemi*2.00;
                roses =brroses* 4.10;
                laleta =brlales* 2.50;
            }
            else if (seasons=="Autumn"||seasons=="Winter")
            {
                hrizantemi = 3.75*brhrisantemi;
                     roses = 4.50*brroses;
                    laleta = 4.15*brlales;
            }
            var sum = hrizantemi + roses + laleta;
            if (holydays=="Y")
            {
                sum *= 1.15;
            }
           if(seasons=="Spring"&&brlales>=7)
            {
                sum *= 0.95;

            }
            if (seasons=="Winter"&&brroses>=10)
            {
                sum *= 0.9;
            }
            if (bucket>=20)
            {
                sum *= 0.8;
            }
            Console.WriteLine("{0:F2}",sum+2);
            
            
        }
    }
}
