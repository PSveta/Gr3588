// 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rowA = ReadData("Введите количество строк первой матрицы : "); 
int columnB = ReadData("Введите количество столбцов первой матрицы : ");
int[,] a = Fill2DArray(rowA, columnB, 1, 10);            
Print2DArray(a);                                 
Console.WriteLine();
int rowC = ReadData("Введите количество строк второй матрицы : ");
int columnD = ReadData("Введите количество столбцов второй матрицы : ");  
int[,] b = Fill2DArray(rowC, columnD, 1, 10);           
Print2DArray(b);                                 
Console.WriteLine();
int[,] c = Multiplication(a, b);               
Print2DArray(c);                         


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


// Метод вывода двумерного массива на печать
 void Print2DArray(int[,] matrix)                  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Метод перемножения 2х матриц
int[,] Multiplication(int[,] a, int[,] b) 
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}