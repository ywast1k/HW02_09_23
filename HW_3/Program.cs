﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int inputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int NumOfDigits(int num)
{
int i;
for (i = 0; num != 0; i++)
num /= 10;
return i;
}

void SumNumbers(int amount, int number)
{
 int sum = 0;
 for (int i = 1; i <= amount; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine(sum);
}

int number = inputNum("Введите число: ");

int amount = NumOfDigits(number);
SumNumbers(amount, number);
