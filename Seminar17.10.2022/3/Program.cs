// Напишите программу, которая будет выдавать название дня недели по заданному номеру

Console.WriteLine("Программа вычисления Дня недели.");
Console.WriteLine("Введите число дня: ");
int input1 = int.Parse(Console.ReadLine()!);

if (0 < input1 && input1 < 8) 
  { if (input1 == 1) Console.WriteLine("Это понедельник");
    if (input1 == 2) Console.WriteLine("Это вторник");
    if (input1 == 3) Console.WriteLine("Это среда");
    if (input1 == 4) Console.WriteLine("Это четверг");
    if (input1 == 5) Console.WriteLine("Это пятница");
  }
  else {
  Console.WriteLine("Такого дня нет");
  }