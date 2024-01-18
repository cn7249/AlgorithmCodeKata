using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int answer = 0;
        int sum = 0;

        int[] nums = new int[10];
        for (int i = 0; i < 10; i++)
        {
            nums[i] = i;
            sum += i;
        }

        foreach (int i in numbers)
        {
            foreach (int j in nums)
            {
                if (i == j)
                {
                    answer += i;
                }
            }
        }

        answer = sum - answer;

        return answer;
    }
}