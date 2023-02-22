/* Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int [] GetArray()
{
int [] array = new int [4];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
 {
  array [i] = rnd.Next (-100,100);
 }
    for (int i = 0; i < array.Length; i++)
     {
     Console.Write($"{array[i]}, ");
     }

return array;
}


int[] GetSumm(int [] arr)
{
int sum = 0;
for (int i = 0; i < arr.Length; i++)
  {
  if (arr[i] % 2 == 0)
    sum += arr[i];
  }
return sum;
}

GetArray();
GetSumm();
int [] arr = GetArray();
int result = GetSumm(arr);
Console.WriteLine($"Сумма элементов на нечетных позициях равна = {result}");