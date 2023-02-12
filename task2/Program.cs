void FillArray(int[,]matr)
{
  for(int i = 0;i < matr.GetLength(0);i++)
  {
    for(int j = 0;j < matr.GetLength(1);j++)
    {
      matr[i,j] = i+j;
    }
  }
}
void PrintArray(int [,] matrix)
{
  for(int i = 0;i < matrix.GetLength(0);i++)
  {
    for(int j = 0;j < matrix.GetLength(1);j++)
    {
      Console.Write(matrix[i,j] + "  ");
    }
    System.Console.WriteLine();
  }
}
System.Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int [,] array = new int [n,m];
FillArray(array);
PrintArray(array);
