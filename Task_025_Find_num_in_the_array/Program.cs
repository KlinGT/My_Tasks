/* Задача 33: 
Задайте массив и напишите программу, которая определяет
присутствует ли заданное число в массиве.
*/
Console.Clear();

//задаём рандомный массив c length кол-вом значений:
int[] InitArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(0, 100);
    }
    return resultArray;
}

//определяем искомое значение массива:
int GetNumber(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine() ?? "");
    return num;
}

//определяем кол-во значений в массиве:
int GetLength(string message)
{
    Console.Write(message);
    int length = int.Parse(Console.ReadLine() ?? "");
    return length;
}

//ищем заданное значение в массиве:
void FindNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            Console.WriteLine($"Значение {num} присутствует в массиве!\n");
            return;
        }
    }
    Console.WriteLine($"Значение {num} не присутствует в массиве.\n");
}

//вывод значений массива:
void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int length = GetLength("Введите размер массива: ");
int num = GetNumber("Введите искомое значение: ");

int[] arr = InitArray(length);
PrintArray(arr);
FindNumber(arr, num);