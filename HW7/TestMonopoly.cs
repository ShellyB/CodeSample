using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyProbability
{
    class TestMonopoly
    {
        static void Main(string[] args)
        {
            // generates a monopoly object
            Monopoly game = new Monopoly();
            
            double[] percents = new double[40];

            //calling the analyze method
            percents = game.Analyze();

            //listing the results
            game.ListResults(percents);

            //close option
            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }
    }
}
