/* Задача 40: 
Напишите программу, которая принимает три числа и проверяет,
может ли существовать треугильник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше
суммы двух других сторон.
*/
Console.Clear();

/*
// принимаем три числа (A, B, C):
(int, int, int) GetThreeNum()
{
    Console.WriteLine("Введите число А: ");
    int sideA = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Введите число B: ");
    int sideB = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Введите число C: ");
    int sideC = int.Parse(Console.ReadLine() ?? "");

    return (sideA, sideB, sideC);
} 

// сравниваем сумму двух чисел с третьей и вывод на консоль:
void SidesCompar(int A, int B, int C)
{
    if (A + B > C) Console.WriteLine($"Треугольник с сторонами {A}, {B}, {C} существует!\n");
    else Console.WriteLine($"Треугольник с сторонами {A}, {B}, {C} НЕ существует!\n");
}

(int A, int B, int C) = GetThreeNum();
SidesCompar(A, B, C);
*/

// вариант на сименаре:

// принимаем одно число:
int GetNum(string msg)
{
    Console.WriteLine(msg);
    int triangleSide = int.Parse(Console.ReadLine() ?? "");
    return (triangleSide);
} 

// сравниваем значения и суммы значений, вывод на консоль:
void SidesCompar(int A, int B, int C)
{
    if (A + B > C && A + C > B && C + B > A) 
        Console.WriteLine($"Треугольник с сторонами {A}, {B}, {C} существует!\n");
    else 
        Console.WriteLine($"Треугольник с сторонами {A}, {B}, {C} НЕ существует!\n");
}

int A = GetNum("Введите число А:");
int B = GetNum("Введите число B:");
int C = GetNum("Введите число C:");
SidesCompar(A, B, C);