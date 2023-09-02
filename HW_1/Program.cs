// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число 1: ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int numB = int.Parse(Console.ReadLine()!);
int Sum=numA;
for (int i = 1; i < numB; i++)
{
    Sum= numA*Sum;
}
Console.WriteLine($"Число {numA}^{numB} = {Sum}");