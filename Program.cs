// Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//     0, 7, 8, -2, -2 -> 2
//     1, -7, 567, 89, 223-> 3
/*
int NumPositive()
{
    Console.Write("Введите количество чисел: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) count ++;
    }
    return count;
}

Console.WriteLine($"Количество чисел больше нуля: {NumPositive()}");
*/

// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

//   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] PointCross(double b1, double b2, double k1, double k2)
{
    double[] result = new double[2];
    result[0] = (b1-b2)/(k2-k1);
    result[1] = k1*result[0] + b1;
    return result;
}

void ShowArray(double[] array)
{
    Console.Write("(");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length -1) Console.Write("; ");
        else Console.WriteLine(")");
    }
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if(k1 == k2) Console.WriteLine("Прямые не пересекаются!!!");
else
{
    double[] crossPoint = PointCross(b1, b2, k1, k2);
    Console.Write("Координаты точки пересечения двух прямых: ");
    ShowArray(crossPoint);
}