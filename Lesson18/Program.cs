/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lesson18
{
    *//*   internal class Program
       {
           static void Main(string[] args)
           {

               MyCollection<int> mc = new MyCollection<int>();
               mc.add(11);
               mc.add(12);
               mc.add(13);
               mc.add(14);
               mc.add(15);

               Console.WriteLine("Before set");
               mc.getI(0);
               mc.getI(1);
               mc.getI(2);
               mc.getI(3);
               mc.getI(4);


               mc.setI(0, 111);
               mc.setI(1, 222);
               mc.setI(2, 333);

               Console.WriteLine("After set");
               mc.getI(0);
               mc.getI(1);
               mc.getI(2);
               mc.getI(3);
               mc.getI(4);


           }

       }
    *//*
    internal class MyCollection<T>
    {
        int i = 0;
        public List<T> Data
        {
            get; set;
        }

        public MyCollection()
        {
            Data = new List<T>();
        }

        public void add(T data)
        {

            Data.Add(data);
            i = i + 1;
        }

        public T getI(int i)
        {
            Console.WriteLine(Data[i]);
            return Data[i];
        }
        public void setI(int i, T data)
        {
            Data[i] = data;
        }
    }
}
*/