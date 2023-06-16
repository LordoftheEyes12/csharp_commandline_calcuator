public class Rechenoperationen
{
    public static double calc(double a, double b, string op)
    {

        if (op == "+")
        {
            return plus(a, b);

        }
        else if (op == "-")
        {
            return minus(a, b);
        }
        else if (op == "*")
        {
            return mal(a, b);
        }
        else if (op == "/")
        {
            return durch(a, b);
        }
        else if (op == "^")
        {
            return potenz(a, b);

        }
        else if (op == "hyp")
        {
            return hypothenuse(a, b);
        }
        else if (op == "sqrt")
        {
            return sqrt(a);
        }
        else if (op == "kathete")
        {
            return kathete(a, b);
        }
        else if (op == "flaeche")
        {
            return flaeche(a, b);
        }
        else if (op == "wurzel")
        {
            return wurzel(a, b);
        }
        else
        {
            Console.WriteLine("Falsche Eingabe");
            return double.NaN;
        }

    }

    static double mal(double a, double b)
    {
        return a * b;
    }
    static double durch(double a, double b)
    {
        return a / b;
    }

    static double plus(double a, double b)
    {
        return a + b;
    }
    static double minus(double a, double b)
    {
        return a - b;
    }

    static double hypothenuse(double a, double b)
    {
        return (double)Math.Sqrt(a * a + b * b);
    }
    static double potenz(double a, double b)
    {
        return (double)Math.Pow(a, b);
    }

    static double sqrt(double a)
    {
        return (double)Math.Sqrt(a);
    }
    static double kathete(double a, double b)
    {
        if (a > b)
        {
            return (double)Math.Sqrt(a * a - b * b);
        }
        else if (b > a)
        {
            return (double)Math.Sqrt(b * b - a * a);
        }
        return 0;
    }
    static double flaeche(double a, double b)
    {
        return a * b / 2;
    }
    static double wurzel(double a, double b)
    {
        return (double)Math.Pow(a, 1 / b);
    }
}