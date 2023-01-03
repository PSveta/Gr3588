// int X1 = ReadData ("Введите координату X1");
// int Y1 = ReadData ("Введите координату Y1");
// int X2 = ReadData ("Введите координату X2");
// int Y2 = ReadData ("Введите координату Y2");

// double result = DistanceBetweenPoint(X1, Y1, X2, Y2);

// PrintData("Расстояние между точками: ", result);

// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }

// // Метод находит расстояние между точками на плоскости
// double DistanceBetweenPoint(double x1, double y1, double x2, double y2)
// {
//     double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
//     return distance;
// }

// // Метод выводит данные пользователя
// void PrintData(string msg, double res)
// {
//     Console.WriteLine(msg + res);
// }

// PrintData("Расстояние между точками: ", DistanceBetweenPoint(X1, Y1, X2, Y2));



// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

int xh = ReadData ("Введите xh");
int xv = ReadData ("Введите xv");
int yh = ReadData ("Введите yh");
int yv = ReadData ("Введите yv");

double CalculateLength( int x1, int x2, int y1, int y2)
{
    double res = 0;
    res = Math.Sqrt(Math .Pow ((x1-x2), 2) + Math.Pow((y1- y2), 2));
    return res;
}

void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

PrintData("Расстояние между точками: ", CalculateLength(xh, xv, yh, yv));
