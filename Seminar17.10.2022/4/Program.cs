// Напишите программу, которая на вход принимает одно число N, а на выходе
// показывает все целые числа в промежутке от -N до N 

Console.WriteLine("Программа вычисления всех четных чисел от N до -N.");
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
int count = 0, number1 = N, number2 = - N, what = number2;

while (0 > number2)
{ 
    what = number2 + count;
    count++;
    Console.WriteLine(what);
}
