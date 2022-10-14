/* Задача 30: 
Напишите программу, которая выводит массив из 8ми элементов
заполненый 0ми и 1ми в случайном порядке.
[1,0,1,0,1,1,0,1]

Console.Clear();

void FillArray(int[] collection)      //1. Метод заполнения массива случайными числами
{                                                      //тело метода:
    int length = collection.Length;                     //выясняем кол-во эл-тов массива
    int index = 0;                                      //задаём значение индекса для старта цикла
    while (index < length)                              //задаём условие цикла
    {                                                  //тело цикла 
        collection[index] = new Random().Next(0, 2);   //заполняем массив случайными цифрами в диапазоне от 1 до 10
        index++;                                        //шаг цикла +1 для полного заполнения значениями массива
    }
}

void PrintArray(int[] col)            //2. Метод вывода значений массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] array = new int[8]; 
FillArray(array);                     //запускаем наш метод по заполнению случайными числами нашего массива                     
PrintArray(array); 
*/
//Вариант с семинара:
int[] CreateArrey(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

int[] array = CreateArrey(8);

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}