using System;

public struct ComplexNumber
{
    private readonly double a;
    private readonly double b;

    public ComplexNumber(double real, double imaginary)
    {
        a = real;
        b = imaginary; 
    }

    public double Real() => a;

    public double Imaginary() => b;

    public ComplexNumber Mul(ComplexNumber other) => new ComplexNumber(a * other.a - b * other.b, b * other.a + a * other.b);

    public ComplexNumber Add(ComplexNumber other) => new ComplexNumber(a + other.a, b + other.b);

    public ComplexNumber Sub(ComplexNumber other) => new ComplexNumber(a - other.a, b - other.b);

    public ComplexNumber Div(ComplexNumber other)
    {
        double divReal = (a * other.a + b * other.b) / (other.a * other.a + other.b * other.b);
        double divImaginary = (b * other.a - a * other.b) / (other.a * other.a + other.b * other.b);

        return new ComplexNumber(divReal, divImaginary);
    }

    public double Abs() =>  Math.Sqrt(a * a + b * b);

    public ComplexNumber Conjugate() => new ComplexNumber(a, -b);
    
    public ComplexNumber Exp()
    {
        double expReal = Math.Exp(a) * Math.Cos(b);
        double expImaginary = Math.Exp(a) * Math.Sin(b);

        return new ComplexNumber(expReal, expImaginary);
    }
}