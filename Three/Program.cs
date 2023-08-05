//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


int Message(string Message)
{
    System.Console.WriteLine(Message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

bool WeekFunct(int DayWeek)
{
    if (DayWeek > 5)
    {
        return true;
    }
    return false
}

bool CheckWeekDay(int number)
{
    if (number > 0 || number <= 7)
    {
        return true;
    }
    System.Console.WriteLine("Таких дней недели не существует!");
    return false;
}

int DayWeek = Message("Введите день недели -> ");
if (CheckWeekDay(DayWeek))
{
    if (WeekFunct(DayWeek))
    {
        System.Console.WriteLine("Ура выходной)");
    }
    else
    {
        System.Console.WriteLine("Ну блин рабочий день(");
    }
}