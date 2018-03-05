using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    delegate int transformer(int n);
    class Utility
    {
        int check = 0;
        int test = 1;
        public static void transform(int[] nosArr, transformer trans)
        {
            for(int i = 0; i < nosArr.Length; i++)
            {
                nosArr[i] = trans(nosArr[i]);
            }
        }
    }
}
