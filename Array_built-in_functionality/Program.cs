Console.Clear();

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("\n");
}

int[] array = new int[10];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 10);
}

int[] resultArray = new int[10];
Console.WriteLine("Массив resultArray до копирования:");
PrintArray(resultArray);

Array.Copy(array, resultArray, 10);

Console.WriteLine("Массив resultArray после копирования:");
PrintArray(resultArray);

Array.Reverse(resultArray);

Console.WriteLine("Массив resultArray после реверса:");
PrintArray(resultArray);