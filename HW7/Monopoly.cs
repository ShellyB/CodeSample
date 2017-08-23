using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyProbability
{
    class Monopoly
    {
        // constant variables
        const int PLAYERS = 10000; 
        const int ROUNDS = 25;
        Dice die = new Dice();
        int total;

        // game board array
        String[] board = new String[] { "Go", "Mediterranean Ave", " Community Chest (1)", "Baltic Ave", "Income Tax", "Reading Railroad", "Oriental Ave",
            "Chance (1)", " Vermont Ave","Connecticut Ave", "In Jail/Just Visiting" , "St. Charles Place", "Electric Company", "States Ave", " Virginia Ave",
            "Pennsylvania Railroad", "St. James Place", "Community Chest (2)","Tennesee Ave", "New York Ave", "Free Parking", "Kentucky Ave", "Chance (2)",
            "Indiana Ave", "Illinois Ave", "B&O Railroad", "Atlantic Ave", "Ventnor Ave", "Water Works", "Marvin Gardens", "Go to Jail", "Pacific Ave", 
            "North Carolina Ave", "Community Chest (3)", "Pennsylvania Ave", "Short Line", "Chance (3)", "Park Place", "Luxury Tax", "Boardwalk",};

        // method to analyze the game spaces
        public double[] Analyze()
        {
            int[] hold = new int[40];
            int location = 0;
            int prounds = 1;
            double[] percent = new double[40];

            // runs once for every player
            for (int i = 0; i < PLAYERS; i++)
            {
                while (prounds <= ROUNDS)
                {
                    location = location + die.Roll2D6();

                    if (location > 39)
                    {
                        location -= 40;
                        prounds++;
                        hold[location]++;
                    }

                    else if (location == 30)
                    {
                        hold[location]++;
                        location = 10;
                        prounds++;
                    }
                    else hold[location]++;
                }

            }
            // finds the percent for each space
            foreach (int k in hold)
            {
                total = total + hold[k];
            }
            int h = 0;
            while (h <= 39)
            {
                percent[h] = Math.Round(((double)hold[h] / total) * 100, 2);
                h++;
            }

            return percent;

        }

        // lists the results
        public void ListResults(double[] percents)
        {
            Console.WriteLine("Study Results:\n ");

            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine(board[i] + " : " + percents[i]);
            }
        }
    }
}
