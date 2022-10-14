/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
причём Х не равно 0 и Y не равно 0 и выдаёт номер четверти, в которой находится эта точка.
    2   |   1
        |        
---------------------->
    3   |   4
        |
*/
Console.Clear();
//получаем координату не равную 0
int GetCoordinate(string message) 
{
    int result = 0;                                     //создаём переменную которую будем возвращать.
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);                     //просим вывести сообщение которое пришло к нам на функцию (стр. 42,43)

        if(int.TryParse(Console.ReadLine(), out result) && result != 0) //если у нас удалось спарситься и result не равно 0
            isCorrect = true;
        else
            Console.WriteLine("Введите нормальную координату!\n");  // \n это системный знак переноса на одну строку 
    }
    return result;
}

//получаем четверть, в которой лежит точка с координатами (x,y)
int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    else
        return 4;
}

int x = GetCoordinate("Введите координату X, не равную 0");
int y = GetCoordinate("Введите координату Y, не равную 0");
int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка с координатами ({x},{y}) лежит в {quarter} четверти\n");