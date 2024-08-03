using System;
using System.Linq;

class Program
{

    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size ; i++)
        {
            array[i] = rand.Next(1, 10);
        }
        return array;
    }

    static int[] findindexsum(int[] a , int result){
           
            int[] final = new int[2];
            int len = a.Length;
            for(int ii=0 ; ii < len - 1 ; ii++){
                //Console.WriteLine($"Checking indices {ii} and {ii + 1}: {a[ii]} + {a[ii + 1]}");  debug condition 
                if(a[ii]+a[ii+1]==result){
                    final[0] = ii;
                    final[1] = ii+1;
                    return final;
                }
            }
        return null;
    
    }
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10);

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        
        int target = int.Parse(Console.ReadLine());

         int[]  result =  findindexsum(array,target);

         if(result!= null){
            Console.WriteLine($"{result[0]}, {result[1]}");
            
         }
         else {
            Console.WriteLine("No sum found ");
         }
    }
}

