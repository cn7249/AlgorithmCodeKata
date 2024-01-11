using System;
using System.Diagnostics.CodeAnalysis;

public class Solution
{
    public double solution(int[] numbers)
    {
        double answer = 0;
        float sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        answer = sum / numbers.Length;
        return answer;
    }
}