void FillArray(int[,] matr)
{
  Random rand = new Random();
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = rand.Next(1, 11);
    }
  }
}

void PrintArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + "  ");
    }
    System.Console.WriteLine();
  }
}

void ReversY(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    int temp = arr[arr.GetLength(0)-1, i];
      arr[arr.GetLength(0)-1, i] = arr[0, i];
      arr[0, i] = temp;
  }
}

System.Console.WriteLine("Введите чило n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,]array = new int[n,m];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ReversY(array);
PrintArray(array);
Console.ReadKey();