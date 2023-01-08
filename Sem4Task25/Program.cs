// N25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод вывода данных
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод возводит число A в натуральную степень B

int Pow(int A, int B)
{
    int result = 1;
    for(int i=1; i<=B; i++)
    {
        result = A*result;
    }
    return result;
}

int A = ReadData("Введите число A: ");
int B = ReadData("Введите число B: ");
int result = Pow(A, B);
PrintData("A в степени B равно: " + result);
