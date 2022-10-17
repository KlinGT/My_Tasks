/* Задача 32: 
Напишите программу замена элементов массива:
положительные элементы замените на соответствубщие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
Console.Clear();

//инициализация массива с рандомными значениями по заданному кол-ву эл-ов:
int [] InitArray(int length)
{
    int [] resultArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(-9, 9);
    }
    return resultArray;
}

//задаём размер массиву:
int GetLength(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

//вывод массива на консоль:
void PrintArray(int [] array)
{
    Console.WriteLine("Генерация массива:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//перемножение массива на -1, смена значений массива:
void RaplaceAndPrint(int [] array)
{
    Console.WriteLine("Противоположные значения массива:");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1)                 
            Console.Write($"{array[i] * -1}, ");   //вариант вывода через запятую
        else
            Console.Write($"{array[i] * -1}");     //последнее значение вывода без
    }
    Console.WriteLine();
}

int length = GetLength("Введите размер массива: ");
int [] arr = InitArray(length);
PrintArray(arr);
RaplaceAndPrint(arr);

Console.WriteLine();