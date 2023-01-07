// Задача N 28  Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

using System.Numerics;  // вычисление с большими числами

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

 BigInteger CalcFactor(int num) // Метод считает факториал
{    
    BigInteger count = 1;
    for(int i=1;i<=num;i++)
    {
       count *= i;
    }
    return count;
}

int number = ReadData("Введите число А:");

BigInteger length1 = CalcFactor(number);

PrintData("Факториал равно^ " + length1);