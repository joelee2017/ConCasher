using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCasher
{
    class CFruit
    {
        public double Price { get; set; }
        public virtual double spend()
        {
            return 0;
        }
    }

    class CNumber : CFruit
    {
        public int Number { get; set; }
        public CNumber(int number, double price)
        {
            Number = number;
            Price = price;
        }
        public override double spend()
        {
            return Number * Price;
        }
    }

    class CWeight : CFruit
    {
        public double Weight { get; set; }
        public CWeight(double weight, double price)
        {
            Weight = weight;
            Price = price;
        }
        public override double spend()
        {
            return Weight * Price;
        }
    }

    class CSum
    {
        private static double tot;
        public CSum(CFruit f)
        {
            tot += f.spend();
            Console.WriteLine($"該項收費 {f.spend()}  累計總收費 {tot}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CNumber Onum;
            CWeight Owt;
            CSum Osum;
            while(true)
            {
                Console.Write("結算的種類?  (1.個數   2.公斤   3.離開)：  ");
                int item = int.Parse(Console.ReadLine());

                if(item ==1)
                {
                    Console.Write("輸入購買的數量 ?");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("輸入單價(元) ?");
                    double price = double.Parse(Console.ReadLine());
                    Onum = new CNumber(number, price);
                    Osum = new CSum(Onum);
                }

                else if (item ==2)
                {
                    Console.Write("輸入購買公斤數 ?");
                    double weight = double.Parse(Console.ReadLine());
                    Console.Write("輸入單價(元) ?");
                    double price = double.Parse(Console.ReadLine());
                    Owt = new CWeight(weight, price);
                    Osum = new CSum(Owt);
                }

                else
                { break; }
                Console.WriteLine();
            }

        }
    }
}
