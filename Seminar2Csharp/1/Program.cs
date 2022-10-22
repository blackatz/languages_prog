//напишите программу, которая выводит случайное число из отрезка 10,99 
//и показывает наибольшую цифру числа

// генерация случайных чисел

int random = new Random().Next(10, 100);

// найти наибольшую цифру числа

int firstnumber = random / 10;
int secondnumber = random %10; //остаток от деления на 10

Console.WriteLine(random);

// показать наибольшую цифру числа

int max = secondnumber;

if (firstnumber > secondnumber) max = firstnumber;

Console.WriteLine("Наибольшая цифра числа: " + max);
