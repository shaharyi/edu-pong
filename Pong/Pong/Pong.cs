using System;
using System.Threading;

public class Pong
{
    public const int PADDLE_LEN = 8;
    public const double PADDLE_MAX_SPEED = 20;
    const int MILLISEC_SLEEP = 25;
    static public double BALL_MAX_SPEED = 100;
    static public double BALL_SPEED = 80;
    static public int maxY;
    static public int maxX;
    static public int minY = 1;
    static public int minX = 0;
    static public int midY;
    static public int midX;
    const double QUARTER = Math.PI / 2;
    public const double RIGHT = 0 * QUARTER;
    public const double UP = 1 * QUARTER;
    public const double LEFT = 2 * QUARTER;
    public const double DOWN = 3 * QUARTER;
    public static Pong instance;
    public Paddle leftPaddle;
    public Paddle rightPaddle;
    public Ball ball;
    public int leftScore = 0;
    public int rightScore = 0;
    public double startDir = LEFT;

    static void Main()
    {
        Console.CursorVisible = false;
        Console.SetWindowSize(120, 30);
        maxY = Console.WindowHeight - 2;
        maxX = Console.WindowWidth - 1;
        midY = Console.WindowHeight / 2;
        midX = Console.WindowWidth / 2;

        Pong.instance = new Pong();
        Pong.instance.GameLoop();
    }

    public void Point(int which)
    {
        if (which == 1)
        {
            leftScore++;
            startDir = LEFT;
        }
        else
        {
            rightScore++;
            startDir = RIGHT;
        }
        ball.Reset();
        Console.Beep(880, 300);
    }

    public void ShowScore()
    {
        string s = new string(' ', (int)(maxX / 4) - 10) + leftScore.ToString() +
            new string(' ', 16) + rightScore.ToString();
        string scoreBanner = banner.Banner.CreateBanner(s, "%", " ", " ", false);
        Console.SetCursorPosition(0, 1);
        Console.Write(scoreBanner);
        /*
        Console.SetCursorPosition(maxX * 1 / 4, 10);
        Console.Write(rightScore);
        Console.SetCursorPosition(maxX * 3 / 4, 10);
        Console.Write(rightScore);
        */
    }

    public void GameLoop()
    {
        bool computerPlayer = true;
        Sprite net = new Sprite(midX, 0, '|');
        net.yLen = Console.WindowHeight;
        leftPaddle = new Paddle(0, 'a', 'z', 's');
        rightPaddle = new Paddle(maxX, 'j', 'm', 'k');
        ball = new Ball();
        ball.Reset();
        char c;
        bool exit = false;
        while (!exit)
        {
            if (Console.KeyAvailable)
            {
                c = Console.ReadKey(true).KeyChar;
                if (c == 'q')
                    exit = true;
                if (c == ' ' && ball.GetSpeed() == 0)
                    ball.Start(startDir);
                leftPaddle.UpdateSpeed(c);
                if (!computerPlayer)
                    rightPaddle.UpdateSpeed(c);
            }
            if (computerPlayer)
                rightPaddle.UpdateSpeedAlgo();
            Thread.Sleep(MILLISEC_SLEEP);
            ShowScore();
            net.Draw();
            leftPaddle.Move(MILLISEC_SLEEP);
            rightPaddle.Move(MILLISEC_SLEEP);
            ball.Move(MILLISEC_SLEEP);
        }
    }
}
