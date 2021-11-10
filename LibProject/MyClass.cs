using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibProject
{
    public class MyClass
    {
        public static int IndexOfLastMin(int[] array)
        {
            if (array.Length == 0)
                return -1;
            int indexOfLastMin = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] < array[indexOfLastMin])
                    indexOfLastMin = i;

            return indexOfLastMin;
        }
    }
}
