//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//  6, 1, 33 -> [6, 1, 33]
 
int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[] ArrayOfNumbers(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        {
        array[i] = new Random().Next(10); // поменять если  необходимы числа большего формата
        }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
        System.Console.Write(array[i] + " ");
        }
}

int size = InputNum("Введите размер массива: ");
int[] result = ArrayOfNumbers(size);
PrintArray(result);
//
//


