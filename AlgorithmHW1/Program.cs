///Суюнов Александр

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW1
{
    class Program
    {
        static void Main ( string[] args )
        {
            //Расскоментируйте, чтобы увидеть результат решения задачи

            //Solution14();
            //Solution13();
            //Solution12();
            //Solution11();
            //Solution10();
            Console.ReadLine();
        }

        /// <summary>
        /// Решение к 14ой задаче
        /// </summary>
        private static void Solution14 ()
        {
            Console.WriteLine( "Enter your number" );
            int num = Int32.Parse( Console.ReadLine () );
            if ( AutomorphicNumber.IsAutomorphic( num ) )
            {
                Console.WriteLine( "Number is automorphic" );
            }
            else
            {
                Console.WriteLine( "Number isn\'t automorphic" );
            }
        }

        /// <summary>
        /// Решение к 13ой задаче
        /// </summary>
        private static void Solution13()
        {
            Console.WriteLine( $"Mine random value: {RandomValue.MineRandom()} " );
            Console.WriteLine( $"C# random value: {RandomValue.StandartRandom()} " );
        }

        /// <summary>
        /// Решение к 12ой задаче
        /// </summary>
        private static void Solution12()
        {
            Console.WriteLine( "Enter your three numbers" );
            int x = Int32.Parse( Console.ReadLine() );
            int y = Int32.Parse( Console.ReadLine() );
            int z = Int32.Parse( Console.ReadLine() );
            Console.WriteLine( $"Maximum of {x}, {y}, {z} is {MaxOfThreeNum.Max( x, y, z )}" );
        }

        /// <summary>
        /// Решение к 11ой задаче
        /// </summary>
        private static void Solution11()
        {
            Console.WriteLine( "Enter your numbers" );
            int n = -1;
            int count = 0;
            int sum = 0;
            while( n != 0 )
            {
                n = Int32.Parse( Console.ReadLine() );
                int temp = n % 10;
                if( temp == 8 && n > 0 && n % 2 == 0 )
                {
                    sum += n;
                    count++;
                }
            }
            Console.WriteLine( $"Average of positive numbers thats finish on \"8\" is {( double )sum / count}" );
        }

        /// <summary>
        /// Решение к 10ой задаче
        /// </summary>
        private static void Solution10()
        {
            Console.WriteLine( "Enter your number" );
            int n = Int32.Parse( Console.ReadLine() );
            Console.WriteLine( $"Is any odd numeric in {n}? => {OddNumericsInNumber.IsOdds( n )}" );
        }
    }
}
