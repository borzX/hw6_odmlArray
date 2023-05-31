﻿Console.WriteLine("Введите номер задачи:");
int taskNumber = Convert.ToInt32(Console.ReadLine());

switch (taskNumber)
{
    case 41:
        TaskNumber41();
        break;

    case 43:
        TaskNumber43();
        break;

    default:
        Console.WriteLine("Вы ввели неверный номер");
        break;
}

void TaskNumber41()
{
    Console.WriteLine();
    Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. " + 
                    "Посчитайте, сколько чисел больше 0 ввёл пользователь. " +
                    "\n 0, 7, 8, -2, -2 -> 2" + "\n 1, -7, 567, 89, 223-> 3");
    Console.WriteLine();

    Console.WriteLine("Введите числа через запятую (без пробелов) и нажмите клавишу Enter :");

    string num = Console.ReadLine()!;
    string[] numArray = num.Split(' ',',',';');
    int numLenght = num.Length;
    int[] array1 = new int[numLenght];
    int countPositiv = 0;
    int countNegativ = 0;
    for (int i=0; i<numArray.Length; i++)
    {
        array1[i] = Int32.Parse(numArray[i]);
        if (array1[i] > 0) countPositiv++;
        else countNegativ++;
    }

    Console.WriteLine($"Введено чисел больше 0: {countPositiv}");

    // Просморт массива
    // Console.WriteLine(String.Join(", ", array1));
    
}


void TaskNumber43()
{
    Console.WriteLine();
    Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, " + 
                    "заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; " + 
                    "значения b1, k1, b2 и k2 задаются пользователем " + 
                    "\n b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
    Console.WriteLine();
    
    Console.Write("Введите значение k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());

    double xCoord = (b1-b2)/-(k1-k2);
    double yCoord = k1*xCoord+b1;

    Console.WriteLine($"Координаты точки пересечения прямых: {xCoord}, {yCoord}");
}
    