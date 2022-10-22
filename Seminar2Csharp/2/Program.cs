// напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа, например 456 = 46

int GenerateRandomNumber() 
{
    return new Random().Next(100, 1000);
}

int Number(int random) 
{
    int firstnumber = random / 100; //количество сотен
    int secondnumber = random %100; //остаток от деления на 10, количество единиц в числе

    return random;
}

int random = GenerateRandomNumber();
int number = Number(random);

Console.WriteLine("Сгенерировано число " + random);
Console.WriteLine("Сделано число " + number);

