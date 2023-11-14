using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name)
            : base(name)
        {
            
        }
        
        public override string ChooseGesture()
        {

            while (true)
            {
                Console.WriteLine("Choose 1 gesture. Rock, Paper, Scissors, Lizard or Spock");
                string chosenGesture = Console.ReadLine();
                
                if (chosenGesture == "Rock" || chosenGesture == "Paper" || chosenGesture == "Scissors" || chosenGesture == "Lizard" || chosenGesture == "Spock")
                {
                    return chosenGesture;
                }
                else
                {
                    Console.WriteLine("Invalid Selection, Please Try Again");
                }
                

                
            }
            
        }
    }
}
