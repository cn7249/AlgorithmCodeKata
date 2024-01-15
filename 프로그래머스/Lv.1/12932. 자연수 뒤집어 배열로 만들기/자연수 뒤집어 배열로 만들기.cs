public class Solution
{
    public int[] solution(long n)
    {
        string input = n.ToString();
        int[] answer = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            int temp = input.Length - 1 - i;
            string tempString = input.Substring(temp, 1);
            answer[i] = int.Parse(tempString);
        }
        return answer;
    }
}