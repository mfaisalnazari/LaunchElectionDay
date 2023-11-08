using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay.UnitTests
{
    public class ElectionTest
    {
        [Fact]
        public void IsCreatedWithAYearAndNoRaces()
        {

            var election = new Election("2023");
            Assert.Equal("2023", election.Year);
            Assert.Equal(new List<Race>(), election.Races);
        }
        [Fact]
        public void AddRaceAddsARaceList()
        {
            var election = new Election("2023");
            var race1 = new Race("City Council");
            var race2 = new Race("School Board");

            election.AddRace(race1);
            election.AddRace(race2);

            Assert.Equal(new List<Race> { race1, race2 }, election.Races);

        }
        [Fact]
        public void AllCandidatesreturnAllCandidates()
        {
            var election = new Election("2023");
            var race1 = new Race("City Council");
            var race2 = new Race("School Board");

            election.AddRace(race1);
            election.AddRace(race2);
            var can1 = new Candidate("Diana D", "Democrat");
            var can2 = new Candidate("Diana D", "Democrat");
            var can3 = new Candidate("Diana D", "Democrat");
            race1.RegisterCandidate(can1);
            race1.RegisterCandidate(can2);
            race2.RegisterCandidate(can3);
            var expected = new List<Candidate> { can1, can2, can3 };
            Assert.Equal(expected, election.AllCandidates());


        }

        [Fact]
        public void VoteCountsWorks()
        {
            var election = new Election("2023");
            var race1 = new Race("City Council");
            var race2 = new Race("School Board");

            election.AddRace(race1);
            election.AddRace(race2);
            var can1 = new Candidate("Diana D", "Democrat");
            var can2 = new Candidate("Diana b", "Democrat");
            var can3 = new Candidate("Diana c", "Democrat");
            can1.VoteFor();
            can1.VoteFor();
            can1.VoteFor();
            can2.VoteFor();
            can2.VoteFor();
            can3.VoteFor();
            race1.RegisterCandidate(can1);
            race1.RegisterCandidate(can2);
            race2.RegisterCandidate(can3);
            var expected = new Dictionary<string, int>()
            { {can1.Name,3},{can2.Name,2},{can3.Name,1}};
            Assert.Equal(expected,election.VoteCounts());
        }

    }
}
