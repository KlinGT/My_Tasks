/*
Напишите программу, которая на входе принимает два числа и проверяет,
является ли первое число квадратом второго.
а = 25, b = 5 -> да
a = 2, b = 10 -> нет

*/

Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_B * num_B == num_A)
    Console.WriteLine($"a = {num_A}, b = {num_B} -> да");
else
    Console.WriteLine($"a = {num_A}, b = {num_B} -> нет");
