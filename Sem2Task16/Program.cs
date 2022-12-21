
void TestSQRT(int i, int j)
{
    bool result = (i/j==j);
    if (result==true)Console.WriteLine("Число "+i+" является квадратом числа "+j);
    else Console.WriteLine("Число "+i+" не является квадратом числа "+j);

}

int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");
TestSQRT(number1,number2);
TestSQRT(number2,number1);



// Console.WriteLine(number1);

// bool result1 = (numberA / numberB == numberB);
// bool result2 = (numberB / numberA == numberA);

// if (result1) 

// Console.WriteLine("Первое число квадрат второго числа!");

// if (result2)

// Console.WriteLine("Второе число квадрат первого числа!");

// if (result2 && result1) 
// {
//     Console.WriteLine("Ни первое ни второе число не являються квадратами!");
// }
