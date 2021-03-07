using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number6: ");
            var number6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number9: ");
            var number9 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number12: ");
            var number12 = Convert.ToDouble(Console.ReadLine());
            if (number6 >= 0)
            {
                number6 = Math.Pow(number6, 9);
            }
            else
            {
                number6 = Math.Pow(number6, 9);
            }
            if (number9 >= 0)
            {
                number9 = Math.Pow(number9, 9);
            }
            else
            {
                number9 = Math.Pow(number9, 12);
            }
            number9 = (number12 >= 0) ? Math.Pow(number12, 9) : Math.Pow(number12, 15);
            if (number9 >= 0)
            {
                number9 = Math.Pow(number12, 9);
            }
            else
            {
                number9 = Math.Pow(number12, 15);
            }
            Console.WriteLine($"number6 = {number6}");
            Console.WriteLine($"number9 = {number9}");
            Console.WriteLine($"number12 = {number12}");



            Console.WriteLine("Input x6, y6, x7, y7");

            var x6 = Convert.ToDouble(Console.ReadLine());
            var y6 = Convert.ToDouble(Console.ReadLine());
            var x7 = Convert.ToDouble(Console.ReadLine());
            var y7 = Convert.ToDouble(Console.ReadLine());
            var Dlina1 = Math.Sqrt(Math.Pow(x6, 2) + Math.Pow(y6, 2));
            var Dlina2 = Math.Sqrt(Math.Pow(x7, 2) + Math.Pow(y7, 2));

            if (Dlina1 < Dlina2)
            {
                Console.WriteLine("первaя точка ближе");
            }
            else
            {
                Console.WriteLine("вторая точка ближе");
            }
            Console.ReadLine();




            Console.Write("Input ugol2: ");
            var ugol2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input ugol3: ");
            var ugol3 = Convert.ToDouble(Console.ReadLine());
            if ((ugol2 + ugol3) < 180)
            {
                Console.WriteLine("треугольник существует");
                if (ugol2 == 90 || ugol3 == 90 || ugol3 + ugol2 == 90)
                {
                    Console.WriteLine("треугольник прямоугольный");
                }
                else Console.WriteLine("треугольник не прямоугольный");
            }
            else
            {
                Console.WriteLine("треугольник не существует");



                Console.Write("Number5:");
                var Number5 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Number9:");
                var Number9 = Convert.ToDouble(Console.ReadLine());
                var PoluSumma = (Number5 + Number9) / 2;
                var Proizvedenie = 2 * (Number5 * Number9);
                if (Number5 < Number9)
                {
                    Number5 = PoluSumma;
                    Number9 = Proizvedenie;
                }
                else
                {
                    Number9 = PoluSumma;
                    Number5 = Proizvedenie;
                }
                Console.WriteLine($"number5 = {Number5}");
                Console.WriteLine($"number9 = {Number9}");



            }
        }
    }
}
