public class Solution
{
    public string solution(string[] seoul)
    {
        string answer = "";
        int count = 0;
        foreach (string name in seoul)
        {
            if (name == "Kim")
            {
                answer = $"김서방은 {count}에 있다";
                break;
            }

            count++;
        }
        return answer;
    }
}