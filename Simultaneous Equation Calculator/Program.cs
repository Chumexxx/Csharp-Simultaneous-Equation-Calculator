// Variables declaration
double a, b, c, d, e, f, determinant;

// Welcome Message
Console.WriteLine("Welcome to CHUKWUEMEKA'S SIMULTANEOUS EQUATION CALCULATOR");
Console.WriteLine();

Console.WriteLine("This calculator will help you perform simultaneous equation seamlessly by taking in your \na(x), b(y) and c values in the first equation and d(x), e(y) and f values in the second equation and output the values of X and Y.");
Console.WriteLine();

Console.WriteLine("It would take this format \nAx + By = C\nDx + Ey = F");
Console.WriteLine();

bool tryAgain = true;

while (tryAgain)
{
    try
    {
        // First Equation
        Console.Write("Enter a: ");
        a = Convert.ToDouble(Console.ReadLine());
        ValidateCoefficient(a, "a");

        Console.Write("Enter b: ");
        b = Convert.ToDouble(Console.ReadLine());
        ValidateCoefficient(b, "b");

        Console.Write("Enter c: ");
        c = Convert.ToDouble(Console.ReadLine());
        ValidateCoefficient(c, "c");

        Console.WriteLine();
        Console.WriteLine("This is your first equation: " + a + "x + " + b + "y = " + c);
        Console.WriteLine();
        Console.WriteLine("You can now write your second equation.");
        Console.WriteLine();

        // Second Equation
        Console.Write("Enter d ");
        d = Convert.ToDouble(Console.ReadLine());
        ValidateCoefficient(d, "d");

        Console.Write("Enter e: ");
        e = Convert.ToDouble(Console.ReadLine());
        ValidateCoefficient(e, "e");

        Console.Write("Enter f: ");
        f = Convert.ToDouble(Console.ReadLine());
        ValidateCoefficient(f, "f");

        Console.WriteLine();
        Console.WriteLine("This is your second equation: " + d + "x + " + e + "y = " + f);
        Console.WriteLine();
        Console.WriteLine("First equation:   " + a + "x + " + b + "y = " + c);
        Console.WriteLine("Second equation: " + d + "x + " + e + "y = " + f);

        // Calculate the determinant
        determinant = a * e - d * b;
        if (determinant != 0)
        {
            double x = (c * e - f * b) / determinant;
            double y = (a * f - d * c) / determinant;

            // Print the solution
            Console.WriteLine("The solution is: x = " + x + " and y = " + y);
        }
        else
        {
            Console.WriteLine("The equations have no unique solution (determinant is zero).");
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }

    // Ask the user if they want to try again or exit
    Console.WriteLine("\nWould you like to solve another set of equations? ('yes' to continue, any other key to exit)");
    string userChoice = Console.ReadLine().ToLower();

    if (userChoice != "yes")
    {
        tryAgain = false;
        Console.WriteLine("Thank you for using the Simultaneous Equation Calculator. Goodbye!");
    }
}
Console.WriteLine();

Console.ReadLine();

static void ValidateCoefficient(double coefficient, string variableName)
{
    if (coefficient == 0)
    {
        throw new FormatException($"Invalid coefficient for '{variableName}'. Coefficient cannot be 0. Please try again.");
    }
}
