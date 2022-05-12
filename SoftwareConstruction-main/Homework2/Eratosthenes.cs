using System;

class Eratosthenes
{
    static void Main(String[] args)
    {
        Boolean[] isPrime = new Boolean[99];
        for(int i = 0; i < 99; i ++)
        {
            isPrime[i] = true;  
        }
        
        for(int i = 2; i <= 100; i ++)
        {
            if(isPrime[i-2])
            {
               
                for(int j = i + i; j <= 100; j+=i)
                {
                    isPrime[j-2] = false; // i的倍数不是质数
                }
            }
        }

       
 
        for(int i = 0;  i < 99; i++)
        {
            if(isPrime[i])
            {
                Console.WriteLine(i + 2);
            }
            
        }

        Console.ReadKey();



       
        
    }

    
}