using System;
using StrategyPattern.Interface;
using StrategyPattern.Model;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Character king = new King();
            Character queen = new Queen();

            king.Fight();
            queen.Fight();

            Console.Read();
        }
    }
}