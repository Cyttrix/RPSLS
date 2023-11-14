using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;
        public ComputerPlayer computer;
        int playerOneScore;
        int playerTwoScore;

        //Constructor
        public Game()
        {

            int userInput;
            int numberOfHumanPlayers = 0;
            playerOneScore = 0;
            playerTwoScore = 0;


        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissords decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("");
            Console.WriteLine("Game will be best out of 3!");
            Console.WriteLine("");
        }

        public int ChooseNumberOfHumanPlayers()
        {

            int numberOfHumanPlayers = 0;
            bool confirmation = false;

            try

            {
                while (confirmation == false)
                {
                    Console.WriteLine("Choose how many players will play the game, 1 or 2:");
                    int userInput = int.Parse(Console.ReadLine());



                    if (userInput == 1)
                    {

                        Console.WriteLine("You have selected 1 player");
                        confirmation = true;
                        numberOfHumanPlayers = 1;

                    }
                    if (userInput == 2)
                    {

                        Console.WriteLine("You have selected 2 player");
                        confirmation = true;
                        numberOfHumanPlayers = 2;
                    }
                }
        }
            catch
            {
                Console.WriteLine("Invalid selection, please pick 1 or 2:");

            }

            return numberOfHumanPlayers;
            

            
        }

    


            
           

            
            
   
            

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Choose your name player:");
                string playerOneName = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneName);

                string playerTwoName = "Computer";
                playerTwo = new ComputerPlayer(playerTwoName);
            }
            if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Player 1, Choose your name: ");
                string playerOneName = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneName);

                Console.WriteLine("Player 2, Choose your name: ");
                string playerTwoName = Console.ReadLine();
                playerTwo = new HumanPlayer(playerTwoName);
            }
            
  
            
        }

        public void CompareGestures(int round)
        {
            Console.WriteLine("");
            Console.WriteLine($"Round {round}");

            string playerOneName = playerOne.name;
            Console.WriteLine("");
            Console.WriteLine(playerOneName + "'s Turn");
            string playerOneGesture = playerOne.ChooseGesture();

            string playerTwoName = playerTwo.name;
            Console.WriteLine("");
            Console.WriteLine(playerTwoName + "'s Turn");
            string playerTwoGesture = playerTwo.ChooseGesture();

            Console.WriteLine("");
            Console.WriteLine(
                $"{playerOneName} chose {playerOneGesture}, {playerTwoName} chose {playerTwoGesture}"
                );
            
            if (playerOneGesture == "Rock" && playerTwoGesture == "Scissors") //Rock v Scissors (1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerOneName}'s {playerOneGesture} crushes {playerTwoName}'s {playerTwoGesture}");
                Console.WriteLine($"{playerOneName} Wins The Round!");
                Console.WriteLine("");
                playerOneScore++;
            }
            else if (playerTwoGesture == "Rock" && playerOneGesture == "Scissors") //Rock v Scissors (2)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerTwoName}'s {playerTwoGesture} crushes {playerOneName}'s {playerOneGesture}");
                Console.WriteLine($"{playerTwoName} Wins The Round!");
                Console.WriteLine("");
                playerTwoScore++;
            }
            else if (playerOneGesture == "Scissors" && playerTwoGesture == "Paper") //Scissors v Paper (1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerOneName}'s {playerOneGesture} cuts {playerTwoName}'s {playerTwoGesture}");
                Console.WriteLine($"{playerOneName} Wins The Round!");
                Console.WriteLine("");
                playerOneScore++;
            }
            else if (playerTwoGesture == "Scissors" && playerOneGesture == "Paper") //Scissors v Paper (2)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerTwoName}'s {playerTwoGesture} cuts {playerOneName}'s {playerOneGesture}");
                Console.WriteLine($"{playerTwoName} Wins The Round!");
                Console.WriteLine("");
                playerTwoScore++;
            }
            else if (playerOneGesture == "Paper" && playerTwoGesture == "Rock") //Paper v Rock (1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerOneName}'s {playerOneGesture} covers {playerTwoName}'s {playerTwoGesture}");
                Console.WriteLine($"{playerOneName} Wins The Round!");
                Console.WriteLine("");
                playerOneScore++;
            }
            else if (playerTwoGesture == "Paper" && playerOneGesture == "Rock") //Paper v Rock (2)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerTwoName}'s {playerTwoGesture} covers {playerOneName}'s {playerOneGesture}");
                Console.WriteLine($"{playerTwoName} Wins The Round!");
                Console.WriteLine("");
                playerTwoScore++;
            }
            else if (playerOneGesture == "Rock" && playerTwoGesture == "Lizard") //Rock v Lizard (1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerOneName}'s {playerOneGesture} crushes {playerTwoName}'s {playerTwoGesture}");
                Console.WriteLine($"{playerOneName} Wins The Round!");
                Console.WriteLine("");
                playerOneScore++;
            }
            else if (playerTwoGesture == "Rock" && playerOneGesture == "Lizard") //Rock v Lizard (2)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerTwoName}'s {playerTwoGesture} crushes {playerOneName}'s {playerOneGesture}");
                Console.WriteLine($"{playerTwoName} Wins The Round!");
                Console.WriteLine("");
                playerTwoScore++;
            }
            else if (playerOneGesture == "Lizard" && playerTwoGesture == "Spock") //Lizard v Spock (1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerOneName}'s {playerOneGesture} poisons {playerTwoName}'s {playerTwoGesture}");

                Console.WriteLine($"{playerOneName} Wins The Round!");
                Console.WriteLine("");
                playerOneScore++;
            }
            else if (playerTwoGesture == "Lizard" && playerOneGesture == "Spock") //Lizard v Spock (2)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerTwoName}'s {playerTwoGesture} poisons {playerOneName}'s {playerOneGesture}");
                Console.WriteLine($"{playerTwoName} Wins The Round!");
                Console.WriteLine("");
                playerTwoScore++;
            }
            else if (playerOneGesture == "Spock" && playerTwoGesture == "Scissors") //Spock v Scissors (1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerOneName}'s {playerOneGesture} smashes {playerTwoName}'s {playerTwoGesture}");
                Console.WriteLine($"{playerOneName} Wins The Round!");
                Console.WriteLine("");
                playerOneScore++;
            }
            else if (playerTwoGesture == "Spock" && playerOneGesture == "Scissors") //Spock v Scissors (2)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerTwoName}'s {playerTwoGesture} smashes {playerOneName}'s {playerOneGesture}");
                Console.WriteLine($"{playerTwoName} Wins The Round!");
                Console.WriteLine("");
                playerTwoScore++;
            }
            else if (playerOneGesture == "Scisssors" && playerTwoGesture == "Lizard") //Scissors v Lizard (1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerOneName}'s {playerOneGesture} decapitates {playerTwoName}'s {playerTwoGesture}");
                Console.WriteLine($"{playerOneName} Wins The Round!");
                Console.WriteLine("");
                playerOneScore++;
            }
            else if (playerTwoGesture == "Scissors" && playerOneGesture == "Lizard") //Scissors v Lizard (2)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerTwoName}'s {playerTwoGesture} decapitates {playerOneName}'s {playerOneGesture}");
                Console.WriteLine($"{playerTwoName} Wins The Round!");
                Console.WriteLine("");
                playerTwoScore++;
            }
            else if (playerOneGesture == "Lizard" && playerTwoGesture == "Paper") //Lizard v Paper (1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerOneName}'s {playerOneGesture} eats {playerTwoName}'s {playerTwoGesture}");
                Console.WriteLine($"{playerOneName} Wins The Round!");
                Console.WriteLine("");
                playerOneScore++;
            }
            else if (playerTwoGesture == "Lizard" && playerOneGesture == "Paper") //Lizard v Paper (2)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerTwoName}'s {playerTwoGesture} eats {playerOneName}'s {playerOneGesture}");
                Console.WriteLine($"{playerTwoName} Wins The Round!");
                Console.WriteLine("");
                playerTwoScore++;
            }
            else if (playerOneGesture == "Paper" && playerTwoGesture == "Spock") //Paper v Spock (1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerOneName}'s {playerOneGesture} disproves {playerTwoName}'s {playerTwoGesture}");
                Console.WriteLine($"{playerOneName} Wins The Round!");
                Console.WriteLine("");
                playerOneScore++;
            }
            else if (playerTwoGesture == "Paper" && playerOneGesture == "Spock") //Paper v Spock (2)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerTwoName}'s {playerTwoGesture} disproves {playerOneName}'s {playerOneGesture}");
                Console.WriteLine($"{playerTwoName} Wins The Round!");
                Console.WriteLine("");
                playerTwoScore++;
            }
            else if (playerOneGesture == "Spock" && playerTwoGesture == "Rock") //Spock v Rock (1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerOneName}'s {playerOneGesture} vaporizes {playerTwoName}'s {playerTwoGesture}");
                Console.WriteLine($"{playerOneName} Wins The Round!");
                Console.WriteLine("");
                playerOneScore++;
            }
            else if (playerTwoGesture == "Spock" && playerOneGesture == "Rock") //Spock v Rock (2)
            {
                Console.WriteLine("");
                Console.WriteLine($"{playerTwoName}'s {playerTwoGesture} vaporizes {playerOneName}'s {playerOneGesture}");
                Console.WriteLine($"{playerTwoName} Wins The Round!");
                Console.WriteLine("");
                playerTwoScore++;
            }
            else if (playerOneGesture == playerOneGesture)
            {
                Console.WriteLine("");
                Console.WriteLine("Tie!");
                Console.WriteLine("");
            }
            
            Console.WriteLine("Score:");
            Console.WriteLine($"{playerOneName}: {playerOneScore}");
            Console.WriteLine($"{playerTwoName}: {playerTwoScore}");

            
        }

        public void DisplayGameWinner()
        {
            if (playerOneScore == 2)
            {
                Console.WriteLine($"{playerOne.name} Wins the Game!");
            } 
            else if (playerTwoScore == 2) 
            {
                Console.WriteLine($"{playerTwo.name} Wins The Game!");
            }
        }

        public void RunGame()
        {
            
            WelcomeMessage();

            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();

            CreatePlayerObjects(numberOfHumanPlayers);

            int round = 1;
            while (playerOneScore < 2 || playerTwoScore < 2)
            {
                CompareGestures(round);
                if (playerOneScore == 2 ||  playerTwoScore == 2)
                {
                    break;
                }
                round ++;
            }
            
            DisplayGameWinner();
            

            
        }
    }
}
