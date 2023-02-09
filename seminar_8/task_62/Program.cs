/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

 */


void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {

        for (int j = 0; j < numbers.GetLength(1); j++)
            System.Console.Write(numbers[i, j] + "\t");

        System.Console.WriteLine();
    }
}


int[,] MakeSpiralMatrix(int row, int col)
{
    int[,] mtrx = new int[row, col];
    int step = 1;
    int endX = mtrx.GetLength(0) - 1, endY = mtrx.GetLength(1) - 1, startY = 0;
    for (int i = 0; i <= endX; i++)
    {
        for (int j = startY; j <= endY; j++)
        {
            mtrx[i, j] = step;
            step++;
        }

        for (int m = i + 1; m <= endX; m++)
        {
            mtrx[m, endY] = step;
            step++;
        }

        for (int n = endY - 1; n >= startY; n--)
        {
            mtrx[endX, n] = step;
            step++;
        }

        for (int m = endX - 1; m > i; m--)
        {
            mtrx[m, startY] = step;
            step++;
        }
        endX--; endY--; startY++;
    }
    return mtrx;
}

int x = 15, y = 10;
PrintArray(MakeSpiralMatrix(x,y));
/*x = 15, y = 10

➤ dotnet run
1       2       3       4       5       6       7       8       9       10
46      47      48      49      50      51      52      53      54      11
45      84      85      86      87      88      89      90      55      12
44      83      114     115     116     117     118     91      56      13
43      82      113     136     137     138     119     92      57      14
42      81      112     135     150     139     120     93      58      15
41      80      111     134     151     157     121     94      59      16
40      79      110     158     152     156     160     95      60      17
39      78      109     159     153     155     123     96      61      18
38      77      108     131     154     143     124     97      62      19
37      76      107     130     145     144     125     98      63      20
36      75      106     129     128     127     126     99      64      21
35      74      105     104     103     102     101     100     65      22
34      73      72      71      70      69      68      67      66      23
33      32      31      30      29      28      27      26      25      24
*/