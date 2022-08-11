namespace WorkWithInterfaces
{
    interface IValue
    {
        double Value { get; }
    }

    interface INamed
    {
        string GetTransaction { get; }
    }

    interface IOperation
    {
        char OperationName { get; set; }
    }

    class Operand : IValue, INamed
    {
        public Operand() { }
        public Operand(double value, string name = "")
        {
            Value = value;
            GetTransaction = name;
        }

        public double Value { get; set; }
        public string GetTransaction { get; set; }
    }



    class Operation : IOperation, INamed
    {
        public char OperationName { get; set; }
        public string GetTransaction { get; set; } = "";
    }
}
