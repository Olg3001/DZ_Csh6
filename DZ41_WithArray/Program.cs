// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Programm to count the positive numbers from the inputed numbers");
Console.Write("Input the quantity of numbers should be sorted. Press 'Enter' after every input:\t");

int numbersQuantity = int.Parse(Console.ReadLine()!);
int[] myArray = new int[numbersQuantity];

if (numbersQuantity < 1)
{
    Console.WriteLine("Wrong input. Quantity shoud be > 0");
}
else
{
    void ReadArray(int[] myArray)
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nInput number {i + 1}:\t ");
            myArray[i] = int.Parse(Console.ReadLine()!);
        }
    }

    void LetsCountPositiveNumbers(int[] myArray)
    {
        int count = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] > 0)
                count++;
        }
        if (count == 1)
            Console.WriteLine($"\nThere are 1 positive number among the inputed");
        else
            Console.WriteLine($"\nThere are {count} positive numbers among inputed");
    }

    ReadArray(myArray);
    LetsCountPositiveNumbers(myArray);
}
