using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW1
{
    public static class PowOfTheNumber
    {
        /// <summary>
        /// Метод возвращает значение числа a в степени n
        /// </summary>
        /// <param name="a">Число, возводящееся в степень</param>
        /// <param name="n">Показатель степени</param>
        /// <returns></returns>
        public static double? Pow( int a, int n )
        {
            int? error;
            if ( a != 0 && n != 0 )
            {
                if ( n < 0 )
                {
                    return ( 1.0 / InsidePow( a, -n ) );
                }
                else
                {
                    return InsidePow( a, n );
                }
            }
            else
            {
                error = null;
                return error;
            }
        }

        /// <summary>
        /// Внутренний метод класса
        /// </summary>
        /// <param name="a"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        private static int InsidePow( int a, int m )
        {
            int result = 1;
            while( m != 0 )
            {
                if( ( m % 2 ) != 0 )
                {
                    m--;
                    result *= a;
                }
                else
                {
                    a *= a;
                    m /= 2;
                }
            }
            return result;
        }
    }
}
