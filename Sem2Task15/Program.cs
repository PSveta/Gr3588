﻿//Вариант 1
//Считываем данные с консоли
int number = int.Parse(Console.ReadLine() ?? "0");

//Проверяем, чтобы данные были не пустыми
if (number >0 && number<8)

{

if (number > 5)
//Выводим данные в консоль

Console.WriteLine("Выходной день!");

else
{
    //Выводим данные в консоль
   Console.WriteLine("Будний день!");
}


}

if (number > 7)
{
    //Выводим данные в консоль
Console.WriteLine("Это не день недели");
}


// // Вариант 2


// //Считываем данные с консоли
// int inputLine = int.Parse(Console.ReadLine() ?? "0");

// if (inputLine>0 && inputLine<8)

// {
// //Создаем массив с днями недели
//     string[] dayOfWeek = new string[7];
//     dayOfWeek[0] = "понедельник";
//     dayOfWeek[1] = "вторник";
//     dayOfWeek[2] = "среда";
//     dayOfWeek[3] = "четверг";
//     dayOfWeek[4] = "пятница";
//     dayOfWeek[5] = "суббота";
//     dayOfWeek[6] = "воскресенье";

// if (dayOfWeek=5 && dayOfWeek=6)

// {


//     //Выводим данные в консоль
//     Console.WriteLine("Выходной день!");

// }

// }
