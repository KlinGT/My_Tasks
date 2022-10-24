/* Задача 45: 
Напишите программу, которая будет создовать копию заданного массива
с помощью пулемётного копирования.
*/
Console.Clear();

// запрос на ввод кол-ва эл-ов массива:
int GetLengthArray(string msg)
{
    Console.WriteLine(msg);
    int length = int.Parse(Console.ReadLine() ?? "");
    return length;
}

// создаём массив с заданным кол-вом эл-ов рандомных значений:
int[] GetTrueArray(int length)
{
    int[] resArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = rnd.Next(0, 10);
    }
    return resArray;
}

// создание копии изначального массива:
int[] CopyArray(int[] array)
{
    int[] copiedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copiedArray[i] = array[i];
    }
    return copiedArray;
}

// вывод массива в консоль:
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
    }
    Console.WriteLine();
}

int length = GetLengthArray("Введите кол-во эл-ов массива цифрой: ");
int[] arr = GetTrueArray(length);
PrintArray(arr);
int[] copyOfTheArray = CopyArray(arr);
PrintArray(copyOfTheArray);