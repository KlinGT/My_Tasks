/*
Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
Console.Clear();

Console.WriteLine("Введите ваше число:");
int num = Convert.ToInt32(Console.ReadLine());

void MultipleOfTwo(int num)
{
    int first = num % 7;
    int second = num % 23;
    if (first == 0 & second == 0)
        Console.WriteLine($"{num} -> да");
    else
        Console.WriteLine($"{num} -> нет");
}   

MultipleOfTwo(num);