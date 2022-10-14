/*
Напишите программу, которая принимает на вход число (A)
и выдаёт сумму чисел от 1 до A.
7 -> 28
4 -> 10
8 -> 36
*/
Console.Clear();

Console.Write("Введите число А: ");
int num = Convert.ToInt32(Console.ReadLine());

//метод суммы чисел от числа.
int GetSumOfInterval(int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        result += i;
    }
    return result;
}

int sum = GetSumOfInterval(num);
Console.WriteLine($"{num} -> {sum}");