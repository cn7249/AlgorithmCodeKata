public class Solution {
    public string solution(string s) {
        string answer = "";

        string[] strings = s.Split(' ');

        foreach (string word in strings)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    answer += word.Substring(i, 1).ToUpper();
                }
                else
                {
                    answer += word.Substring(i, 1).ToLower();
                }
            }

            answer += " ";

        }

        answer = answer.Substring(0, answer.Length - 1);
        
        return answer;
    }
}