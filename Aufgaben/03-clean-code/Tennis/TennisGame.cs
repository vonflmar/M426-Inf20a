using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGameManager
    {
        private int playerOneScore;
        private int playerTwoScore;
        private string playerOneResult = "";
        private string playerTwoResult = "";
        private string playerOneName;
        private string playerTwoName;

        public TennisGameManager(string playerOneName,
            string playerTwoName)
        {
            this.playerOneName = playerOneName;
            playerOneScore = 0;
            this.playerTwoName = playerTwoName;
        }

        public string getScore()
        {
            var score = "";
            if (playerOneScore == playerTwoScore && playerOneScore < 3)
            {
                if (playerOneScore == 0)
                {
                    score = "Love";
                }
                if (playerOneScore == 1)
                {
                    score = "Fifteen";
                }
                if (playerOneScore == 2)
                {
                    score = "Thirty";
                }
                score += "-All";
            }
            if (playerOneScore == playerTwoScore && playerOneScore > 2)
            {
                score = "Deuce";
            }

            if (playerOneScore > 0 && playerTwoScore == 0)
            {
                if (playerOneScore == 1)
                    playerOneResult = "Fifteen";
                if (playerOneScore == 2)
                    playerOneResult = "Thirty";
                if (playerOneScore == 3)
                    playerOneResult = "Forty";

                playerTwoResult = "Love";
                score = playerOneResult + "-" + playerTwoResult;
            }
            if (playerTwoScore > 0 && playerOneScore == 0)
            {
                var temp = playerTwoScore;
                if (temp == 1)
                    playerTwoResult = "Fifteen";
                else
                {

                }
                if (temp == 2)
                    playerTwoResult = "Thirty";
                if (temp == 3)
                    playerTwoResult = "Forty";

                playerOneResult = "Love";
                score = playerOneResult + "-" + playerTwoResult;
            }
            if (playerOneScore > playerTwoScore && playerOneScore < 4)
            {
                if (playerOneScore == 2)
                    playerOneResult = "Thirty";
                if (playerOneScore == 3)
                    playerOneResult = "Forty";
                if (playerTwoScore == 1)
                    playerTwoResult = "Fifteen";
                if (playerTwoScore == 2)
                    playerTwoResult = "Thirty";
                score = playerOneResult + "-" + playerTwoResult;
            }

            if (playerTwoScore > playerOneScore && playerTwoScore < 4)
            {
                if (playerTwoScore == 2)
                    playerTwoResult = "Thirty";
                if (playerTwoScore == 3)
                    playerTwoResult = "Forty";
                if (playerOneScore == 1)
                    playerOneResult = "Fifteen";
                if (playerOneScore == 2)
                    playerOneResult = "Thirty";
                score = playerOneResult + "-" + playerTwoResult;
            }

            if (playerOneScore > playerTwoScore && playerTwoScore >= 3)
            {
                score = "Advantage player1";
            }

            if (playerTwoScore > playerOneScore && playerOneScore >= 3)
            {
                score = "Advantage player2";
            }

            if (playerOneScore >= 4 && playerTwoScore >= 0 && (playerOneScore - playerTwoScore) >= 2)
            {
                score = "Win for player1";
            }
            score = returnWinForPlayerOneIfWon(score, playerOneScore, playerTwoScore);
            return score;
        }

        private static string generatePlayerTwoName()
        {
            return "Advantage player2";
        }

        public string returnWinForPlayerOneIfWon(string score, int playerOneScore, int playerTwoScore)
        {
            if (playerTwoScore >= 4 && playerOneScore >= 0 && (playerOneScore - playerTwoScore) >= 2)
            {
                return "Win for player2";
            }
            return score;
        }

        public void setPlayerOneScore(int number)
        {
            for (int i = 0; i < number; i++)
            {
                getPlayerOneScore();
            }
        }

        public void setPlayerTwoScore(int number)
        {
            for (var i = 0; i < number; i++)
            {
                getPlayerTwoScore();
            }
        }

        private void getPlayerOneScore() => playerOneScore++;
        private void getPlayerTwoScore() => playerTwoScore++;

        public void wonPoint(string tennisPlayer)
        {
            if (tennisPlayer == "player1")
            {
                getPlayerOneScore();
            }
            else
                getPlayerTwoScore();
        }
    }
}

