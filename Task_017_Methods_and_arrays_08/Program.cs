/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

AB = √(xb - xa)2 + (yb - ya)2
*/
Console.Clear();

Point GetPoint()
{
    Point point = new Point();
    Console.WriteLine("Введите координату X:");
    point.X = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y:");
    point.Y = int.Parse(Console.ReadLine());

    return point;
}

Point firstPoint = GetPoint();
Point secondPoint = GetPoint();

double result = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
Console.WriteLine($"{result}\n");

class Point
{
    public int X { get; set;}
    public int Y { get; set;}
}