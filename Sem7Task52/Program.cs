// No52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждомстолбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
double [,] arr2D = Fill2DArray(row, column, 0, 10);
Print2DArray (arr2D);
string result = AverageCalсulator(arr2D);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
Console.WriteLine (result);

// Метод читает данные от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double [countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Метод выводит на печать созданный массив
void Print2DArray( double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
         Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
         
        }
        Console.WriteLine();
    }
}

// Метод находит среднее арифметическое в  столбце массива
string AverageCalсulator (double [,] arr)
{   string average = string.Empty; 
    double averageSum = 0;
  
     for ( int j = 0; j<arr.GetLength(0); j++)
  
    {    double sum = 0;
         for (int k = 0; k < arr.GetLength(1); k++)     
         {
         sum = sum + arr [k,j];
         
         }
    averageSum = sum/arr.GetLength(1);
    average = average + averageSum + " ";
    }
    
   return average;
}

 