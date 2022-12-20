// осторртировать массив по убыванию

int[] arr ={1, 11, 3, 7, 5, 6, 3, 8, 3, 5};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
      Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
 
    for(int i = 0; i < array.Length - 1; i++)
    {
      int maxPosition = i;

      for(int j = i+1; j < array.Length; j++)
      {
        if(array[j] > array[maxPosition]) maxPosition = j;
      }

      int temprorary = array[i];
      array[i] = array[maxPosition];
      array[maxPosition] = temprorary;
    }

}

PrintArray(arr);
Console.WriteLine();

SelectionSort(arr);
PrintArray(arr);
