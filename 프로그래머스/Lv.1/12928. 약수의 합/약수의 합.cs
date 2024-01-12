using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n)
    {
        List<int> aliquots = new List<int>();

        for (int i = n; i > 0; i--)
        {
            if (n % i == 0)
            {
                aliquots.Add(i);
            }
        }

        int answer = 0;

        foreach (int aliquot in aliquots)
        {
            answer += aliquot;
        }
        return answer;
    }
}
