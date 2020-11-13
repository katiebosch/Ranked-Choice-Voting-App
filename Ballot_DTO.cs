using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankedChoiceVotingApp
{
     public class Ballot_DTO
     {
          public DateTime Timestamp { get; set; }

          public Color FirstChoice { get; set; }

          public Color SecondChoice { get; set; }

          public Color ThirdChoice { get; set; }

          public Color FourthChoice { get; set; }

          public Color FifthChoice { get; set; }

          public Color SixthChoice { get; set; }

          public Color SeventhChoice { get; set; }
     }

     public enum Color
          {
               Unknown,
               Red,
               Orange,
               Yellow,
               Green,
               Blue,
               Purple,
               Pink
          }
}
