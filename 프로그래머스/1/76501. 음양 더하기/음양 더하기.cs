using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {

        int[] num = new int[absolutes.Length];
        int sum = 0;
        
        for(int i = 0; i < absolutes.Length; i++){
            if( signs[i] ){
               sum += num[i] = absolutes[i];
            }else{
               sum += num[i] = -absolutes[i];
            }
        }

        return sum;
        
    }
}