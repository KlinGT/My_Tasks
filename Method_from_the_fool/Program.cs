int GetNumberFool(string message)   //метод требует ввести число, до тех пор пока не введут цифры.
{
    int result = 0;                 //ввели переменную и придали значение out.
    bool isCorrect = false;         //булевая переменная.

    while(!isCorrect)                   //делаем цикл до тех пор пока переменная isCorrect == false.
    {
        Console.WriteLine(message);     //тут выводим на консоль наше сообщение которое мы ей передали(строчка 21).

        isCorrect = int.TryParse(Console.ReadLine(), out result);

        if(!isCorrect)
            Console.WriteLine("Ввели не число, введите корректное число");

        Console.WriteLine();
    }

    return result;
}

GetNumberFool("Введите число:");
