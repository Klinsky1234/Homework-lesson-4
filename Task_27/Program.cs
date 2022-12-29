/*  27. Напишите прогу, которая принимает на вход число 
и выдаёт сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12
*/

int a;
Console.Write($" Ведите число: ");
int.TryParse(Console.ReadLine(), out a);
int b = a;
int sum = 0;

while (b > 0)
{
    sum = sum + b % 10;
    b /= 10;
}

Console.WriteLine($" {a} -> {sum}");