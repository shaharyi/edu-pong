using System;

public class Ball : Sprite
{
    public Ball() : base(0, 0, 'O', Pong.BALL_MAX_SPEED)
    {
        Reset();
    }

    public void Start(double _dir)
    {
        SetDir(_dir);
        SetSpeed(Pong.BALL_SPEED);
    }

    public void Bounce(Paddle paddle)
    {
        const double MAX_BOUNCE_ANGLE = 5 * Math.PI / 12;
        double relativeIntersectY = paddle.y + (paddle.yLen / 2 - 0.5) - y;
        double normalizedRelativeIntersectionY = (relativeIntersectY / (paddle.yLen / 2));
        double bounceAngle = normalizedRelativeIntersectionY * MAX_BOUNCE_ANGLE;
        if (xSpeed > 0)
            SetDir(Math.PI - bounceAngle);
        else
        {
            if (bounceAngle < 0)
                SetDir(2 * Math.PI + bounceAngle);
            else
                SetDir(bounceAngle);
        }
        Console.Beep(440, 100);
    }

    public void Reset()
    {
        x = Pong.midX;
        y = Pong.midY;
        SetSpeed(0);
    }

    public override void TestLimits()
    {
        int rx = (int)(x + 0.5);
        int ry = (int)(y + 0.5);
        // bounce from walls
        if (ry + yLen - 1 > Pong.maxY && ySpeed > 0 || ry < Pong.minY && ySpeed < 0)
            SetDir(2 * Math.PI - dir);
        // test if hit paddle
        Paddle paddle = null;
        if (rx + xLen >= Pong.maxX)
            paddle = Pong.instance.rightPaddle;
        if (rx <= Pong.minX)
            paddle = Pong.instance.leftPaddle;
        if (paddle != null)
        {
            double diff = y - paddle.y;
            if (diff >= 0 && diff <= paddle.yLen)
                Bounce(paddle);
            else
                Pong.instance.Point(Math.Sign(xSpeed));
        }
    }
}
