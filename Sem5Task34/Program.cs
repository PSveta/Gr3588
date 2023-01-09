// N34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1


int[] array = GenArray(123, 100, 999);
Print1DArr(array);
int res = CountEven(array);
Console.WriteLine();
PrintData("Количество четных чисел в массиве равно ", res);


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

// Метод считает количетсво четных чисел в массиве
int CountEven(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 ==0);
        res ++ ;
    }
   return res;

}
// Метод выводит результат
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}




