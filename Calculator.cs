namespace WorkWithInterfaces
{
    internal class Calculator
    {
        public static Operand Add(Operand first, Operand second)
        {
            return new Operand(first.Value + second.Value);
        }

        public static Operand Divide(Operand first, Operand second)
        {
            if (second.Value == 0)
                throw new DivideByZeroException("Divide by zero isn't possible");
            else
                return new Operand(first.Value / second.Value);
        }

        public static Operand Substract(Operand first, Operand second)
        {
            return new Operand(first.Value - second.Value);
        }

        public static Operand Multiply(Operand first, Operand second)
        {
            return new Operand(first.Value * second.Value);
        }
    }
}
