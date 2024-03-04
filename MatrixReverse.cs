
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating the original array
        int[][] originalArray = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };

        // Rotating the array by 90 degrees
        int[][] rotatedArray90 = RotateArray90(originalArray);

        // Printing the rotated array
        PrintArray(rotatedArray90);
        // output
        // [[7, 4, 1],
        // [8, 5, 2],
        // [9, 6, 3]]

       int[][] rotatedArray180 = RotateArray180(originalArray);

       // Printing the rotated array
        PrintArray(rotatedArray180);
       //output
       //[[9,8,7], 
       //[6,5,4], 
       //[3,2,1]]
    }


   static int[][] RotateArray180(int[][] original)
   {
       var outputM = new int[a.GetLength(0)][];
       var x = 0;
       for(int i = a.Length - 1; i >= 0; i--)
       {
            var y = 0;
            outputM[x] = new int[a[i].Length];
            for(int j = a[i].Length - 1; j >= 0; j--)
          {
              outputM[x][y] = a[i][j];
               y++;
          }
          x++;
 }
 
 
 return outputM;
   }
  
    static int[][] RotateArray90(int[][] original)
    {
        int rows = original.Length;
        int columns = original[0].Length;

        // Transpose the array
        int[][] transposedArray = new int[columns][];
        for (int i = 0; i < columns; i++)
        {
            transposedArray[i] = new int[rows];
            for (int j = 0; j < rows; j++)
            {
                transposedArray[i][j] = original[j][i];
            }
        }

        // Reverse each row
        int[][] rotatedArray = new int[columns][];
        for (int i = 0; i < columns; i++)
        {
            rotatedArray[i] = new int[rows];
            for (int j = 0; j < rows; j++)
            {
                rotatedArray[i][j] = transposedArray[i][rows - 1 - j];
            }
        }

        return rotatedArray;
    }

    static void PrintArray(int[][] array)
    {
        foreach (int[] row in array)
        {
            foreach (int element in row)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
