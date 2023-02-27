
// Задача 39.
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - 
// на последнем и т.д.)


int[] newArr = RandomArray(5);
PrintArray(newArr);
PrintArray(RewersArray(newArr));

int[] RewersArray(int[] arr)
{
    int length  = arr.Length;
    int[] result = new int[length];

    for(int i = 0; i < length; i++)
    {
       result[i] = arr[length -1 -i];
    }
    return result;

}


int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(1,100);
     }
     return arr;
}

void PrintArray(int[] arr)
{
    
    foreach(int item in arr)
    {
        System.Console.Write($"{item}, ");
    } 
    System.Console.WriteLine();
}