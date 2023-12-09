using Problems;

while (true)
{
    Console.Write("Enter Expresion: ");
    var input = Console.ReadLine()!;
    var exp = app.Run(input);
    Calculate(exp.LeftSideOperent, exp.operation, exp.RightSideOperent);
}

void Calculate(double left, Operation operation, double right)
{
    if (operation == Operation.Addition)
        Console.WriteLine("Answer = " + (left + right));
    else if (operation == Operation.Subtraction)
        Console.WriteLine("Answer = " + (left - right));
    else if (operation == Operation.Multiplication)
        Console.WriteLine("Answer = " + (left * right));
    else if (operation == Operation.Division)
        Console.WriteLine("Answer = " + (left / right));
    else if (operation == Operation.Power)
        Console.WriteLine("Answer = " + (Math.Pow(left, right)));
    else if (operation == Operation.Modulus)
        Console.WriteLine("Answer = " + (left % right));
    else if (operation == Operation.Sin)
        Console.WriteLine("Answer = " + (Math.Sin(right)));
    else if (operation == Operation.Cos)
        Console.WriteLine("Answer = " + (Math.Cos(right)));
    else if (operation == Operation.Tan)
        Console.WriteLine("Answer = " + (Math.Tan(right)));
}