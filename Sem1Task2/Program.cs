//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(num1Line !=null && num2Line !=null)
{

//Парсим введенное число 
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);


//Проверяем какое число больше  
    if (num1 > num2)
    {

    //Выводим данные в консоль
        Console.WriteLine("Первое число больше!");
    }
    else
    {

    //Выводим данные в консоль
        Console.WriteLine("Второе число больше!");
    }

   

}