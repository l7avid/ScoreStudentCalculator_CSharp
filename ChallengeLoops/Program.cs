namespace ChallengeLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            RequestScoreMessage();
            AverageStudentsScoreCalculator();
        }

        static void AverageStudentsScoreCalculator()
        {
            string scoreString = "0";
            int individualScore = 0;
            int counter = 1;
            double averageScore;
            int totalScore = 0;
            while (scoreString != "-1")
            {
                scoreString = Console.ReadLine();

                if (scoreString.Equals("-1"))
                {
                    UILines();
                    averageScore = (double)totalScore / ((double)counter - 1);
                    PrintAverageScoreMessage(averageScore);
                    ExitMessage();


                }
                if(int.TryParse(scoreString, out individualScore) && individualScore >= 0 && individualScore <= 20)
                {
                    totalScore += individualScore;
                    RequestScoreMessage();
                }
                else
                {
                    if (!(scoreString.Equals("-1")))
                    {
                        WrongScoreInputMessage();
                    }
                    continue;
                }
                counter++;
            }
        }

        static void RequestScoreMessage()
        {
            Console.WriteLine("Please enter a score: ");
        }

        static void UILines()
        {
            Console.WriteLine("-------------------------------------");
        }

        static void WrongScoreInputMessage()
        {
            Console.WriteLine("Score must be greater or equal than zero and less or equal than twenty");
        }

        static void PrintAverageScoreMessage(double averageScore)
        {
            Console.WriteLine($"Average score is: {averageScore}");
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Average Score Student Calculator (ASSC)");
            Console.WriteLine("Score must be greater or equal than zero and less or equal than twenty");
            Console.WriteLine("Once you have entered all the scores or whenever you want enter -1 to calculate average");
        }

        static void ExitMessage()
        {
            Console.WriteLine("Press enter to exit the program");
        }
    }
}