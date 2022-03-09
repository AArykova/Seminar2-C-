// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
string num =(Console.ReadLine());
Dig3(num);

void Dig3(string number)
{
    if (number.Length < 3)
    {
        Console.WriteLine("Третьей цифры в заданном числе нет");
    }
    else
    {
        Console.WriteLine("Третья цифра - " + number[2]);
    }
}