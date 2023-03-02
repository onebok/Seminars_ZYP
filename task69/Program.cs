// Задача 69.
// напишите программу, которая на вход принимает
// два числа A и B, и возводит A в целую 
// степень B с помощью рекурсии
// A = 3; B = 5 -> 243 (3^5)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите основание: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = GetPowNum(number1, number2);
Console.WriteLine(result);

int GetPowNum(int num, int pow)
{
    if(pow == 0) return 1;
    int res = num;
    res *= GetPowNum(num, pow - 1);
    return res;
}
