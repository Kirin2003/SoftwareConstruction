using System;

class Prime
{
    static void Main(String[] args)
    {
        Console.WriteLine("请输入一个数：");
        string input = Console.ReadLine();
        
        int n = int.Parse(input);
        HashSet<int> primes = new HashSet<int>();
        
        getPrime(n, primes);

        foreach(int i in primes)
        {
            Console.Write(i);
            Console.WriteLine();
        }
        Console.ReadLine();
    }

    static void getPrime(int n,  HashSet<int> primes)
    {
        // 找给定数字的所有素数因子
        // 设定i=2，i一直递增，当N%i==0的时候，N/=i，否则i++，直到i>N，这样找到的所有N%i==0的i就是N的所有的质数因子
        int primeNum = 0;
        for (int i = 2; i <= n; i++)
        {
            if(n%i == 0)
            {
                primes.Add(i);
                while(n%i == 0)
                {
                    n /= i; // 连除
                }

            }
            primeNum++;
            
        }
    }
}