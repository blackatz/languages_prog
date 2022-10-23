// напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число 
// кратным первому. если число 2 не кратно числу 1, то программа выводит остаток от деления

void res(int number1, int number2)
    {
        int result = number1 % number2;

if (result == 0)
    {
        Console.WriteLine("Первое число кратно второму");
    }
else
    {
        Console.WriteLine("Первое число не кратно второму");
        Console.WriteLine("Остаток составляет: " + result);
    }

    }


Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine()!);


res(number1, number2);
