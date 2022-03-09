// Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число

Console.WriteLine("Введите трехзначное число");

int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1000 && number1>100)
{
    int number2 = (number1 % 10) * 100 + (number1 % 100 / 10) * 10 + number1 / 100;
    Console.WriteLine(number2);
}
else
    Console.WriteLine("Введи корректное число");



// Console.Write(number1 % 10);
//while ((number1 /= 10) != 0)
//Console.Write(number1 % 10);
