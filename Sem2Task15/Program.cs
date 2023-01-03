// //Вариант 1
// //Считываем данные с консоли
// int number = int.Parse(Console.ReadLine() ?? "0");

// //Проверяем, чтобы данные были не пустыми
// if (number >0 && number<8)

// {

// if (number > 5)
// //Выводим данные в консоль

// Console.WriteLine("Выходной день!");

// else
// {
//     //Выводим данные в консоль
//    Console.WriteLine("Будний день!");
// }


// }

// if (number > 7)
// {
//     //Выводим данные в консоль
// Console.WriteLine("Это не день недели");
// }




//  // Вариант 2


// //Считываем данные с консоли
// int inputLine = int.Parse(Console.ReadLine() ?? "0");

// if (inputLine>0 && inputLine<8)

// {
// //Создаем массив с днями недели
//    string[] dayOfWeek = new string[7];
//    dayOfWeek[0] = "рабочий";
//    dayOfWeek[1] = "рабочий";
//    dayOfWeek[2] = "рабочий";
//    dayOfWeek[3] = "рабочий";
//    dayOfWeek[4] = "рабочий";
//    dayOfWeek[5] = "выходной";
//    dayOfWeek[6] = "выходной ";

// if ((dayOfWeek=5)&&(dayOfWeek=6))

//  {


//   //Выводим данные в консоль
//  Console.WriteLine("dayOfWeek[dayOfWeek]");

//  }
// else
// {
//     //Выводим данные в консоль
//  Console.WriteLine("dayOfWeek[dayOfWeek]");
// }
//  }



// Вариант 3

// Вводи число
Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine()??"0");

// делаем цикл, если выполняеться условие 0<number<8
if((number>0)&&(number<8))
{
// Заполняем словарь

Dictionary<int, string> dict = new Dictionary<int, string>
{
    { 1, "рабочий день" },
    { 2, "рабочий день" },
    { 3, "рабочий день" },
    { 4, "рабочий день" },
    { 5, "рабочий день" },
    { 6, "выходной день" },
    { 7, "выходной день" },
};

// Выводим значение словоря по дню
Console.Write(dict[number]);

}
else
{
    // 
    Console.WriteLine("Это не день недели");
}
