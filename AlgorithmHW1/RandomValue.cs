using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW1
{
    public static class RandomValue
    {
        /// <summary>
        /// Встроенный метод рандома в язык C#
        /// </summary>
        /// <returns></returns>
        public static int StandartRandom()
        {
            Random rnd = new Random();
            return rnd.Next( 1, 100 );
        }

        /// <summary>
        /// Собственный метод рандома (в качестве "зерна" берется текущая секунда настоящего времени)
        /// </summary>
        /// <returns></returns>
        public static int MineRandom()
        {            int x = DateTime.Now.Second;            x = ( 5 * x + 3 ) % 100;            return x;
        }
    }
}
