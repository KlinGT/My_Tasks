/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/
Console.Clear();

int GiveMyNumber(int min, int max)        //метод получения рандомного числа.
{
    Random rnd = new Random();
    int result = rnd.Next(min, max);
    return result;
}

int GetMaxDigit(int number)                 //метод получения максимальной цифры из числа.
{
    int num1 = number / 10;                 //95 / 10 = 9
    int num2 = number % 10;                 //95 % 10 = 5

    if(num1 > num2)
        return num1;
    else 
        return num2;
}

int number = GiveMyNumber(10, 100);
int MaxDigit = GetMaxDigit(number);  

Console.WriteLine($"{number} -> {MaxDigit}"); 