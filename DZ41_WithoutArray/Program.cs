// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Programm to count the positive numbers from the inputed numbers");
Console.Write("Input the quantity of numbers to be sorted. Press 'Enter' after every input:\t");

int numbersQuantity = int.Parse(Console.ReadLine()!);

if (numbersQuantity < 1)
{
    Console.WriteLine("Wrong input. Quantity shoud be > 0");
}
else
{
    int LetsCountPositiveNumbers()
    {
        int count = 0;

        for (int i = 0; i < numbersQuantity; i++)
        {
            Console.Write($"\nInput number {i + 1}:\t ");
            int input = int.Parse(Console.ReadLine()!);

            if (input > 0)
                count++;
        }

        return count;
    }

    int result = LetsCountPositiveNumbers();

    if (result == 1)
        Console.WriteLine($"\nThere is 1 positive number among the inputed");
    else
        Console.WriteLine($"\nThere are {result} positive numbers among the inputed");
}
