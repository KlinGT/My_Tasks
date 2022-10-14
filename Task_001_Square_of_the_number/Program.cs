/*
Напишите программу, которая на входе принимает число и выдаёт его квадрат 
(число умноженное на само себя)
*/

Console.Clear();   

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;

//Console.WriteLine("Квадрат вашего числа: ");
//Console.WriteLine(result);

//вариант вывода одной строкой через ${}:
Console.WriteLine($"Квадрат вашего числа: {result}");

/*

//Вариант преподователя:

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();

//получаем числовое значение
int number = Convert.ToInt32(numberStr);
int result = number * number;

//варианты вывода ответа:
//Console.WriteLine(result);
//Console.WriteLine(number + " -> " + result);
Console.WriteLine($"{number} -> {result}");
*/