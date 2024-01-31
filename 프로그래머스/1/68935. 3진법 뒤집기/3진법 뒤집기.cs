using System;

public class Solution
{
    public int solution(int n)
    {
        if (n == 1)
            return 1;
        
        int answer = 0;
        int remainder = n % 3;
        string temp = "";

        while (true)
        {
            temp += remainder.ToString();
            n /= 3;
            remainder = n % 3;

            if (n < 3)
            {
                temp += remainder.ToString();
                break;
            }
        }


        for (int i = 0; i < temp.Length; i++)
        {
            int pow = temp.Length - 1 - i;
            int num = int.Parse(temp.Substring(i, 1)) * (int)Math.Pow(3, pow);
            answer += num;
        }

        return answer;
    }
}