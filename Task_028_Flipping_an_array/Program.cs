/* Задача 39: 
Напишите программу, которая перевернёт одномерный массив.
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/
Console.Clear();

// вывод массива в консоль:
void PrintArray(int [] array)
{
    Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]\n");
}

// создаём массив случайных значений:
int [] InitArray(int size)
{
    int [] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,10);
    }
    return array;
}

// запрос на кол-во эл-ов массива:
int GetSize()
{
    Console.WriteLine("Введите кол-во эл-ов массива цифрой: ");
    int size = int.Parse(Console.ReadLine() ?? "");
    return size;
}

// переворот массива:
int [] ArrayReverse(int [] array)
{
    int [] resultArray = new int[array.Length];
    int count = 0;

    for (int i = resultArray.Length -1; i >= 0; i--)
    {
        resultArray[count] = array[i];
        count++;
    }
    return resultArray;
}

int size = GetSize();
int [] startArray = InitArray(size);
Console.WriteLine("Изначальный массив:");
PrintArray(startArray);

int [] resultArray = ArrayReverse(startArray);
Console.WriteLine("Реверсиный массив:");
PrintArray(resultArray);