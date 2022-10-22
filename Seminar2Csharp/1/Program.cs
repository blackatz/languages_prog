//напишите программу, которая выводит случайное число из отрезка 10,99 
//и показывает наибольшую цифру числа

int GenerateRandomNumber() 
{
    return new Random().Next(10, 100);
}

int GetMaxDigit(int random) 
{
    int firstnumber = random / 10; //деление на 10, десятки
    int secondnumber = random %10; //остаток от деления на 10, единицы

    // показать наибольшую цифру числа

    int max = secondnumber;

    if (firstnumber > secondnumber) max = firstnumber;
    return max;
}

// генерация случайных чисел

int random = GenerateRandomNumber();
Console.WriteLine("Сгенерировано число " + random);

// найти наибольшую цифру числа
int max = GetMaxDigit(random);

Console.WriteLine("Наибольшая цифра числа: " + max);
