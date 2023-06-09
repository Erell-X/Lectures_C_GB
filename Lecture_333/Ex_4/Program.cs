﻿
int[] arr = { 2, 8, 9, 9, 6, 4, 5 };

void PrintArray(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    System.Console.Write($"{array[i]} ");
  }
  System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length-1; i++)
  {
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[j] < array[minPosition]) minPosition = j;
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);