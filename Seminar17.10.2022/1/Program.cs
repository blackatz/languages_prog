﻿// Напишите программу, которая на вход принимает целое число
// и выдает (на консоль) его квадрат
// число умноженное само на себя

Console.WriteLine("Программа вычисления квадрата числа.");
Console.WriteLine("Введите число: ");
// 1. Ввод числа
int input = int.Parse(Console.ReadLine()!);
// 2. Вычисление квадрата числа
int result = input * input;
// 3. Вывод результата на консоль
Console.WriteLine("Квадрат числа: " + result);