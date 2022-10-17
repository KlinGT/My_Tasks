/* Задача 31: 
Задайте массив из 12 элементов, заполненый случайными числами из промежутка (-9,9).
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
сумма отрицательных равна -20.
*/
Console.Clear();

//инициализация массива рандомными числами от -9 до 9 длиной length:
int[] InitArray(int length)
{
    int [] resultArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(-9, 10);
    }
    return resultArray;
}

//вывод массива в консоль:
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//получение размерности массива с консоли:
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
/*
//получение суммы положительных чисел в массиве:
int GetSummOfPositive(int [] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            summ += array[i];   //sum = sum + array[i];
    }
    return summ;
}

//получение суммы отрицательных чисел в массиве:
int GetSummOfNegative(int [] array)
{
    int summ = 0;
    for (int i = 0; i > array.Length; i++)
    {
        if(array[i] > 0)
            summ += array[i];   //sum = sum + array[i];
    }
    return summ;
}
*/
//картеж, первое значение это сумма положительных, второе сумма отрицательных:
(int, int) GetSumms(int [] array)
{
    int positiveSumm = 0;
    int negativeSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            negativeSumm += array[i];
        else
            positiveSumm += array[i];
    }
    return (positiveSumm, negativeSumm);
}

int length = GetNumber("Введите размерность массива:");
int[] arr = InitArray(length);
PrintArray(arr);

//int positiveSumm = GetSummOfPositive(arr);
//int negativeSumm = GetSummOfNegative(arr);

(int pos, int neg) = GetSumms(arr);

//Console.WriteLine($"Сумма положительных: {positiveSumm}, сумма отрицательных: {negativeSumm}");
Console.WriteLine($"Сумма положительных: {pos}, сумма отрицательных: {neg}");