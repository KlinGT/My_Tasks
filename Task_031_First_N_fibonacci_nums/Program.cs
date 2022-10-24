/* Задача 44: 
Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначи: 0 и 1.
Если N = 5 -> 0 1 1 2 3 
Если N = 3 -> 0 1 1 
Если N = 7 -> 0 1 1 2 3 5 8
*/
Console.Clear();

// запрос на ввод числа:
int GetNum(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "");
    return res;
}

// наполнение массива фибой:
int[] FiboArray(int num)
{
    int[] array = new int[num];
/*
    if (num == 0) 
    {
        array[0] = 0;
        return array;
    }
*/
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

// вывод массива фибы на консоль:
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int num = GetNum("Введите кол-во нужных Фибоначчи:");
int[] arr = FiboArray(num);
PrintArray(arr);