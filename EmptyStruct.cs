using System;
namespace Delegat17._02._2023
{
    delegate void MyDeligate(int[]a);

   

    public class EmptyStruct
    {
        static Random r = new Random();

        public static void Printer(int []a)
        {
            for (int i = 0; i<a.Length; i++)
            {
                a[i] = r.Next(5, 20);
                Console.Write("{0,4}",i);
            }
            Console.WriteLine();
        }

        public static void ChetnoeCh(int[] a)
        {
            int Count = 0;
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i]%2==0)
                {
                    Count++;
                }
            }
            Console.WriteLine("Количесвто четных чисел в массиве = "+Count);
        }
        public static void NEChetnoeCh(int[] a)
        {
            int Count = 0;
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i]%2!=0)
                {
                    Count++;
                }
            }
            Console.WriteLine("Количесвто нечетных чисел в массиве = " + Count);
        }
        public static void SimpleElem(int[] a)
        {
            int Count = 0;
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i]%1==0 && a[i]%a[i]==0)
                {
                    Count++;
                }
            }
            Console.WriteLine("Количесвто простых чисел в массиве = " + Count);
        }
        

    }

    delegate void MyDeligate2();

    public  class EmptyStruct1
    {
        public static int Width = 23;
        public static int Lenth = 12;
        public static int Osnova = 4;
        public static int Height = 6;

        public static void STreug()
        {
            
            int S = 1 / 2 * Osnova * Height;
            Console.WriteLine("Площадь триугольника = " + S);
        }
        public static void SPramoug()
        {
            int Count = 0;
            Count = Width * Lenth;
            Console.WriteLine("Площадь прямоугольника = " +Count);
        }
        public static void PtintTime()
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine("Время = "+dateTime.Minute);
        }
        public static void PrintDay()
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine("День = "+dateTime.DayOfYear);
        }
        public static void PrintDayofWeek()
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine("День недели = "+dateTime.DayOfWeek);
        }
    }


}
