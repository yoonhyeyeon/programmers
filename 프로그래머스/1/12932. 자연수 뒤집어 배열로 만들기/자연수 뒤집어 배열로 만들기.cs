using System;

public class Solution {
    public int[] solution(long n) {
        string str = n.ToString();  // 문자열로 변환
        int[] answer = new int[str.Length];

        for(int i = 0; i < str.Length; i++){
            answer[i] = int.Parse(str[str.Length - 1 - i].ToString());
        }
        
        return answer;
    }
}