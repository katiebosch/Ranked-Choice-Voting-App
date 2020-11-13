using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankedChoiceVotingApp
{
     public sealed class BallotProcessor //Singleton
     {
          private Dictionary<Color, Ballot> buckets;

          public BallotProcessor()
          {
               Initialize();
          }

          private void Initialize()
          {
               var ballots = DBInterface.GetBallots();
               foreach(Ballot ballot in ballots)
               {
                    buckets.Add(ballot.Choices.FirstChoice, ballot);
               }
          }

          private void ProcessStep()
          {
               /// Get next choice of all the ballot within a "losing" color
               // Get the counts of each color
               // Counts that are less than 50% of the total get reallocated (Total = 101)
               // When there is one color left, we have our winner!

               // Stretch goal: get 1-7 place
          }
     }
}
