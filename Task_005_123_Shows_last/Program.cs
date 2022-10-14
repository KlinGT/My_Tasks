/*
Напишите программу, которая на входе принимает трёхзначное число
и на выходе показывает последнюю цифру этого числа.
456 -> 6    782 -> 2    918 -> 8
*/
Console.Clear();   



Console.WriteLine("Введите трёхзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

//проверка на трёхзначность введённого
if (num < 1000 && num > 99)
{
    Console.Write($"{num} -> ");
    Console.WriteLine(num % 10);
}
else
    Console.WriteLine("Введено не трёхзначное число! Повторите попытку.");
