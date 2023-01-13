// 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Генерируем двумерный массив, заполненный случайными числами
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// метод вывода двумерного массива
 void Print2DArray(int[,] matrix)
 {
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             Console.Write(matrix[i, j] + "  ");
         }
         Console.WriteLine();
     }
 }

//Метод упорядочивает элемнты по убыванию
int[,]SortArray(int[,]arr2D)//Сортируем массив
{

for (int i = 0; i < arr2D.GetLength(0); i++)
                
                for (int j = 0; j < arr2D.GetLength(1); j++)
                    for (int k = 0; k < arr2D.GetLength(1); k++)
                    {
                        if (arr2D[i, j] <= arr2D[i, k]) continue;
                        int temp = arr2D[i, j];
                        arr2D[i, j] = arr2D[i, k];
                        arr2D[i, k] = temp;
                    }
 
           
  return arr2D;              
}
               
int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);
int [,] sorted2DArr = SortArray(arr2D);
Console.WriteLine("Отсортированный массив: ");
Print2DArray(sorted2DArr);