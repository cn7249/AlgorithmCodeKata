using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        string[] numbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (s.Contains(numbers[i]))
            {
                string[] splited = s.Split(numbers[i]);
                string temp = "";
                for (int j = 0; j < splited.Length - 1; j++)
                {
                    temp += splited[j] + i.ToString();
                }
                temp += splited[splited.Length - 1];
                s = temp;
            }
        }

        answer = int.Parse(s);
        
        return answer;
    }
}