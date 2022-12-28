//   Задача 13.
// Напишите программу, которая на вход
// 1. принимает число и 
// 2. выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// 

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <=1000)

    Console.WriteLine($"Третья цифра введенного числа {number % 10} "); //)

else number >=1000;
{    
       while
    {       
        int tmp = number;       
        tmp = tmp - (tmp % 10); 

    Console.WriteLine("Третья цифра введенного числа  "); 
             
    } 
    while 
        (number <= 100);
     Console.WriteLine(" У введенного числа третьей цифры нет ");
}
        
    //    Console.WriteLine($"Третья цифра введенного числа {number % 10} ");


