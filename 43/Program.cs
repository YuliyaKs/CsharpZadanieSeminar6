// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

Console.Clear();
Console.Write("Введите коэффициент b1: ");
double coefB1 = double.Parse(Console.ReadLine());

Console.Write("Введите коэффициент k1: ");
double coefK1 = double.Parse(Console.ReadLine());

Console.Write("Введите коэффициент b2: ");
double coefB2 = double.Parse(Console.ReadLine());

Console.Write("Введите коэффициент k2: ");
double coefK2 = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine(LinesCrossing (coefB1, coefK1, coefB2, coefK2));

string LinesCrossing (double b1, double k1, double b2, double k2)
{
    string otvet = String.Empty;
    double x = (b2 - b1) / (k1 - k2);
    // Console.WriteLine(x);
    double y = k1 * x + b1;
    // Console.WriteLine(y);
    // double y = k2 * x + b2;
    return otvet = $"Точка пересечения двух прямых имеет координаты ({x}, {y})";
}    
