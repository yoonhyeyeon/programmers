using System;

public class Solution {
    public string solution(string my_string) {
        char[] answer = my_string.ToCharArray();

        Array.Reverse(answer);

        string reverse = new string(answer);
        
        return reverse;
    }
}