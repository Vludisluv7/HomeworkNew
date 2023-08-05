//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int Message(string Message)
{
    System.Console.WriteLine(Message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int GetThirdNum(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool LowSizeNum(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("Третьей цифры нету");
        return false;
    }
    return true;
}

int number = Message("Введите число -> ");
if (LowSizeNum(number))
{
    System.Console.WriteLine(GetThirdNum(number));
}