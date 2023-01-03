// // Вариант 1
//Считываем данные с консоли
int number = int.Parse(Console.ReadLine() ?? "0");


// //Проверяем, чтобы число было не двузначным
// if (number > 99)

// {

//     //Переводим число в массив
//     Char[] digits = number.ToString().ToCharArray();


//     //Выводим данные в консоль
//     Console.WriteLine(digits[2]);
 
// }

// else

//     {

//     //Выводим данные в консоль
//     Console.WriteLine("Третьего числа нет!");
    
//     }

// Вариант 2

// Вводим число
Console.Write("Введите число: ");

// Делаем цикл, если в числе минимум три цифры

if (number > 99)
{

    // Находим количество цтфр в числе

    int length = (int)Math.Log10(number) + 1;
    
    int index = 0;
    int thirdDigit = number;

// Делаем деление числа на 10 (length-3) раз, чтоб осталось три цифры в числе
    while(index < length-3)
    {
        thirdDigit = thirdDigit/10;
        index ++;

    }

//  находим третью цифру остатком деления на 10
    thirdDigit = thirdDigit %10;

// выводим третье число
    Console.WriteLine(thirdDigit + " Является третьей цифрой числа " + number);
}
else
{
// выводим если число меньше трех цифр
     Console.WriteLine(" Третьей цифры нет");
}



