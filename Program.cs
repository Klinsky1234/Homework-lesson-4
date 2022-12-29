/* 29. Напишите программу, которая задаёт массив из 8 элекментов и выводит их на экран */

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(100);
    Console.Write($" [{i}] = {array[i]}\n ");
}