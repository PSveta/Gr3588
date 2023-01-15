﻿// ---------------------------------------------------------------------
//                                 Задача 67
// примает на вход число и возвращает сумму цифр в числе
// ---------------------------------------------------------------------

int numberN = ReadData("Enter number N:");
int Sum = RecSumDig(numberN);
PrintResult(Sum);

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Печать результата
void PrintResult(int prefix)
{
    Console.Write(prefix);
}

//Рекурентный метод подсчета суммы цифр
int RecSumDig(int n)
{
    if (n<= 10) return n;
    int result = n%10 + RecSumDig(n/10);
    return result;
}
