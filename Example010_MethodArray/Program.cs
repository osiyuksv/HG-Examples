// в массиве из n эдементов найти 
// индекс первого элемента равный заданному find
int[] array = {1, 12, 31, 4, 15, 16, 17, 18};

int n = array.Length;
int find = 4;
int index = 0;

while(index < n)
{
  if(array[index] == find)
  {
    Console.Write("Номер заданного первого элемента в массиве = ");
    Console.WriteLine(index);
    break;
  }
    index++;
}

