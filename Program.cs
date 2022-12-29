/*  25. Напишите цикл, который принимает на вход два числа (А и В) 
и возводит число А в натуральную степень В 
3,5 -> 243
2,4 -> 16 
*/
int a;
int b;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine(), out a);

Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine(), out b);
int x = a;
int c = 1;

while (c <= b)
{
    a *= a;
    c++;
}
Console.Write($" {a}, {b} -> {c}");