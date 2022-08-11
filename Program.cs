using WorkWithInterfaces;

class Program
{
    public static void LineProcessing(string line, ref Operand first, ref Operand second, ref Operation operation)
    {
        string firstOperand = "";
        string secondOperand = "";
        
        char[] operationSymbols = { '+', '-', '/', '*' };

        for (int i = 0; i < line.Length / 2; ++i)
        {
            if (char.IsNumber(line[i]))
                firstOperand += line[i];
            if (char.IsNumber(line[line.Length - i - 1]))
                secondOperand += line[line.Length - i - 1];
        }

        foreach (var i in line)
            if (operationSymbols.Contains(i))
            {
                operation.OperationName = i;
                break;
            }
        string revers = "";
        for (int i = secondOperand.Length - 1; i >= 0; --i)
            revers += secondOperand[i];

        first.Value = double.Parse(firstOperand);
        second.Value = double.Parse(revers);
    }

    public static void Main()
    {
        string expression = Console.ReadLine();
        Operand first = new Operand();
        Operand second = new Operand();
        Operation operation = new Operation();
        Operand result = new Operand();

        LineProcessing(expression, ref first, ref second, ref operation);

        switch (operation.OperationName)
        {
            case '+':
                result = Calculator.Add(first, second);
                break;
            case '-':
                result = Calculator.Substract(first, second);
                break;
            case '*':
                result = Calculator.Multiply(first, second);
                break;
            case '/':
                result = Calculator.Divide(first, second);
                break;
            default:
                throw new Exception("Invalid input data");
        }
        Console.WriteLine(result.Value);
    }
}