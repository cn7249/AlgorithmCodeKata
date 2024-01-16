public class Solution
{
    public bool solution(int x)
    {
        string input = x.ToString();
        int[] arr = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            arr[i] = int.Parse(input[i].ToString());
        }

        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        bool answer = true;

        if (x % sum != 0)
        {
            answer = false;
        }

        return answer;
    }
}