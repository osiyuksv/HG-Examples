
// Sting.Empty
// table[0, 0] table[0, 1] table[0, 2] ... table[0, 4]
// table[1, 0] table[1, 1] table[1, 2] ... table[1, 4]

string[,] table = new string[2, 5];
table[1, 2] = "слово";

for (int rows = 0;rows < 2;rows++)
{
  for (int columns = 0; columns < 5; columns++)
  {
    Console.Write($"-{table[rows, columns]}-"); // компеляция
  }
    Console.WriteLine();
}

Console.WriteLine();

int[,] matrix = new int[3, 4];
matrix[1, 2] = 1;
for (int i = 0;i < matrix.GetLength(0);i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} "); // компеляция
  }
  Console.WriteLine();
}



void PrintArray(int[,] matr)
{
    for (int i = 0;i < matr.GetLength(0);i++)
    {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
        Console.Write($"{matr[i, j]} "); 
      }
      Console.WriteLine();
    }
}
Console.WriteLine();
PrintArray(matrix);

void FillArray(int[,] matrx)
{
  for (int i = 0;i < matrx.GetLength(0);i++)
    {
      for (int j = 0; j < matrx.GetLength(1); j++)
      {
        matrx[i, j] = new Random().Next(1, 10);
      }
    }
}
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);