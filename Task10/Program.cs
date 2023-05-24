// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Random random = new Random(); 
int number = random.Next(100, 1000); 
int digit = ((number/10)%10);


Console.WriteLine(number);
Console.WriteLine(digit);



