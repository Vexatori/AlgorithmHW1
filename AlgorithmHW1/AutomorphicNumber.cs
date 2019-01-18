using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW1
{
    public static class AutomorphicNumber
    {
        /// <summary>
        /// Метод определяет, является ли число автоморфным
        /// </summary>
        /// <param name="num">Число, которое проверяется на автоморфность</param>
        /// <returns></returns>
        public static bool IsAutomorphic( int num )
        {
            if( num == 0 || num == 1 )
            {
                return true;
            }
            else
            {
                int number = 0;
                if( num < 0 )
                {
                    number = -num;
                    return IsAutomorphicInside ( number );
                }
                else
                {
                    number = num;
                    return IsAutomorphicInside ( number );
                }
            }
        }

        /// <summary>
        /// Внутренний метод класса для проверки автоморфности числа;
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool IsAutomorphicInside( int number )
        {
            int valueOfNumeric = ValueOfNumeric.ValueOfNums( number );
            if ( ( PowOfTheNumber.Pow( number, 2 ) % PowOfTheNumber.Pow( 10, valueOfNumeric ) ) == number )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
