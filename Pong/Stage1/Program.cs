using System;
class Stage1
{
    static void Main(string[] args)
    {
        int midY = Console.WindowHeight / 2;
        int midX = Console.WindowWidth / 2;
        double leftPaddleY = midY;
        double leftPaddleSpeed = 0;
        double ballSpeed = 1;
        double ballDir = 0;
        double ballX = midX;
        double ballY = midY;
        double ballXSpeed;
        double ballYSpeed;
        double deltaTime = 0;
        bool exit = false;
        while (!exit)
        {
            //drawPaddle(leftPaddleY);
            //drawBall(ballX, ballY);
            leftPaddleY += leftPaddleSpeed * deltaTime;
            ballXSpeed = ballSpeed * Math.Cos(ballDir);
            ballYSpeed = ballSpeed * Math.Sin(ballDir);
            ballX += ballXSpeed * deltaTime;
            ballY += ballYSpeed * deltaTime;
        }
    }
}
