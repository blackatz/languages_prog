// напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);

if (multiptisity(number))
    {
        Console.WriteLine("Да");
    }
else
    {
        Console.WriteLine("Нет");
    }

bool multiptisity(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

multiptisity(number);
