using System;
using System.Collections.Generic;
using System.Text;

namespace testConsoleApp
{
   public static class Sorting
    {
        public static int[] bubblesort(int[] array)
        {
            for(int i =0; i<array.Length;i++)
            {
                Boolean Issorted = true;
                for(int j=0;j<array.Length -1-i;j++ )
                {
                    if(array[j] > array[j+1])
                    {
                        int firstval = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = firstval;
                        Issorted = false;
                    }
                }
                if (Issorted)
                    break;
            }
            return array;
        }
    }
}
