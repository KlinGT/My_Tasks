//найти мин и макс массива
/*
int Min(int [] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
    }
    return min;
}

int Max(int [] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
    }
    return max;
}

int [] array = new int [100];
*/


void FillArray(int[] collection)      //Метод заполнения массива случайными числами
{                                                      
    int length = collection.Length;                     
    int index = 0;                                      
    while (index < length)                              
    {                                                  
        collection[index] = new Random().Next(1, 10);   
        index++;                                        
    }
}

//кортеж объединяет всё в одну функцию
(int, int) FindMaxAndMin(int [] array)
{
    int max = array[0];
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        
        if(array[i] < min)
            min = array[i];
    }
    return (max, min);
}

int [] array = new int[10];
FillArray(array);   
//int [] array = {11, 12, 34, 55, 88, 99, 87, 45, 9};
(int max, int min) = FindMaxAndMin(array); //так вызывается метод

Console.WriteLine($"{max} и {min}");