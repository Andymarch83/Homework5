/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int[] InitArray()
{
    int[] result = new int[14];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100,999);
    }

    return result;
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    int count = 0;
    
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
        
        if(arr[i]%2==0) count = count +1;
       
    } 
    Console.Write($"{arr[arr.Length-1]} ]");
    Console.Write($" -> {count}");
}
int [] arr = InitArray();
PrintArray(arr);