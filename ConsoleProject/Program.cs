using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibProject;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] array = new int[] { 2, 3, 4 };
            int x1 = array[i++];
            int x2 = array[++i];
            i = 0;
            int x = ++i + i++;
            i = 0;
            int y = i++ + ++i;
            //Console.WriteLine(
            //    MyClass.IndexOfLastMin(
            //        new int[] { 1, 2, 3 }));
            int x = 0;
            Update(x);
            Console.WriteLine(x);//увеличится на 1, не увеличится
            Update(x, out x);
            Console.WriteLine(x);//увеличится на 1, не увеличится
            Update(ref x);
            Console.WriteLine(x);//увеличится на 1
            Console.ReadKey();
        }
        
        static void Update(int x)
        {
            ++x;
        }
        static void Update(int x, out int y)
        {
            y = ++x;
        }
        static void Update(ref int x)
        {
           ++x;
        }

    }
}
