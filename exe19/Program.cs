/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? "";
    int result = Convert.ToInt32(value);
    return result;
}

void GetNRank(int number)
{
    if (number / 10000 == number %10 && number / 1000 % 10 == number % 100 / 10)
    Console.WriteLine("Число является полиндромом");
    else 
    Console.WriteLine("Число НЕ является полиндромом");
}

bool ValidateNumber(int number)
{
    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Ошибка ввода числа, попробуй еще");
        return false;
    }
    return true;
}

int number = Prompt("Введите пятизначное число ");
if (ValidateNumber(number))
{
    GetNRank(number);
}

