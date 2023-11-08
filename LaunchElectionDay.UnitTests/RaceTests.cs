using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay.UnitTests
{
   public class RaceTests
    {
        [Fact]
        public void ifraceCanRace()
        {
            var race = new Race("City council");

            Assert.Equal("City council", race.Office);


        }
        [Fact]
        public void ifraceCanRegister2() 
        {
            var race = new Race("City council");
            var diana = new Candidate("Diana D", "Democrat");
            var lance = new Candidate( "alex", "costa" );
            race.RegisterCandidate( lance );
            race.RegisterCandidate( diana );
            Assert.Equal(diana, race.Candidates[1]);
            Assert.Equal(lance, race.Candidates[0]);


        }
    }
}
