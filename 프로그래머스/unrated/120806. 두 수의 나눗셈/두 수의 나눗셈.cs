using System;

public class Solution
{
    public int solution(int num1, int num2)
    {
        double a = (double)num1;
        double b = (double)num2;

        double quotient = a / b;
        double answer = quotient * 1000;
        return (int) answer;
    }
}