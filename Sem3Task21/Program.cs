// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// // Вариант 1

// // Ввода данных


// int x1 = ReadData("Введите x1");
// int y1 = ReadData("Введите y1");
// int z1 = ReadData("Введите z1");
// int x2 = ReadData("Введите x2");
// int y2 = ReadData("Введите y2");
// int z2 = ReadData("Введите z2");


// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Метод находит расстояние между точками в 3D пространстве
// double DistanceBetweenPoint(double x1, double y1, double x2, double y2, double z1, double z2)
// {
//     double distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
//     return distance;
// }

// // Метод выводит данные пользователя
// void PrintData(string msg, double res)
// {
//     Console.WriteLine(msg + res);
// }

// PrintData("Расстояние между точками: ", DistanceBetweenPoint(x1, x2, y1, y2, z1, z2));




// Вариант 2

int X1 = ReadData ("Введите координату X1");
int Y1 = ReadData ("Введите координату Y1");
int Z1 = ReadData ("Введите координату Z1");
int X2 = ReadData ("Введите координату X2");
int Y2 = ReadData ("Введите координату Y2");
int Z2 = ReadData ("Введите координату Z2");

double result = DistanceBetweenPoint(X1, Y1, X2, Y2, Z1, Z2);

PrintData("Расстояние между точками: ", result);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод находит расстояние между точками на плоскости
double DistanceBetweenPoint(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)); 
    return distance;
}

// Метод выводит данные пользователя
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

PrintData("Расстояние между точками: ", DistanceBetweenPoint(X1, Y1, X2, Y2, Z1, Z2));



