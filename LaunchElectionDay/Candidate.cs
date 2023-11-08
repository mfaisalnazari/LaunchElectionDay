using System.Collections.Generic;

namespace LaunchElectionDay
{
    public class Candidate {
        public string Name { get; set; }
        public string Party { get; set; }
        public int Vote { get; set; }
        public int Votes { get; set; }
        public Candidate(string name, string party)
        {
            Name = name;
            Party = party;
            Vote = 0;
            Votes = 0;


        }


        public void VoteFor()
        {
            Vote ++;
            Votes = Vote;
        }

        
    
    
    }
}
