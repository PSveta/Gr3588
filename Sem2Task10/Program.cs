// Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int num = numberSintezator.Next(100,1000);

 //Выводим данные в консоль

Console.WriteLine (num);

//Вычисляем второе число
int result = (num/10)%10;

//Выводим результат
Console.WriteLine(result);
