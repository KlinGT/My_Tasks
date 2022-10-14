/*
Напишите программу, которая будет выдавать название дня недели
по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.Clear();   

Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());  //можно не преобразовывать и оставить string так как нет матиматичеких вычислений

if (day == 1) 
    Console.WriteLine($"{day} -> Понедельник");
if (day == 2) 
    Console.WriteLine($"{day} -> Вторник");
if (day == 3) 
    Console.WriteLine($"{day} -> Среда");
if (day == 4) 
    Console.WriteLine($"{day} -> Четверг");
if (day == 5) 
    Console.WriteLine($"{day} -> Пятница");
if (day == 6) 
    Console.WriteLine($"{day} -> Суббота");
if (day == 7) 
    Console.WriteLine($"{day} -> Воскресенье");


//Вариант преподователя:
/*

Console.WriteLine("Введите число от 1 до 7: ");
string day = Console.ReadLine();

if (day == "1") 
    Console.WriteLine($"{day} -> Понедельник");
else
    if (day == "2") 
        Console.WriteLine($"{day} -> Вторник");
else
    if (day == "3") 
        Console.WriteLine($"{day} -> Среда");
else
    if (day == "4") 
        Console.WriteLine($"{day} -> Четверг");
else
    if (day == "5") 
        Console.WriteLine($"{day} -> Пятница");
else
    if (day == "6") 
        Console.WriteLine($"{day} -> Суббота");
else
    if (day == "7") 
        Console.WriteLine($"{day} -> Воскресенье");
else 
    Console.WriteLine("Вы ввели не то число! Повторите попытку.");
*/