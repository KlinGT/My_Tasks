/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4.
*/
Console.Clear();

void GetNumber (int num)
{
    Console.Write($"{num} -> ");
    for (int i = 1; i <= num; i++)
    {
        var squere = Math.Pow(i, 2);
        Console.Write($"{squere}, ");
    }
}

Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine());
GetNumber(number);