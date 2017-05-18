using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeCatchSymulator;

namespace PokeCatchSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulation to see if a pokemon is caught.
            ICatchRate calculator = new CatchRateCalculator();

            var maxHP = 100;
            var currentHP = 50;
            var targetRate = 255;
            var ballBonus = 1;
            var statusBonus = 1;


            //Calculate the value of A 
            var catchRate = calculator.determineCatchRate( maxHP,  currentHP, targetRate, ballBonus, statusBonus);



            // If the condition is matched, display the "Caught" message.
            Console.WriteLine("Gotcha! The pokemon was caught.");
            Console.ReadKey();
        }
    }
}
