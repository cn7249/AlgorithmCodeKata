public class Solution
{
    public int solution(long num)
    {
        int count = 0;

        while (num > 1)
        {
            count++;

            if (num % 2 == 0)
            {
                num /= 2;
            }
            else if (num % 2 == 1)
            {
                num = (num * 3) + 1;
            }

            if (count >= 500)
            {
                break;
            }
        }

        int answer = 0;
        answer = count;

        if (count >= 500)
        {
            answer = -1;
        }

        return answer;
    }
}