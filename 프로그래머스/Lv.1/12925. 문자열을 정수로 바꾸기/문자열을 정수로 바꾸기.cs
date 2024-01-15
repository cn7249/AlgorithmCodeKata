public class Solution
{
    public int solution(string s)
    {
        char temp = s[0];
        int answer = 0;
        switch (temp)
        {
            case '+':
                answer = int.Parse(s.Substring(1));
                break;
            case '-':
                answer = -int.Parse(s.Substring(1));
                break;
            default:
                answer = int.Parse(s);
                break;
        }
        return answer;
    }
}