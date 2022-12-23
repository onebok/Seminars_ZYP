//  Задача 15.
// Напишите программу, которая принимает на вход
// 1. цифру, обозначающую день недели,
// 2. и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите целое число от 1 до 7: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(IsSquare(number1, number2) ? "да" : "нет");

// bool IsSquare(int n1, int n2)
// {
//    return (n1 / n2 == n2) || (n2 / n1 == n1);
// }


if (weekDay < 1 & weekDay >7)
{
   Console.WriteLine("Число введено неверно"); 
}


Console.WriteLine(WeekDay(wd) ? "рабочий день" : "выходной");

bool WeekDay(int wd)
{
   return (wd > 1 & wd < 5) || (wd == 5 || wd == 6);
}

