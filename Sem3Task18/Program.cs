int quter = ReadData("Введитеиномер четверти");

PrintAnswer(quter);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод определяет четверь по координатам точкт
void PrintAnswer(int num)
{
   if (num > 0 && num < 5)
   {
    if (quter == 1) Console.WriteLine("X > 0, Y > 0");
    if (quter == 2) Console.WriteLine("X > 0, Y < 0");
    if (quter == 3) Console.WriteLine("X < 0, Y < 0");
    if (quter == 4) Console.WriteLine("X < 0, Y > 0");
   }
   else Console.WriteLine("Вы ввели не номер четверти!");

}