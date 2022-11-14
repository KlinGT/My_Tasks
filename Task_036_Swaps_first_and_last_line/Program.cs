/*
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.
*/
Console.Clear();

// ввод размерности массива с консоли:
int GetDimensionOfArray(string msg)
{
    Console.Write(msg);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

// заполняем массив случайными значениями:
int[,] FillingTheArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

// вывод массива в консоль:
void PrintArrayInToConsole(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 3}", array[i, j]);
        }
        Console.WriteLine();
    }
}

// перестановка строк массива:
int[,] RaplaceRowsInToArray(int[,] array)
{
    int[,] resArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
                resArray[i, j] = array[array.GetLength(0) - 1, j];
            else if (i == (resArray.GetLength(0) - 1))
                resArray[i, j] = array[0, j];
            else
                resArray[i, j] = array[i, j];
        }
    }
    return resArray;
}


int rows = GetDimensionOfArray("Введите кол-во строк: ");
int columns = GetDimensionOfArray("Введите кол-во столбцов: ");
int[,] arr = FillingTheArray(rows, columns);

PrintArrayInToConsole(arr);
Console.WriteLine();

int[,] resArray = RaplaceRowsInToArray(arr);
PrintArrayInToConsole(resArray);
Console.WriteLine();