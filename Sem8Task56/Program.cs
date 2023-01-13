// 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:1 строка


int row = ReadData("Введите количество строк : ");
int column = ReadData("Введите количество столбцов : ");
int[,] arr2D = Fill2DArray(row, column, 0, 10);  
Print2DArray(arr2D);                            
int res = MinRow(arr2D);                  
PrintData("Номер строки с наименьшей суммой элементов: " + (res+1));

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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//  Метод производит поиск номера строки с наименьшей суммой элементов
int MinRow(int[,] arr2D)    
{
    int minIndex = -1;
    int minRow = int.MaxValue;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            sum += arr2D[i, j];
        }
        if (minRow > sum)
        {
            minRow = sum;
            minIndex = i;
        }

    }
    return minIndex;
}

//  Метод выводит результат
void PrintData(string res) 
{
    Console.WriteLine(res);
}

