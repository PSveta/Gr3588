// No29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    // * Ввести с клавиатуры длину массива и диапазон значений элементов

    // Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных
void PrintData(string res, int[] arr) 
{
    Console.WriteLine(res);
    PrintArr(arr);
}

// Метод генерирует массив
int[] GenArr(int arrLen, int minBorder, int maxBorder)
{
    Random rnd = new Random();
    int[] arr = new int[arrLen];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minBorder, maxBorder);
    }
    return arr;
}

// Метод печатает сгенерированный массив

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrLen = ReadData("Введите длину массива.");
int minBorder = ReadData("Введите минимальную границу массива:");
int maxBorder = ReadData("Введите максимальную границу массива:");
int[] arr = GenArr(arrLen, minBorder, maxBorder);
PrintArr(arr);