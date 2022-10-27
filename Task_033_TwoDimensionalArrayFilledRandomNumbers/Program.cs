/*
Задача 46: Задайте двумерный массив размером m x n,
заполненый случайными числами.
*/
Console.Clear();

// ввод размерность двумерного массива:
int GetDimensionOfArray(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "");
    return num;
}

// наполнение массива случайными числами:
int[,] FillArray(int[,] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

// вывод массива в консоль:
void OutputArrayToConsole(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

int m = GetDimensionOfArray("Введите значение m: ");
int n = GetDimensionOfArray("Введите значение n: ");
int[,] array = new int[m, n];

OutputArrayToConsole(array);
Console.WriteLine(" ");
FillArray(array);
Console.WriteLine(" ");
OutputArrayToConsole(array);