namespace Calculator.Core
{
    public abstract class Calculator
    {
        public abstract double Calculate(double x, double y);
    }

    public class Addition : Calculator
    {
        public override double Calculate(double x, double y)
        {
            return x + y;
        }
    }

    public class Subtraction : Calculator
    {
        public override double Calculate(double x, double y)
        {
            return x - y;
        }
    }

    public class Multiplication : Calculator
    {
        public override double Calculate(double x, double y)
        {
            return x * y;
        }
    }

    public class Division : Calculator
    {
        public override double Calculate(double x, double y)
        {
            if (y != 0)
                return x / y;
            else
                throw new DivideByZeroException("Cannot divide by zero!");
        }
    }

    
}
