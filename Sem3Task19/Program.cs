// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Вводим данные

Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();
int length = number.Length;



// Проверяем число, является пятизначным

if (length == 5)

// Проверяем является число палидроном
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine(" Число" + number + " Число является палидроном");
    }
    else
    {
        Console.WriteLine(" Число" + number + " Число  не является палидроном");
    }
}
else
    {
        Console.WriteLine(" Введено не пятизначное число");
    }