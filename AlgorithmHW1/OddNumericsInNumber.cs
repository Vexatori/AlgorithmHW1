using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW1
{
    public static class OddNumericsInNumber
    {
        /// <summary>
        /// Метод определяет, есть ли в числе нечетные числа или нет
        /// </summary>
        /// <param name="number">Число, которое нужно проверить</param>
        /// <returns></returns>
        public static bool IsOdds( int number )
        {
            bool fl = false;
            foreach( int num in ValueOfNumeric.NumericsOfNum( number ) )
            {
                if( num % 2 != 0 )
                {
                    fl = true;
                    break;
                }
                else
                {
                    fl = false;
                }
            }
            return fl;
        }
    }
}
