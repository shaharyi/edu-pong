using System;

public class Sprite
{
    public double x;
    public double y;
    public int yLen;
    public int xLen;
    public char glyph;
    public double maxSpeed;
    protected double dir;
    double speed;
    protected double xSpeed, ySpeed;

    public Sprite()
    { }

    public Sprite(double _x, double _y, char _glyph, double _maxSpeed = 0, double _speed = 0, double _dir = 0)
    {
        x = _x;
        y = _y;
        yLen = 1;
        xLen = 1;
        glyph = _glyph;
        maxSpeed = _maxSpeed;
        SetSpeed(_speed);
        dir = _dir;
    }

    public void Draw()
    {
        int roundedY = (int)(y + 0.5);
        int roundedX = (int)(x + 0.5);
        for (int i = 0; i < yLen; i++)
        {
            Console.SetCursorPosition(roundedX, roundedY + i);
            for (int j = 0; j < xLen; j++)
            {
                Console.Write(glyph);
            }
        }
    }

    public void DrawInColor(ConsoleColor color)
    {
        ConsoleColor tmpColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Draw();
        Console.ForegroundColor = tmpColor;
    }

    public virtual void TestLimits()
    {
        int rx = (int)(x + 0.5);
        int ry = (int)(y + 0.5);
        if (rx + xLen - 1 > Pong.maxX && xSpeed > 0 ||
            ry + yLen - 1 > Pong.maxY && ySpeed > 0 ||
            rx <= Pong.minX && xSpeed < 0 ||
            ry <= Pong.minY && ySpeed < 0)
            SetSpeed(0);
    }

    public void Move(int timeDeltaMillis)
    {
        DrawInColor(Console.BackgroundColor);
        y += ySpeed * timeDeltaMillis / 1000;
        x += xSpeed * timeDeltaMillis / 1000;
        TestLimits();
        DrawInColor(Console.ForegroundColor);
    }

    public void SetSpeed(double _speed)
    {
        speed = _speed;
        xSpeed = Math.Round(Math.Cos(dir) * speed, 5);
        ySpeed = -Math.Round(Math.Sin(dir) * speed, 5);
    }
    public double GetSpeed() { return speed; }

    public void SetDir(double _dir)
    {
        dir = _dir;
        SetSpeed(speed);
    }
}