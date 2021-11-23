using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SUM
{
    class Program
    {
        public static int Sum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] arry = { 3, 4, 5 };
            Debug.Writeline(Sum(arry));
            Debug.Writeline(Sum(4, 7, 8, 10, 11));
            Debug.Writeline(Sum(new int[5] { 1, 2, 3, 4, 5 }));
        }
    }
}