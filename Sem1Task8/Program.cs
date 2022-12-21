//Считываем данные с консоли
string? numNLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (numNLine!=null)
{

//Парсим введенное число 
    int numN = int.Parse(numNLine);
    int numC = 2;

//Выходные значения
    
    string Result = string.Empty;

// Проверяем условие
     
     while (numC <= numN-2)
     {

        Result = Result + numC + ",";
        numC = numC + 2;

     }
     Result = Result+numC;
     
     //Result = Result.TrimEnd(',');

//Выводим данные в консоль
    Console.WriteLine(Result);
}
