// N27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int number = ReadData("Введите число: ");
int summa = SumDigit(number);
PrintData("Сумма чисел равно: " + summa);


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод считает сумму

int SumDigit(int number)
{
    int result = 0;
    while (number >0)
    {
        result += number%10;
        number = number/10;

    }
    return result;

}
