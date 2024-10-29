using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_miss_alaa
{
    class Search<T>
    {
       public static int Binary_Searche(int [] array, int  key)
        {
            int low = 0, high = array.Length - 1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (key==array[mid]) return (mid );
                if (key>array[mid]) low = mid + 1;
                else { high = mid - 1; }
            }
            return -1;

        }
       public static int Recursion_Binary_Searche(int[] array, int key, int high, int low)
       {

           int mid = (low + high) / 2;
           if (key == array[mid]) return (mid);
           if (key > array[mid])  return Recursion_Binary_Searche(array, key, mid + 1, high);
           else { return Recursion_Binary_Searche(array, key, low, mid - 1);}
       }
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            int []array={-3,5,7,8,10,12};
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+"\t");
            } Console.WriteLine("");
            Console.WriteLine("Enter the key please");
            int key=int.Parse(Console.ReadLine());
            Array.Sort(array);
          Console.WriteLine( Search<int>.Recursion_Binary_Searche(array, key,0,array.Length-1));
          //Console.WriteLine(Search<int>.Binary_Searche(array, key));


        }
    }
}
