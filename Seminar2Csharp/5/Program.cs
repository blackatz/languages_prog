﻿// напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого

Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine()!);

 if (IsSquare(number1, number2))
     {
         Console.WriteLine("Да");
     }
 else
     {
         Console.WriteLine("Нет");
     }

bool IsSquare(int number1, int number2)
{
    return number1 == number2 * number2 || number2 == number1 * number1;
}
