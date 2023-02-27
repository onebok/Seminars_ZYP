//Задача 44
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

PrintFibNum(7);
void PrintFibNum(int N)
{
    int firstNum = 0;
    int secondNum = 1;
    if(N == 1)
    {
        Console.WriteLine(firstNum);
        return;
    }
    
    System.Console.WriteLine(firstNum);
    Console.WriteLine(secondNum);
    for(int i = 3; i <= N; i++)
    {
        int curentNum = firstNum + secondNum;
        Console.WriteLine(curentNum);
        firstNum = secondNum;
        secondNum = curentNum;  
    }
}