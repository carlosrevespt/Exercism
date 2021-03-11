using System;

public static class Triangle
{
    private static bool equilateral = false;
    private static bool isosceles = false;
    private static bool scalene = false;
    private static bool degenerate = false;

    public static bool IsScalene(double side1, double side2, double side3)
    {
        checkTriangle((side1, side2, side3));
        return (scalene);
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        checkTriangle((side1, side2, side3));
        return (isosceles);
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        checkTriangle((side1, side2, side3));
        return (equilateral);
    }

    public static bool IsDegenerate(double side1, double side2, double side3)
    {
        checkTriangle((side1, side2, side3));
        return degenerate;
    }

    private static void checkTriangle((double, double, double) sides)
    {
        equilateral = false;
        isosceles = false;
        scalene = false;

        degenerate = (sides.Item1 + sides.Item2 == sides.Item3) ||
                     (sides.Item1 + sides.Item3 == sides.Item2) ||
                     (sides.Item3 + sides.Item2 == sides.Item1);

        bool valid = !degenerate &&
                (sides.Item1 > 0 && sides.Item2 > 0 && sides.Item3 > 0) &&
                (sides.Item1 + sides.Item2 >= sides.Item3) &&
                (sides.Item1 + sides.Item3 >= sides.Item2) &&
                (sides.Item3 + sides.Item2 >= sides.Item1);

        if (valid)
        {
            if (sides.Item1 == sides.Item2 &&
                sides.Item2 == sides.Item3)
            {
                equilateral = true;
                isosceles = true;
            }
            else if (sides.Item1 == sides.Item2 ||
                     sides.Item1 == sides.Item3 ||
                     sides.Item3 == sides.Item2)
            {
                isosceles = true;
            }
            else
                scalene = true;
        }

    }
}