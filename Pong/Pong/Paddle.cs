using System;

public class Paddle : Sprite
{
    public char upChar, downChar, stopChar;

    public Paddle(double _x, char _upChar, char _downChar, char _stopChar)
        : base(_x, 0, '#', Pong.PADDLE_MAX_SPEED)
    {
        yLen = Pong.PADDLE_LEN;
        y = Pong.midY - yLen / 2;
        upChar = _upChar;
        downChar = _downChar;
        stopChar = _stopChar;
    }

    public void UpdateSpeedAlgo()
    {
        SetSpeed(maxSpeed);
        double paddleMidY = y + yLen / 2 + 0.5;
        if (paddleMidY > Pong.instance.ball.y)
            SetDir(Pong.UP);
        else
            SetDir(Pong.DOWN);
        if (Pong.instance.ball.y + yLen / 2 >= Pong.maxY ||
            Pong.instance.ball.y - yLen / 2 <= Pong.minY)
            SetSpeed(0);
    }

    public void UpdateSpeed(char c)
    {
        if (c == stopChar)
            SetSpeed(0);
        else if (c == upChar)
        {
            SetSpeed(maxSpeed);
            SetDir(Pong.UP);
        }
        else if (c == downChar)
        {
            SetSpeed(maxSpeed);
            SetDir(Pong.DOWN);
        }
    }
}
