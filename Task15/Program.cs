// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// по умолчанию: 1- понедельник, 2 - вторник и т.д.


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number == 6 || number == 7)
{
    Console.WriteLine("выходной");
}

if (1 <= number && number <=5)
{
    Console.WriteLine("не выходной");
}

if (number <= 0 || number > 7)
{
    Console.WriteLine("такого дня не существует");
}

