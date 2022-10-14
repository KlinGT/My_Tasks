/*
Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.

*/
Console.Clear();

Console.WriteLine("Введите ваше первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ваше второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

void SquareOfAnother(int num1, int num2)
{
    if (num1 * num1 == num2)
    { 
        Console.WriteLine($"{num1} является квадратом {num2}");
        return;
    }
    if (num2 * num2 == num1)
    {
        Console.WriteLine($"{num2} является квадратом {num1}");
        return; 
    }
    Console.WriteLine("Ни чё не вышло... =((");
}   

SquareOfAnother(num1, num2);