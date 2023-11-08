using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Race
    {
        public string Office { get; set; }
        public List<Candidate> Candidates { get; set; }
        public bool IsOpen;
        public Race(string office)
        {
            Office = office;
            Candidates = new List<Candidate>();
            IsOpen = true;
        }

        public void RegisterCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }

        public void Close()
        {
            IsOpen = false;
        }

          /* public Candidate Winner()
        { if (IsOpen == true)
            {
                var winner = Candidate
            }  */          
                    
        
    }
}
