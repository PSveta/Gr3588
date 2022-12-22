//Считываем данные с консоли
int number = int.Parse(Console.ReadLine() ?? "0");


//Проверяем, чтобы число было не двузначным
if (number > 99)

{

    //Переводим число в массив
    Char[] digits = number.ToString().ToCharArray();


    //Выводим данные в консоль
    Console.WriteLine(digits[2]);

 
}

else

    {

    //Выводим данные в консоль
    Console.WriteLine("Третьего числа нет!");
    
    }
