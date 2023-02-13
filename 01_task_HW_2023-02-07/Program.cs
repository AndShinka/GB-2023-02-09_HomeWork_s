// 01_task_HW_2023-02-07
// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2,
// b1 k1 и b2 и k2 заданы
Console.Clear();

double ReadDoub (string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine() ! );
}

void PrintResult (double b1, double k1, double b2, double k2)
{
    if ( k1 == k2)
    {
        if (b1 == b2 )
        Console.WriteLine(" паралельны");
        else
        {    
            Console.WriteLine(" совпадают");
        }
    }
    else
    {
        Console.WriteLine($" пересекаются в точкe: {-(b1 - b2) / (k1 - k2)} : {k1 * (-(b1 - b2) / (k1 - k2)) + b1}");
    } 
}

Console.WriteLine("Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2" ! );

double b1 = ReadDoub("Введите b1: ");
double k1 = ReadDoub("Введите k1: ");
double b2 = ReadDoub("Введите b2: ");
double k2 = ReadDoub("Введите k2: ");

Console.Write($"Прямые заданные коэффициентами  {b1} , {k1} , {b2}, {k2} ");
PrintResult(b1, k1, b2, k2);

Console.WriteLine();


