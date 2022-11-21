// задача 40 - HARD необязательная. На вход программы подаются три целых 
// положительных числа. Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения 
// углов треугольника в градусах, является ли он прямоугольным, равнобедренным, 
// равносторонним

Console.WriteLine("Programm to check if triangle with inputed sides is possible and to get the information about it.");

Console.Write("\nInput side a:\t");
double a = double.Parse(Console.ReadLine()!);

Console.Write("Input side b:\t");
double b = double.Parse(Console.ReadLine()!);

Console.Write("Input side c:\t");
double c = double.Parse(Console.ReadLine()!);

bool TriangleIsPossible(double a, double b, double c)
{
    bool check = false;

    if (a + b > c
        && a + c > b
        && b + c > a)
    {
        check = true;
    }

    return check;
}
bool result = TriangleIsPossible(a, b, c);

double GetPerimeter(double a, double b, double c)
{
    double perimeter = a + b + c;
    return perimeter;
}

double GetSquare(double a, double b, double c)
{
    double semiPerimeter = (double)GetPerimeter(a, b, c) / 2;
    double result = semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c);
    double square = Math.Sqrt(result);
    return Math.Round(square, 2);
}

if (result)
{
    Console.WriteLine("\nThe triangle is possible.");

    double perimeter = GetPerimeter(a, b, c);
    Console.WriteLine($"The triangle perimeter is {perimeter}.");

    double square = GetSquare(a, b, c);
    Console.WriteLine($"The triangle square is {square}.");

    double firstAngle = Math.Acos((double)(b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
    double secondAngle = Math.Acos((double)(a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
    double thirdAngle = Math.Acos((double)(a * a + b * b - c * c) / (2 * b * a)) * 180 / Math.PI;

    Console.WriteLine($"The first triangle angle is {Math.Round(firstAngle, 2)}°.");
    Console.WriteLine($"The second triangle angle is {Math.Round(secondAngle, 2)}°.");
    Console.WriteLine($"The third triangle angle is {Math.Round(thirdAngle, 2)}°.");

    if (a * a == b * b + c * c
        || b * b == a * a + c * c
        || c * c == a * a + b * b)
        Console.WriteLine("The triangle is right-angled.");
    else if (a == b
            || b == c
            || a == c)
        Console.WriteLine("The triangle is isosceles.");
    else if (a == b
            && b == c)
        Console.WriteLine("The triangle is equalateral.");
    else Console.WriteLine("The triangle is arbitory.");
}
else Console.WriteLine("\nThe triagle is impossible.");
