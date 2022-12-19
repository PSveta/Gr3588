
//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine!=null)
{
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    //Находим квадрат числа
    int outNuber = inputNumber*inputNumber;

    //Выводим данные в консоль
    Console.WriteLine(outNuber);

}