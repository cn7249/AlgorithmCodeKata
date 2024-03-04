using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = { };

        List<int> sum = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int temp = numbers[i] + numbers[j];
                bool isContains = sum.Contains(temp);

                if (!isContains)
                    sum.Add(temp);

                sum.Sort();
            }
        }

        answer = sum.ToArray();
        return answer;
    }
}