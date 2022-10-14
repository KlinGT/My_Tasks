/*
Напишите программу, которая по заданному номеру четверти 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
Console.Clear();

//получаем четверть не равную 0 и не больше 4рёх
int GetQuarter(string message) 
{
    int result = 0;                                     //создаём переменную которую будем возвращать.
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);                     //просим вывести сообщение которое пришло к нам на функцию (стр. 38)

        if(int.TryParse(Console.ReadLine(), out result) && result != 0 && result <= 4)
            isCorrect = true;
        else
            Console.WriteLine("Введите нужную четверть!\n"); 
    }
    return result;
}

//сообщаем диапозон координат, исходя из номера четверти
void GetRange(int number)
{
    if (number == 1)
        Console.WriteLine("X от 0 до +бесконечности, Y от 0 до +бесконечности\n");
    if (number == 2)
        Console.WriteLine("X от 0 до -бесконечности, Y от 0 до +бесконечности\n");
    if (number == 3)
        Console.WriteLine("X от 0 до -бесконечности, Y от 0 до -бесконечности\n");
    if (number == 4)
        Console.WriteLine("X от 0 до +бесконечности, Y от 0 до -бесконечности\n");
}

int num = GetQuarter("Введите номер четверти:");
GetRange(num);