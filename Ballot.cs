using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankedChoiceVotingApp
{
     public class Ballot
     {
          public Ballot_DTO Choices { get; private set; }
          public int Level { get; set; } //first, second, third....etc.

          public Ballot(Ballot_DTO dto)
          {
               Choices = dto;
               Level = 1; //start at one for First, and increment from there.
          }

          public Color ReturnNextChoice()
          {
               Color choice;
               switch(Level)
               {
                    case 1:
                         choice = Choices.FirstChoice;
                         break;
                    case 2:
                         choice = Choices.SecondChoice;
                         break;
                    case 3:
                         choice = Choices.ThirdChoice;
                         break;
                    case 4:
                         choice = Choices.FourthChoice;
                         break;
                    case 5:
                         choice = Choices.FifthChoice;
                         break;
                    case 6:
                         choice = Choices.SixthChoice;
                         break;
                    case 7:
                         choice = Choices.SeventhChoice;
                         break;
                    default:
                         choice = Color.Unknown;
                         break;
               }
               if(Level < 7)
               {
                    Level++;
               }
               return choice;
          }
     }
}
