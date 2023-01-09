// N36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0

int[] array = GenArray(123, 100, 999);
Print1DArr(array);
int res = SumOdd(array);
Console.WriteLine();
PrintData("Сумма элементов, стоящих на нечетных позициях ", res);


//Метод генерирует массив
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

//Метод печатает одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод считает сумму чисел стоящих на нечетных позициях в массиве
int SumOdd(int[] arr)
{
    int res = 0;
    int i = 1;
    while(i<array.Length)
    {
        res += arr[i];
        i = i+2;
    }
    
   return res;
}

// Метод выводит результат
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
