/*
Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа.
784 -> 74
152 -> 12
985 -> 95
/*
Console.Clear();

int GiveMyNumber(int min, int max)        //метод получения рандомного числа.
{
    Random rnd = new Random();
    int result = rnd.Next(min, max);
    return result;
}

int CutMyNumber(int number)                //метод отрезания второй цифры из трёхзначного числа
{
    string str = number.ToString();
    int numbers = int.Parse(str.Remove(str.Length - 2, 1));
    return numbers;
}

int number = GiveMyNumber(100, 1000);
int CutResult = CutMyNumber(number);  

Console.WriteLine($"{number} -> {CutResult}");
*/

//Вариант из семинара:
Console.Clear();

int newNum = (new Random()).Next(100,1000);
string numAsString = newNum.ToString();
int result = int.Parse(numAsString[0].ToString() + numAsString[2].ToString());
Console.WriteLine($"Base num: {newNum}");
Console.WriteLine($"Result num: {result}");

