// N43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

int b1 = ReadData("Введите значение b1: ");
int k1 = ReadData("Введите значение k1: ");
int b2 = ReadData("Введите значение b2: ");
int k2 = ReadData("Введите значение k2: ");
CrossPoint(k1,b1,k2,b2);

// Метод читает данные от пользователя
int ReadData(string msg) //Ввод чисел пользователем
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод нахождения точки пересечения
void CrossPoint(double k1, double b1, double k2, double b2) 
{   
    double x = (b1-b2)/(k2-k1); 
    double y = (k2*b1-k1*b2)/(k2-k1); 
    if(k1==k2) 
        {
        Console.Write("Не пересекаются");
        }
    else 
        {
        Console.Write("Точка пересечения: ({x}; {y})");
        } 
 }

