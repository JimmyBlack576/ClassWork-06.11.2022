using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard(123412341234,
                "Иван И.И.",123,new DateTime(2025,02,14));

            creditCard.Print();
            Console.ReadLine();
        }

        static void F1()
        {
            
            int[] arrnum = new int[5];

            for (int i = 0; i < arrnum.Length; i++)
            { 
                arrnum[i] = int.Parse(Console.ReadLine());
            }
            

            int mult = 1;
            foreach (var i in arrnum)
            {
                mult *= i;
            }

            Console.Write("Сумма " + arrnum.Sum() + " ") ;
            Console.Write($"Сумма   {arrnum.Sum()}  ");

            Console.WriteLine("Произведение " + mult);
            

            Console.WriteLine("Максимум: " + arrnum.Max());
            Console.WriteLine("Минимум: " + arrnum.Min());
            Console.WriteLine("Произведение %d ", mult);

            Console.ReadLine();
        }

        static void F2()
        {
            Console.WriteLine(int.Parse
                (new string( Console.ReadLine().Reverse()
                .ToArray())));
        }

        static void F3()
        {
            string[] arr = Console.ReadLine().Split();

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = new string(arr[i].Reverse().
                    ToArray());
            }
            //Console.WriteLine(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static void F4()
        {
            string str = Console.ReadLine();
            try
            {
                int num = Convert.ToInt32(str, 2);
                Console.WriteLine(num);
            }
            catch(FormatException e)//перехват ошибок
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Console.WriteLine("End");
            }

            
        }

        static void F5()
        {
            string[] str = Console.ReadLine().Split('*');
            int mult = 1;
            try
            {
                foreach (string str2 in str)
                {
                    mult *= Convert.ToInt32(str2);
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода!");
            }
            
            
            Console.WriteLine(mult);

        }


    }

    
}
