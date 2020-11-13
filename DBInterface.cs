using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace RankedChoiceVotingApp
{
     public class DBInterface
     {
          private readonly string connectionString;

          public static List<Ballot> GetBallots() // Retrieve all ballots from the database
          {
               ///These will become their own functions:
               // Query the db
               // Load each ballot with data
               // Load each ballot into the list
               return new List<Ballot>();
          }
     }
}
