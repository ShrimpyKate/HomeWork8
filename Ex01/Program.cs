// Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить 
//  строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка

//1.set size of matrix
(int, int) GetSizeByUser()
{
  Console.WriteLine("Введите размер массива: ");
  int row = Convert.ToInt32(Console.ReadLine());
  int columns = Convert.ToInt32(Console.ReadLine());
  return (row, columns);
}

//2.creat matrix and fill it
int[,] GenerateMatrix(int row, int column)
{
  int[,] arr = new int[row, column];

  for (int r = 0; r < row; r++)
  {
    for (int c = 0; c < column; c++)
    {
      arr[r, c] = Convert.ToInt32(new Random().Next(0, 10));
      Console.Write(arr[r, c] + " ");
    }
    Console.WriteLine();
  }
  return arr;
}
//3.Calculate the sum
string GetMinSumOfRow(int[,] matr)
{
  int tempr = 0;
  int mintemp = 0;
  for (int c = 0; c < matr.GetLength(1); c++)
  {
    mintemp += matr[0, c];
  }

  for (int r = 1; r < matr.GetLength(0); r++)
  {
    int sum = 0;
    for (int c = 0; c < matr.GetLength(1); c++)
    {
      sum += matr[r, c];
    }
    if (mintemp > sum)
    {
      mintemp = sum;
      tempr = r;
    }
  }
  Console.WriteLine($"Минимальная сумма в троке: {mintemp}");
  return $"{tempr}";
}

(int row, int column) size = GetSizeByUser();
int[,] matrix = GenerateMatrix(size.row, size.column);
string minsum = GetMinSumOfRow(matrix);
Console.WriteLine($"Номер строки сумма в которой является минимальной: {minsum} ");