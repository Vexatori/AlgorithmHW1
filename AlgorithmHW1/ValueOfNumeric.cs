using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW1
{
    public static class ValueOfNumeric
    {
        /// <summary>
        /// Метод возвращает число цифр во введенном числе
        /// </summary>
        /// <param name="num">Число, в котором нужно подсчитать количество цифр</param>
        /// <returns></returns>
        public static int ValueOfNums( int num )
        {
            int number = num;
            int value = 0;
            while( number > 0 )
            {
                number /= 10;
                value++;
            }
            return value;
        }

        /// <summary>
        /// Метод возвращает список, состоящик из цифр введенного числа
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static List<int> NumericsOfNum( int num )
        {
            int number = num;
            List<int> numerics = new List<int>();
            while( number > 0 )
            {
                numerics.Add( number % 10 );
                number /= 10;
            }
            return numerics;
        }
    }
}
