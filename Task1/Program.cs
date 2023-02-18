/*Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] InitArray()
{
int[] result = new int[4];
Random rnd = new Random();

for (int i = 0; i < result.Length; i++)
{
result[i] = rnd.Next(100,999);
}

return result;
}

int GetEvenDigit(int [] arr)
{
int evenNumber = 0;
for (int i = 0; i < arr.Length; i++)
{
 if (arr[i] % 2 == 0)
    {
    evenNumber += 1;
    }
}
return evenNumber;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

int [] arr = InitArray();
PrintArray(arr);
int evenDigit = GetEvenDigit(arr);

Console.Write($"В массиве - {evenDigit} четных чисел");
