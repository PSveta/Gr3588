//Считываем данные с консоли
string? numALine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (numALine!=null)
{

//Парсим введенное число 
    int numA = int.Parse(numALine);
    int numC = numA % 2;

//Проверяем четность числа

if (numC == 0)

//Выводим данные в консоль
        Console.WriteLine("Четное число!");
    
    else
    {

        //Выводим данные в консоль
        Console.WriteLine("Нечетное число!");

    }
    

}