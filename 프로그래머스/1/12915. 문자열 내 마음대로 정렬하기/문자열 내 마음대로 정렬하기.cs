public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[] {};
        
        for (int i = 0; i < strings.Length; i++)
        {
            for (int j = i + 1;  j < strings.Length; j++)
            {
                string left = strings[i].Substring(n, 1);
                string right = strings[j].Substring(n, 1);

                if (string.Compare(left, right) > 0)
                {
                    string temp = strings[i];
                    strings[i] = strings[j];
                    strings[j] = temp;
                }
                else if (string.Compare(left, right) == 0)
                {
                    if (string.Compare(strings[i], strings[j]) > 0)
                    {
                        string temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                    }
                }
            }
        }

        answer = strings;
        
        return answer;
    }
}