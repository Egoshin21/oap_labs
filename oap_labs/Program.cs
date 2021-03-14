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
            {

                //ExceptionTest();
                //ExceptionTest2();
                //ExceptionTest3();
                //ExceptionTest4();
                //ExceptionTest5();
                //ExceptionTest6();
                //ExceptionTest7();
                //ExceptionTest8();
                //ExceptionTest9();
                //ExceptionTest10();
               
                Console.ReadKey();
            }
            static void ExceptionTest()
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
                Console.WriteLine("Конец программы");
                Console.Read();
            }
            static void ExceptionTest2()
            {
                try
                {
                    int x = 5;
                    int y = x / 0;
                    Console.WriteLine($"Результат: {y}");
                }
                catch
                {
                    Console.WriteLine("Возникло исключение!");
                }
                finally
                {
                    Console.WriteLine("Блок finally");
                }
                Console.WriteLine("Конец программы");
                Console.Read();
            }
            static void ExceptionTest3()
            {
                try
                {
                    int x = 5;
                    int y = x / 0;
                    Console.WriteLine($"Результат: {y}");
                }
                catch
                {
                    Console.WriteLine("Возникло исключение!");
                }
            }
            static void ExceptionTest4()
            {
                Console.WriteLine("Введите число");
                int x = Int32.Parse(Console.ReadLine());

                x *= x;
                Console.WriteLine("Квадрат числа: " + x);
                Console.Read();
            }
            static void ExceptionTest5()
            {
                Console.WriteLine("Введите число");
                int x;
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out x))
                {
                    x *= x;
                    Console.WriteLine("Квадрат числа: " + x);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
                Console.Read();
            }
            static void ExceptionTest6()
            {
                try
                {
                    int x = 5;
                    int y = x / 0;
                    Console.WriteLine($"Результат: {y}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Возникло исключение DivideByZeroException");
                }
            }
            static void ExceptionTest7()
            {
                try
                {
                    int x = 5;
                    int y = x / 0;
                    Console.WriteLine($"Результат: {y}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Возникло исключение {ex.Message}");
                }
            }
            static void ExceptionTest8()
            {
                int x = 1;
                int y = 0;

                try
                {
                    int result = x / y;
                }
                catch (DivideByZeroException) when (y == 0 && x == 0)
                {
                    Console.WriteLine("y не должен быть равен 0");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void ExceptionTest9()
            {
                try
                {
                    int x = 5;
                    int y = x / 0;
                    Console.WriteLine($"Результат: {y}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
                }

                Console.Read();
            }
            static void ExceptionTest10()
            {
                try
                {
                    int[] numbers = new int[4];
                    numbers[7] = 9;     // IndexOutOfRangeException

                    int x = 5;
                    int y = x / 0;  // DivideByZeroException
                    Console.WriteLine($"Результат: {y}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Возникло исключение DivideByZeroException");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Read();
            }


        }
        
    }
}