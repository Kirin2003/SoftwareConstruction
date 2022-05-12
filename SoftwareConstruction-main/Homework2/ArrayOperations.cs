using System;

class ArrayOperations
{
    static void Main(String[] args)
    {
        int[] i = { 1, 2, 3 };
        int max = i[0];
        int min = i[0];
        int sum = 0;
        int ave = 0;
        foreach (int i2 in i)
        {
            if(i2 < min)
            {
                min = i2;

            } 
            if(i2 > max)
            {
                max = i2;
            }
            sum += i2;


        }
        ave = sum / i.Length;
        Console.WriteLine("最大值为{0}，最小值为{1}，和为{2}，平均值为{3}", max, min, sum, ave);

    }

    
}