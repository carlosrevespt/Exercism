using System;

public static class Darts
{
    private const int OuterCircle = 10;
    private const int MiddleCircle = 5;
    private const int InnerCircle = 1;
    private const int OutsideTaget = 0;
    private const int InOuterCircle = 1;
    private const int InMiddleCircle = 5;
    private const int InInnerCircle = 10;
    
    public static int Score(double x, double y)
    {

        double distance = x * x + y * y;

        if (distance > OuterCircle * OuterCircle)
           return OutsideTaget;

        if (distance > MiddleCircle * MiddleCircle)
           return InOuterCircle;
        
        return distance > InnerCircle ? InMiddleCircle : InInnerCircle;
    }
}
