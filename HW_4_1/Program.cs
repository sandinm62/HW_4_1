using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HW_4_1
{
    class MyArray
    {
        public int[] a;
        //int[] inverseMass;
        // Создание массива и заполнение его одним значением el
        public MyArray(int n, int el)
        {   

            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = el;
                el = el + 2;
                
            }
               
        }
   
        

        public int sum
        {
            get
            {
                int sum = a[0];
                for (int i = 1; i < a.Length; i++)
                    sum = sum + a[i];
                return sum;
            }
        }
       
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }


    internal class Program
    {
        //public int inverse(int[] inverseMass)
        //{


        //    for (int i = 0; i < a.Length; i++)
        //        inverseMass[i] = inverseMass[i] * (-1);
        //    return inverseMass[0];

        //}
        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, 1);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Max);
            Console.WriteLine(a.Min);
            Console.WriteLine("sum = " + a.sum);
           // inverse(a);
           // Console.WriteLine(inverseMass.ToString());

            Console.WriteLine(a.CountPositiv);
            Console.ReadKey();
        }
    }
}
