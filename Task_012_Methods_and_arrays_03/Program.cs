/*
Напишите программу, которая будет на вход принимать два числа
и выводить является ли второе число кратным первому. 
Если число 2ое некратно число 1му, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

Console.Clear();

Console.WriteLine("Введите ваше первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ваше второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

void MultipleOfFirst(int num1, int num2)
{
    int num3 = num1 % num2;
    if (num3 == 0)
        Console.WriteLine($"{num1}, {num2} -> кратно");
    else
        Console.WriteLine($"{num1}, {num2} -> не кратно, остаок {num3}");
}   

MultipleOfFirst(num1, num2);

/*Вариант из семинара:
Console.Clear();

void CompareNum(int num1, int num2)
{
    int num3 = num1 % num2;
    if (num3 == 0)
        Console.WriteLine("Второе число кратное.");
    else
        Console.WriteLine($"Второе число не кратное первому. Остаток {num3}");
}
CompareNum(15,4);
*/