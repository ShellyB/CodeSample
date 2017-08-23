using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyProbability
{
    class Dice
    {
        // a random number generator
        Random rand = new Random();

        // a method for rolling the dice
        public int Roll(int side)
        {
            side = rand.Next(1, side) + 1;
            return side;
        }

        // rolling 2 six sided die
        public int Roll2D6()
        {
            Dice die = new Dice();
                       
            int dece = rand.Next(1,7);
            int doce = rand.Next(1,7);

            int sum = doce + dece;

            return sum;
        }

        // making roll percents
        public int RollPercent()
        {
            Dice died = new Dice();
            int roll1 = died.Roll(10);
            int roll2 = died.Roll(10);

            int percent = (roll1 * 10 + roll2) - 10;

            return percent;
        }
   
    }
}
