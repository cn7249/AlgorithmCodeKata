public class Solution
{
    public int[] solution(int[] arr)
    {

        if (arr.Length == 1)
        {
            int[] answer = new int[1];
            answer[0] = -1;
            return answer;
        }
        else
        {
            int[] answer = new int[arr.Length - 1];

            int minidx = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[minidx])
                {
                    minidx = i;
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                answer[i] = arr[i];

                if (i >= minidx)
                {
                    answer[i] = arr[i + 1];
                }
            }
            return answer;
        }
    }
}