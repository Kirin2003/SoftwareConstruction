using System;

class Toeplitz
{
    static void Main(String[] args)
    {
        int[,] a = { { 1, 2}, { 2,2 } };
        int[,] b = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };

        Console.WriteLine(isToeplitz(2,2,a));
        Console.WriteLine(isToeplitz(3,4,b));


    }

    static bool isToeplitz( int row, int col, int[,] a)
    {
        int num = row * col;
        // 从左上到右下对角线上所有元素相等是Toeplitz矩阵
        for(int i = 0; i < col; i++) // 遍历第1行
        {
            int value = a[0, i];
            // 找对角线上的元素
            int j = 1;
            int k = i+1;
            for (; j < row && k < col; j++,k++)
            {
                if(a[j,k] != value)
                {
                    return false;
                }
            }
        }
        return true;
    }
        

}