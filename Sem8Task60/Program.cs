// 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Чтение данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Создаем список чисел от 10 до 99
List<int> num = new List<int>();
for (int i = 0; i < 90; i++)
{
    num.Add(10 + i);
}

// Метод генерирует случайные двузначные числа
int GenNum(List<int> num)
{
    int index = new Random().Next(0, num.Count);
    int outNum = num[index];
    num.Remove(index);
    return outNum;
}

// Метод генерирует трехмерный массив и заполняет случайными двузначными числами
int[,,] Fill3DArray(int x, int y, int z)
{
    int[,,] array3D = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array3D[i, j, k] = GenNum(num);
            }
        }
    }
    return array3D;
}

// Метод печатает трехмерный массив вместе с индексами элементов
void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + "     ".Substring(matrix[i, j, k].ToString().Length));
            }
            Console.WriteLine();
        }
    }
}

int x = ReadData("Введите количество элемнтов x:");                      
int y = ReadData("Введите количество элемнтов y:");  
int z = ReadData("Введите количество элемнтов z"); 

int[,,] arr3D = Fill3DArray(x, y, z);    
Print3DArray(arr3D);                           