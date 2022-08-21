using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Arrays.Easy
{
    public class TourneyWinner
    {
        public void Run()
        {
            List<List<string>> competitions = new List<List<string>>();
            //competitions.Add(new List<string> { "HTML", "C#" });
            //competitions.Add(new List<string> { "C#", "Python" });
            //competitions.Add(new List<string> { "Python", "HTML" });

            //List<int> results = new List<int> { 0, 0, 1 };

            //competitions.Add(new List<string> { "Bulls", "Eagles" });
            //List<int> results = new List<int> { 1 };

            competitions.Add(new List<string> { "HTML", "Java" });
            competitions.Add(new List<string> { "Java", "Python" });
            competitions.Add(new List<string> { "Python", "HTML" });
            competitions.Add(new List<string> { "C#", "Python" });
            competitions.Add(new List<string> { "Java", "C#" });
            competitions.Add(new List<string> { "C#", "HTML" });
            competitions.Add(new List<string> { "SQL", "C#" });
            competitions.Add(new List<string> { "HTML", "SQL" });
            competitions.Add(new List<string> { "SQL", "Python" });
            competitions.Add(new List<string> { "SQL", "Java" });
            List<int> results = new List<int> { 0, 1, 1, 1, 0, 1, 0, 1, 1, 0 };

            Console.WriteLine($"{TournamentWinner(competitions, results)}");
        }
        public int WinnerIndex(int res)
        {
            if (res == 0)
            {
                return 1;
            }
            return 0;
        }
        public string RoundWinner (string[] roundArray, int winnerIndex)
        {
            return roundArray[WinnerIndex(winnerIndex)];
        }
        public string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            // Write your code here.
            string[][] compArray = competitions.Select(x => x.ToArray()).ToArray();
            int[] resArray = results.ToArray();
            Dictionary<string, int> winnerDict = new Dictionary<string, int>();
            string currentLeader = "";
            winnerDict[currentLeader] = 0;
            for ( int i = 0; i < resArray.Length; i++ )
            {
                string roundWinner = RoundWinner(compArray[i], resArray[i]);
                if ( winnerDict.Keys.Contains(roundWinner) ) {
                    winnerDict[roundWinner]+=3;
                }
                else
                {
                    winnerDict[roundWinner] = 3;
                }


                if ( winnerDict[roundWinner] > winnerDict[currentLeader] )
                {
                    currentLeader = roundWinner;
                }
            }

            return currentLeader;
        }
    }
}
