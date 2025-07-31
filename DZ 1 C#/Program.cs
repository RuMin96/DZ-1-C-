using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] OrigArr = { 1, 4, 6, 8, 6 };
            int[] FilterArr = { 1, 4, 6, 0, 90 };
            square(5, '*');
            IsPalindrom(1234);
            SortArr(OrigArr, FilterArr);

            ClockTime t1 = new ClockTime(23, 59, 58);
            t1.Print();
            t1.Tick();
            t1.Print();
            t1.Tick();
            t1.Print();

            ClockTime t2 = new ClockTime(1, 2, 3);
            Console.WriteLine(t2.ToSeconds());
            Console.WriteLine(t1.ClockTimeOffSet(t2));
            ClockTime t3 = new ClockTime();
            t3.Print();


            Complex a = new Complex(2, 3);
            Complex b = new Complex(1, -4);

            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));

            Console.WriteLine("a + 5 = " + (a + 5));
            Console.WriteLine("5 + b = " + (5 + b));
            Console.WriteLine("a * 2 = " + (a * 2));
            Console.WriteLine("2 * a = " + (2 * a));

            Console.WriteLine("-a = " + (-a));

            a++;
            Console.WriteLine("a++ = " + a);
            b--;
            Console.WriteLine("b-=" + b);

            Console.WriteLine("|a| = " + a.Abs());

            Console.WriteLine("a['Re'] = " + a["Re"]);
            Console.WriteLine("a['Im'] = " + a["Im"]);

            Console.WriteLine(a.CompareTo(b));

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
        }
        //Метод Квадрата
        public static void square(int sideLength, char symbol)
        {
            for (int i = 0; i < sideLength; i++)
            {
                Console.Write(symbol);
                for (int j = 0; j < sideLength -1; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static bool IsPalindrom(int number)
        {
            int original = number;
            int reserved = 0;

            while (number >0)
            {
                int digit = number % 10;
                reserved = reserved * 10 + digit;
                number = number / 10;
            }
            if(original == reserved)
            {
                Console.WriteLine(true);
                return true;

            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
        }
        public static void SortArr(int[] OrigArr, int[] FilterArr)
        {
            for (int i = 0; i < OrigArr.Length; i++)
            {
                bool search = false;
                for (int j = 0; j < FilterArr.Length; j++)
                {
                    if (OrigArr[i] == FilterArr[j])
                    {
                        search = true;
                        break;
                    }
                }
                if (!search)
                    Console.Write(OrigArr[i] + " ");
            }


        }
    }
}

