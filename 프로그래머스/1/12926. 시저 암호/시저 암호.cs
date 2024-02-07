public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        string upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";

        for (int i = 0; i < s.Length; i++)
        {
            string part = s.Substring(i, 1);

            if (upperAlphabet.Contains(part))
            {
                int index = upperAlphabet.IndexOf(part);
                index += n;
                int num = index % 26;
                answer += upperAlphabet.Substring(num, 1);
            }
            else if (lowerAlphabet.Contains(part))
            {
                int index = lowerAlphabet.IndexOf(part);
                index += n;
                int num = index % 26;
                answer += lowerAlphabet.Substring(num, 1);
            }
            else
            {
                answer += " ";
            }
        }
        
        return answer;
    }
}