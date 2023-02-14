// ##### 02_task_HW_2023-02-07
// Написать программу масштабирования фигуры,
// чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

double ReadDoub (string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine() ! );
}

string Scaling(double x1, double y1, double x2, double y2, 
double x3, double y3, double x4, double y4, double k)
{
    x1 = x1 * k;
    y1 = y1 * k;
    x2 = x2 * k;
    y2 = y2 * k;
    x3 = x3 * k;
    y3 = y3 * k;
    x4 = x4 * k;
    y4 = y4 * k;
    return $"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})";

}

Console.Clear();
Console.WriteLine("Программа масштабирования фигуры");
Console.WriteLine("с координатами вершин (0,0) (2,0) (2,2) (0,2) ");
Console.WriteLine();
double k = 0;

while  (k != 2 && k != 4 && k != 0.5)
{ k = ReadDoub("Введите коэффициент масштабирования k - 2 или 4 или 0,5: ");
    if (k == 2 ) Console.WriteLine($" k равно 2");
  Console.WriteLine(k);
}

Console.WriteLine($"В результате масштабирования  с коффициентом {k} получаются координаты: ");
Console.WriteLine(Scaling(0, 0, 2, 0, 2, 2, 0, 2, k));
Console.WriteLine();