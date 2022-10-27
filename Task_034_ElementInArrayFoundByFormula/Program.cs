/*
Задача 48: Задайте двумерный массив размером m x n,
каждый элемент в массиве находится по формуле: Аmn = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4 
2 3 4 5
*/
Console.Clear();

// ввод размерности массива с консоли:
int GetNum(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "");
    return num;
}

// создание двумерного массива наполненного случайными значениями:
int[,] GetTwoDimensionalArrayUsingFormula(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

// вывод массива по заданной формуле:
void PrintArray(int[,] array)
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

int m = GetNum("Введите число m: ");
int n = GetNum("Введите число n: ");

int[,] array = GetTwoDimensionalArrayUsingFormula(m, n);
PrintArray(array);