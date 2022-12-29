/*  25. Напишите цикл, который принимает на вход два числа (А и В) 
и возводит число А в натуральную степень В 
3,5 -> 243
2,4 -> 16 
*/
int a;
int b;
int x = 1;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine(), out a);

Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine(), out b);

for (int i = 1; i <= b; i++)
{
    x *= a;
}

Console.Write($" {a}, {b} -> {x}");