/* Задача 28: 
Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N. 

*/
Console.Clear();

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

//метод произведения чисел от числа.
int GetNumOf(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}

int res = GetNumOf(num);
Console.WriteLine($"{num} -> {res}");