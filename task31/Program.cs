// Задача 31: 
// Задайте массив из 12 элементов, 
// 1.заполненный случайными числами из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и положительных элементов массива. 3. Вывести результаты.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size]; //array.Length==size
    var rnd = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(min, max+1);
}
    return array;    
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");   
    }
    Console.WriteLine("]");
}  

int[] GetSumPosNegElem(int[] array)
{
    int sumPos = default;
    int sumNeg = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNeg += array[i]; //sumnNegative = sumnNegative + array[i]
        else sumPos += array[i];               //sumPositive = sumPositive + array[i]
    }

    return new int[] { sumPos, sumNeg };
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getsumPosNegElem = GetSumPosNegElem(arr);
Console.WriteLine($"Сумма положительных элементов = {getsumPosNegElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {getsumPosNegElem[1]}");
