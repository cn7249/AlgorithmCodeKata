
public class Solution
{
    public long solution(long n)
    {
        string input = n.ToString();
        int[] arr = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            arr[i] = int.Parse(input[i].ToString());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        string answer = "";

        for (int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }

        return long.Parse(answer);
    }
}