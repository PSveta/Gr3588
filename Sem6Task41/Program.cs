// N41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // -1, -7, 567, 89, 223-> 3
   

int num = ReadData("Введите количество число:");
int res = CountPositivNum(num);
PrintData("Количество чисел больше 0: " + res);



//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод проверяет количество чисел больше 0

int CountPositivNum(int num)
{
    int res = 0; 
    while (num > 0)
    {
        if (ReadData("Введите число: ") > 0) res ++;
             num = num - 1;
    }
return res;

}
