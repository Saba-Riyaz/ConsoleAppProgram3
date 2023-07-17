using System;
public class SingleNumberSolution
{ public int FindSingleNumber(int[] nums) 
    { int result = 0; 
        foreach (int num in nums) 
        {
            result ^= num; 
        } 
        return result; 
    } 
}
class Program 
{
    static void Main() 
    { int[] nums = { 2, 2, 1 };
        SingleNumberSolution solution = new SingleNumberSolution();
        int singleNumber = solution.FindSingleNumber(nums);
        Console.WriteLine($"The single number that appears only once:" +
            $" {singleNumber}"); 
    }
}

