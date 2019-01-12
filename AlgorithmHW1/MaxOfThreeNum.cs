using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW1
{
    public static class MaxOfThreeNum
    {
        /// <summary>
        /// Метод возвращает максимальное из трёх чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static int Max(int x, int y, int z )
        {
            int max = x;
            if( y > max )
            {
                max = y;
            }
            if( z > max )
            {
                max = z;
            }
            return max;
        }
    }
}
