public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        char[] chars = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            chars[i] = char.Parse(s.Substring(i, 1));
        }

        for (int i = 0; i < chars.Length; i++)
        {
            for (int j = i; j < chars.Length; j++)
            {
                if (chars[i] < chars[j])
                {
                    char temp = chars[i];
                    chars[i] = chars[j];
                    chars[j] = temp;
                }
            }
        }

        foreach (char c in chars)
        {
            answer += c;
        }

        return answer;
    }
}