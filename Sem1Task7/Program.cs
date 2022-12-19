//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{

    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    int lastDigit = inputNumber % 10;

    
    //Выводим данные в консоль
    Console.WriteLine(lastDigit);
}