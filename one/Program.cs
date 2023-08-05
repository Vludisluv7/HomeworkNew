//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int Message(string Message)
{
    System.Console.WriteLine(Message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int number = Message("введите трехзначное число");
if (number <100 || number >= 1000)
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
    return;
}
System.Console.WriteLine($"Введенное число -> {number} <- ");
int SecondResult = number / 10 % 10;
System.Console.WriteLine($"Вторая цифра -> {SecondResult} <- ");