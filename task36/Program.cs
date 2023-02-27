// Задача 36.
// Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

int[] newArr = RandomArray(5);
PrintArray(newArr);
System.Console.WriteLine(GetMeSumOdd(newArr));


int GetMeSumOdd(int[] arr)
{
    int sumOdd = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if( i % 2 != 0)
        {
            sumOdd = sumOdd + arr[i];
        }
    }
    return sumOdd;
}


int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(0,100);
     }
     return arr;
}

void PrintArray(int[] arr)
{    
    foreach(int item in arr)
    {
        Console.Write($"{item}, ");
    } 
    Console.WriteLine();
}
