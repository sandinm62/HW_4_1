using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HW_4_1
{
    //1.
    //а) Дописать класс для работы с одномерным массивом.
    //Реализовать конструктор, создающий массив определенного размера и
    //заполняющий массив числами от начального значения с заданным шагом.
    //Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse,
    //возвращающий новый массив с измененными знаками у всех элементов
    //массива(старый массив, остается без изменений), метод Multi,
    //умножающий каждый элемент массива на определённое число, свойство MaxCount,
    //возвращающее количество максимальных элементов.
    //б)** Создать библиотеку содержащую класс для работы с массивом.
    //Продемонстрировать работу библиотеки
    // 
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

        //public void inverse(int[] newInverseMass)
        //{
        //    Array.Copy(a, a.Length);
        //    for (int i = 0; i < newInverseMass.Length; i++)
        //        newInverseMass[i] *= -1;
        //}

         public int[] multi()
        {

            int[] array = new int[a.Length];
           
            for (int i = 0; i < a.Length; i++)
            {
                array[i] = a[i] * 3;
                Console.Write(array[i] + " ");
            }
            


            return array;
            
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
        public int MaxCount
        {
            get
            {
                int max = a.Max();
                int s = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == max)
                        s += 1;
                }
                return s;
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
        //public int[] inverse(int[] inverseMass)
        //{

        //    int[] newInverseMass = new int[inverseMass.Length];
        //    for (int i = 0; i < inverseMass.Length; i++)
        //        newInverseMass[i] = -inverseMass[i];
        //    return newInverseMass;

        //}

        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, 1);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Max);
            Console.WriteLine(a.Min);
            Console.WriteLine("sum = " + a.sum);
            a.multi();
            Console.WriteLine();
            Console.WriteLine("MaxCount = " + a.MaxCount);


            
            Console.WriteLine(a.CountPositiv);
            Console.ReadKey();
        }
    }
}
