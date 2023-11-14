using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string name)
            : base(name)
        {
        
        }
        public override string ChooseGesture()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 5);

            if (randomNumber == 1) 
            {
                string gesture = this.gestures[1];
                return gesture;
            }
            else if (randomNumber == 2)
            {
                string gesture = this.gestures[2];
                return gesture;
            }
            else if (randomNumber == 3)
            {
                string gesture = this.gestures[3];
                return gesture;
            }
            else if (randomNumber == 4)
            {
                string gesture = this.gestures[4];
                return gesture;
            }
            else if (randomNumber == 5)
            {
                string gesture = this.gestures[5];
                return gesture;
            }
            else
            {
                Console.WriteLine("Error in Computer Player Class");
                return "";
            }
            
        }
    }
}
