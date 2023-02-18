using System;

namespace Delegat17._02._2023
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            MyDeligate obj = new MyDeligate(EmptyStruct.Printer);
            obj += EmptyStruct.ChetnoeCh;
            obj += EmptyStruct.NEChetnoeCh;
            obj += EmptyStruct.SimpleElem;
            int[] a = new int[5];
            obj(a);
            Console.WriteLine("\n");
            MyDeligate2 obj1 = new MyDeligate2(EmptyStruct1.STreug);
            obj1 += EmptyStruct1.SPramoug;
            obj1 += EmptyStruct1.PrintDay;
            obj1 += EmptyStruct1.PrintDayofWeek;
            obj1 += EmptyStruct1.PtintTime;
            EmptyStruct1.PrintDay();
            EmptyStruct1.STreug();
            EmptyStruct1.SPramoug();
            EmptyStruct1.PrintDayofWeek();
            EmptyStruct1.PtintTime();
        }

       
    }
}
