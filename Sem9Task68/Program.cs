﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int numberM = ReadData("Введите число M: ");
int numberN = ReadData("Введите число N: ");
int result = AckermannFunc(numberM,numberN);
PrintResult("Результат вычисления равен: ",result);


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix, int res)
{
    Console.WriteLine(prefix + res);
}

//Метод вычесляет функцию Аккермана
int AckermannFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return AckermannFunc(m - 1, 1);
        }
        return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    }

}
