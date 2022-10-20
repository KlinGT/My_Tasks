/* Задача 35: 
Задайте одномерный массив из 123 случайных чисел.
Найдите кол-во эл-ов массива, значения которых лежат в отрезке [10, 99].
*/
Console.Clear();

//создаём массив из 123 рандомных значений:
int [] BornArray()
{
    int [] resArray = new int[123];
    Random rnd = new Random();

    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = rnd.Next(0, 999);
    }
    return resArray;
}

//вывод массива через пробел:
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//вывод кол-ва значений из диапазона в массива через пробел:
int FindInSegment(int [] array)
{
    Console.WriteLine();
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count++;
    }
    return count;
}

int [] arr = BornArray();
PrintArray(arr);
int count = FindInSegment(arr);
Console.WriteLine($"Значений диапазона (от 10 до 99) в массиве: {count} раз.\n");