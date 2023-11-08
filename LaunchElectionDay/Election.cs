using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Election
    {
        public string Year;
        public List<Race> Races;

        public Election(string year)
        {
            Year = year;
            Races = new List<Race>();


        }

        public void AddRace(Race race)
        {
            Races.Add(race);
        }

        public List<Candidate> AllCandidates()
        {
            var allcandidates = new List<Candidate>();
            foreach (var Race in Races)
            {
                foreach (var candidate in Race.Candidates)
                {
                    allcandidates.Add(candidate);


                }


            }
            return allcandidates;
        }

        public Dictionary<string, int> VoteCounts()
        {
            var votecounts = new Dictionary<string, int>();
            foreach (var Race in Races)
            {
                foreach (var candidate in Race.Candidates)
                {
                    votecounts.Add(candidate.Name, candidate.Votes);


                }


            }
            return votecounts;










        }
    }

}