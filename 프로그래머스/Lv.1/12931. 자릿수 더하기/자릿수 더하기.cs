using System;

public class Solution
{
    public int solution(int n)
    {
        string input = n.ToString(); ;
        int[] arr = new int[input.Length];
        int answer = 0;

        for (int i = 0; i < input.Length; i++)
        {
            arr[i] = Convert.ToInt32(input.Substring(i, 1));
            answer += arr[i];
        }

        return answer;
    }
}