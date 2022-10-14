/*
Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Clear();

Console.WriteLine("Введите первое число:");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num_B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int num_C = Convert.ToInt32(Console.ReadLine());

int max = num_A;

if(num_A > max) max = num_A;
if(num_B > max) max = num_B;
if(num_C > max) max = num_C;

Console.Write($"{num_A}, {num_B}, {num_C}, max -> ");
Console.WriteLine(max);