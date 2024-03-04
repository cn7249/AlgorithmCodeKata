using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];

        int iNum, jNum, kNum;

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            iNum = commands[i, 0] - 1;
            jNum = commands[i, 1] - 1;
            kNum = commands[i, 2] - 1;

            int count = jNum - iNum + 1;
            int[] slicedArr = new int[count];

            for (int j = 0; j < count; j++)
            {
                slicedArr[j] = array[j + iNum];
            }

            for (int j = 0; j < slicedArr.Length; j++)
            {
                for (int k = j + 1; k < slicedArr.Length; k++)
                {
                    if (slicedArr[j] > slicedArr[k])
                    {
                        int temp = slicedArr[j];
                        slicedArr[j] = slicedArr[k];
                        slicedArr[k] = temp;
                    }
                }
            }

            answer[i] = slicedArr[kNum];
        }
        return answer;
    }
}