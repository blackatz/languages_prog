// напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа, например 456 = 46

int GenerateRandomNumber() 
{
    return new Random().Next(100, 1000);
}

int OutSecondDigit(int randomNumber)
{
    Console.WriteLine(randomNumber);
    int firstnumber = randomNumber / 100;
    int thirdnumber = randomNumber %10;
    return (firstnumber*10 + thirdnumber);
}

int randomNumber = GenerateRandomNumber();

Console.WriteLine(OutSecondDigit(randomNumber));