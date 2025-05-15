using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;

        for( int i = 0; i < s1.Length; i++ ){
            string currentS1 = s1[i];

            for( int j = 0; j < s2.Length; j++ ){
                string currentS2 = s2[j];

                if( currentS1 == currentS2 ){
                    answer ++;
                }
            }
        }
        
        return answer;
    }
}