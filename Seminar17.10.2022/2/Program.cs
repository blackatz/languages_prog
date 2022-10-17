// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго

// ввод чисел
Console.WriteLine("Программа вычисления, равен ли квадрат первого числа второму числу.");
Console.WriteLine("Введите первое число: ");
int input1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Программа вычисления, равен ли квадрат первого числа второму числу.");
Console.WriteLine("Введите второе число: ");
int input2 = int.Parse(Console.ReadLine()!);
//возведение в квадрат
int div = input2 * input2;
    if (div == input1)
    {
        Console.WriteLine("Да, является");
    }
    else 
    {
        Console.WriteLine("Нет, не является");
    }
//сравнение
