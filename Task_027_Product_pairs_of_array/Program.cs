/* Задача 37: 
Найдите произведение пар чисел в одномерном массиве.
Парой считается первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
Console.Clear();

//создаём массив с рандомными значениями:
int [] NewRandArray(int arraySize)
{
    int [] resultArray = new int[arraySize];
    Random rnd = new Random();

    for (int i = 0; i < arraySize; i++)
        resultArray[i] = rnd.Next(0, 10);       
    
    return resultArray;
}

//вывод массива на консоль:
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//перемножаем массив с чётным и не чётным кол-вом эл-ов:
int [] ResFunc(int [] array)
{
    int newArrayLength = array.Length / 2;

    if(array.Length % 2 != 0)
        newArrayLength += 1;
    
    int [] result = new int[newArrayLength];
    for (int i = 0; i < newArrayLength; i++)
        result[i] = array[i] * array[array.Length -i -1];

    if(array.Length % 2 != 0)
        result[newArrayLength -1] = array[newArrayLength -1];

    return result;
 }

 Console.WriteLine("Введите кол-во эл-тов массива: ");
 int arraySize = int.Parse(Console.ReadLine());

 int [] arr = NewRandArray(arraySize);
 PrintArray(arr);
 int [] resultArray = ResFunc(arr);
 PrintArray(resultArray);