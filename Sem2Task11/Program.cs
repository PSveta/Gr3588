// Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int num = numberSintezator.Next(100,1000);

Console.WriteLine (num);

// int firstNum = num/100;
// int secondNum = num%10;

// int result = (num/100)*10+num%10;
Console.WriteLine ((num/100)*10+num%10);
