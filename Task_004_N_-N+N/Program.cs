/*
Напишите программу, которая на входе принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> "-2, -1, 0, 1, 2"
*/
Console.Clear();   

Console.WriteLine("Введите ваше число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"{num} -> ");

for (int i = -num; i <= num; i++)
{
    Console.Write($" {i} ");
}
