// N47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
double[,] arr2D = Fill2DArray(row, column, 0, 10);
Console.WriteLine();
Print2DArray(arr2D);


//Метод, считывающий данные, введенные пользователем
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива

double [,] Fill2DArray (int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    double [,] array2D = new double [countRow, countColumn];
    
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = Convert.ToDouble(rand.Next(topBorder, downBorder)/10.0);
        }
    }
    return array2D;
}

// Метод печатает двумерный массив


void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }

}
