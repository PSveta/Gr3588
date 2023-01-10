// N50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);
int rowI = ReadData("Введите индекс строки: ");
int columnJ = ReadData("Введите индекс столбца: ");
SearchElem(arr2D, rowI, columnJ);

//Метод, считывающий данные, введенные пользователем
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
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

// Метод поиска элемента
int SearchElem(int[,] matrix, int i, int j)
{
    int elem = -1;
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
       elem = matrix[i, j];
       PrintData("Запрошенный элемент имеет значение: ", elem);
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }
    return elem;
}
  
// Метод печатает результат
void PrintData(string msg, int meaning)
{
    Console.WriteLine(msg+meaning);
    
}

// Метод печатает двумерный массив

void Print2DArray(int[,] matrix)
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



