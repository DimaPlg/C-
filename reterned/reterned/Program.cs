using reterned.class_1;
using reterned.Methods;
using System;
using System.Collections.Generic;
using reterned.SortingArr;

namespace reterned
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  List<User> list = new List<User>(InputMethodForList.ToList());
              foreach (User person in list)
              {
                  Console.WriteLine(person.Id);
                  Console.WriteLine(person.Name);

              }*/

            int leng = 0;

            Console.WriteLine("Lenght arr: ");

            leng = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[leng];

            for (int i =0; i < leng; i++) 
            {
                arr[i] = Bable.RandValue(0,1000);
            }
            Console.WriteLine();

            for (int i = 0; i < leng; i++) 
            {
                Console.Write(arr[i] + " ");
            }

            //arr = Bable.BableSort(arr);
            //arr = ShakerSort.Shaker(arr);
            arr = InserionSort.Insert(arr);


                Console.WriteLine();

            for (int i = 0; i < leng; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        
    }
}
