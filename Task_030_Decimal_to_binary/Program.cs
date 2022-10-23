/* Задача 42: 
Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.Clear();

// принимаем число с консоли:
int GetNum(string msg)
{
    Console.WriteLine(msg);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

// перевод числа в двоичную сист. и возврат результата массивом:
int[] InToBinary(int num)
{
    List<int> array = new List<int>();
    while (num >= 1)
    {
        array.Add(num % 2);
        num = num / 2;
    }
    return array.ToArray();
}

// вывод массива в консоль:
void PrintArray(int[] arr, int num)
{
    Console.Write($"{num} -> ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}

int num = GetNum("Введите преобразуемое число:");
int[] arr = InToBinary(num);
PrintArray(arr, num);