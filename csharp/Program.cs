using System;

class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 50; i++)  
        {  
            if (i % 3 == 0 && i % 5 == 0)  
            {  
                Console.WriteLine(i + " fizzbuzz");  
            }  
            else if (i % 3 == 0)  
            {  
               Console.WriteLine(i + " fizz");  
            }  
            else if (i % 5 == 0)  
            {  
               Console.WriteLine(i + " buzz");  
            }  
            else  
            {  
                Console.WriteLine(i);  
            }  
        }
    }  
} 