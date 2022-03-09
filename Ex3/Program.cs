// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number<=7 && number>=1)
    if (number==6 || number==7)
        Console.WriteLine("Это выходной день");
    else
        Console.WriteLine("Это будний день");
else 
    Console.WriteLine("Введите корректный день недели");