// Напишите программу, которая на вход принимает одно число N, а на выходе
// показывает все целые числа в промежутке от -N до N 

Console.WriteLine("Программа вычисления всех четных чисел от N до -N.");
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
int N2 = N * (-1);

if (N < 0)

{
    int temp = N;
    N = N2;
    N2 = temp;
}

    while (N2 <= N)
    { 
        Console.Write(N2 + " ");
        N2++;
    }