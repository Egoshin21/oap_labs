using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            var Massiv = new int[10];
            Random Rand = new Random();
            var MaxValue = -1;
            for (int i = 0; i < Massiv.Length; i++)
            {
                Massiv[i] = Rand.Next(100);
                if (Massiv[i] > MaxValue)
                    MaxValue = Massiv[i];
                Console.Write($"{Massiv[i]}\t");
            }
            Console.Write($"\nMaximum = {MaxValue}");
          
            var Massiv = new int[10];
            Random Rand = new Random();
            var Summa = 0;
            var Proizvidenie = 1L;
            for (int i = 0; i < Massiv.Length; i++)
            {
                Massiv[i] = Rand.Next(100);
                Summa += Massiv[i];
                Proizvidenie = Proizvidenie * Massiv[i];
                Console.Write($"{Massiv[i]}\t");
            }
            Console.Write($"\nsumma = {Summa}\nпроизведение = {Proizvidenie}");
           
            Console.Write("Input MinValue: ");
            var MinValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input MaxValue: ");
            var MaxValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Shag: ");
            var Shag = Convert.ToInt32(Console.ReadLine());
                       
            for (int i = MinValue; i <= MaxValue; i+=Shag)
            {
                               
                Console.Write($"{i}\t");
            }
           
            Console.Write("Введите число: ");
            var chislo = Convert.ToDouble(Console.ReadLine());
            var Factorial1 = 1;   
            for (int i = 2; i <= chislo; i++)
            {
                Factorial1 = Factorial1 * i;
                Console.Write($"{Factorial1}\t");
            }
            Console.Write($"\nФакториар равен = {Factorial1}\t");
            
            var Massiv = new int[10];
            Random Rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Massiv[i] = Rand.Next(100);
                if (Massiv[i] % 2 == 0) 
                Console.Write("\n{0} - чет", Massiv[i]);
                else
                Console.Write("\n{0} - нечет", Massiv[i]);
            }
           
            Console.ReadLine();
        }
    }
}