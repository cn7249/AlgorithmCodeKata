using System;
public class Solution
{
    public bool solution(string s)
    {
        bool answer = true;
        int temp;

        answer = Int32.TryParse(s, out temp);

        if (!(s.Length == 4 || s.Length == 6))
        {
            answer = false;
        }
        
        return answer;
    }
}