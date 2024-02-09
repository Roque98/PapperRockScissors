

namespace RockPapperScissors
{
    public class Game
    {
        /* Estadistic */
        public int TotalGames { get; set; }
        public int TotalWinGames { get; set; }
        public int PercentWinGames { get; set; }
        public int TotalRounds { get; set; }
        public int TotalWinRounds { get; set; }
        public int PercentWinRounds { get; set; }

        /* Game */
        public int ActualNumberOfGame { get; set; }
        public int TotalRoundsOfActualGame { get; set; }
        public int ActualNumberRoundOfGame { get; set; }
        public bool HumanWinsRound { get; set; }
        public int HumanActualNumberRoundsWins { get; set; }
        public int OponentActualNumberRoundsWins { get; set; }
        public MovementsChoicesGame HumanActualMovementChoice { get; set; }
        public MovementsChoicesGame OponentActualMovementChoice { get; set; }
        public ResultOfGame ResultOfActualGame { get; set; }
        public ResultOfGame ResultOfActualRound { get; set; }

        public Game()
        {
            TotalGames = 0;
            TotalWinGames = 0;
            PercentWinGames = 0;
            TotalRounds = 0;
            TotalWinRounds = 0;
            PercentWinRounds = 0;

            ActualNumberRoundOfGame = 0;
            TotalRoundsOfActualGame = 0;
            ActualNumberOfGame = 0;
            HumanWinsRound = true;
            HumanActualNumberRoundsWins = 0;
            HumanActualMovementChoice = MovementsChoicesGame.Paper;
            OponentActualNumberRoundsWins = 0;
            OponentActualMovementChoice = MovementsChoicesGame.Paper;
            ResultOfActualGame = ResultOfGame.HumanWon;
            ResultOfActualRound = ResultOfGame.HumanWon;
        }

        public enum MovementsChoicesGame
        {
            Paper,
            Rock,
            Scissors
        };

        public enum ResultOfGame
        {
            HumanWon,
            HumanLost,
            Tie
        };

        public string getTextForIntro()
        {
            return
            $"Title of game: Papper, rock and scissors" + "\n" +
             "\n" +
            $"Total games: {TotalGames}" + "\n" +
            $"Total win games: {TotalWinGames}" + "\n" +
            $"Percent win games: {PercentWinGames}" + "\n" +
            $"Total rounds: {TotalRounds}" + "\n" +
            $"Total win rounds: {TotalWinRounds}" + "\n" +
            $"Perecent win rounds: {PercentWinRounds}" + "\n" +
            "\n" +
            $"Press Enter to start new game o Escape to exit.";


        }

        public string getTextForRequestNumberOfRoudsWinToFinishGame()
        {
            return
                $"Press the number of rounds to win the game {ActualNumberOfGame}";                
        }
        
        public string getTextForConfirmConfigurationToGame()
        {
            return
                $"You have selected {TotalRoundsOfActualGame} rounds to win the game {ActualNumberOfGame}. Its that okay?" + "\n" +
                $"Press one option:" + "\n" +
                $"\t1) Yes" + "\n" +
                $"\t2) No";

        }

        public string getTextForTheRoundScreen()
        {
            return
                $"Next screen(Start the ROUND):" + "\n" +
                $"Round {ActualNumberRoundOfGame}" + "\n" +
                $"" + "\n" +
                $"Number of rounds won" + "\n" +
                $"You: {HumanActualNumberRoundsWins}" + "\n" +
                $"opponent: {OponentActualNumberRoundsWins}" + "\n" +
                $"" + "\n" +
                $"Choice your next move:" + "\n" +
                $"\t1). Paper" + "\n" +
                $"\t2). Rock" + "\n" +
                $"\t3). Scissors";
        }


        public string getTextForResultOfRound()
        {
            if (ResultOfActualRound == ResultOfGame.HumanWon)
            {
                return "You win";
            }

            if(ResultOfActualRound == ResultOfGame.HumanLost)
            {
                return "The opponent are wins";
            }

            if (ResultOfActualRound == ResultOfGame.Tie)
            {
                return "Anyone's won. It's a tie";
            }

            return "";
        }

        public string getTextForTheResultOfMovement()
        {

            return
                $"Your choice: {HumanActualMovementChoice}" + "\n" +
                $"The opponent random choice: {OponentActualMovementChoice}" + "\n" +
                $"" + "\n" +
                $"{getTextForResultOfRound()}" + "\n" +
                $"" + "\n" +
                $"Press any key to start the next round.";
        }
    }
}