//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(num1Line !=null && num2Line !=null && num3Line !=null)
{

//Парсим введенное число 
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);


//Проверяем какое число больше  
    if (num1 > num2)
    if (num1 > num3)
   
    {

    //Выводим данные в консоль
        Console.WriteLine("Max!" + num1);
    }
    else
    {

    //Выводим данные в консоль
        Console.WriteLine("Max!" + num3);
    }

   if (num2 > num3)

   {

    //Выводим данные в консоль
        Console.WriteLine("Max!" + num2);
    }
    else
    {

    //Выводим данные в консоль
        Console.WriteLine("Max!" + num3);
    }
}

   