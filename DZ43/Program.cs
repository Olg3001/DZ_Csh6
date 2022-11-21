// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Programm to find the intersection point of two lines with formulas: y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Input numbers for variables b1, k1, b2, k2. Press 'Enter' after every input.");

Console.Write("b1 =\t");
int b1 = int.Parse(Console.ReadLine()!);

Console.Write("k1 =\t");
int k1 = int.Parse(Console.ReadLine()!);

Console.Write("b2 =\t");
int b2 = int.Parse(Console.ReadLine()!);

Console.Write("k2 =\t");
int k2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("\nThe equations are:");
Console.WriteLine($"y = {k1} * x + {b1}");
Console.WriteLine($"y = {k2} * x + {b2}");

double GetX()
{
    double x = (double)(b2 - b1) / (k1 - k2);
    return x;
}

double GetY(double x)
{
    double y = k1 * x + b1;
    return y;
}

double x = GetX();
double y = GetY(x);

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("\nThese two lines agree exactly.");
}
else
{
    Console.WriteLine($"\nThe intersection point coordinates are: ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}
