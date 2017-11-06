using System;
using System.Threading;

class Stage2
{
    static void Main(string[] args)
    {
        const int PADDLE_LEN = 6;
        const double PADDLE_MAX_SPEED = 10;
        const int MILLISEC_SLEEP = 50;
        int midY = (Console.WindowHeight - PADDLE_LEN) / 2;
        int maxY = Console.WindowHeight - 1;
        int midX = Console.WindowWidth / 2;
        double leftPaddleSpeed = 0;
        double leftPaddleY = midY;
        Console.CursorVisible = false;
        char c;
        bool exit = false;
        while (!exit)
        {
            DrawPaddle((int)leftPaddleY, PADDLE_LEN, Console.BackgroundColor);
            if ((leftPaddleY > 0 || leftPaddleSpeed > 0) &&
                (leftPaddleY < maxY || leftPaddleSpeed < 0))
                leftPaddleY += leftPaddleSpeed * MILLISEC_SLEEP / 1000;
            DrawPaddle((int)leftPaddleY, PADDLE_LEN, Console.ForegroundColor);
            if (Console.KeyAvailable)
            {
                c = Console.ReadKey(true).KeyChar;
                if (c == 'q')
                    exit = true;
                leftPaddleSpeed = UpdateLeftPaddleSpeed(c, PADDLE_MAX_SPEED);
            }
            Thread.Sleep(MILLISEC_SLEEP);
        }
    }

    static double UpdateLeftPaddleSpeed(char c, double maxSpeed)
    {
        double speed = maxSpeed;
        switch (c)
        {
            case 'a':
                speed = -maxSpeed;
                break;
            case 'z':
                speed = maxSpeed;
                break;
            case 's':
                speed = 0;
                break;
        }
        return speed;
    }

    static void DrawPaddle(int y, int len, ConsoleColor color)
    {
        ConsoleColor tmpColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        for (int i = 0; i < len; i++)
        {
            Console.SetCursorPosition(0, y + i);
            Console.Write("@");
        }
        Console.ForegroundColor = tmpColor;
    }
}
