using System;

public class Solution {
    public int solution(int n) {

        for( int i = 1; i < n; i++){
            if( n % i == 1 ){
                return i;
            }
        }
        
        // 답이 항상 존재함 (이 코드는 절대 실행되지 X)
        return -1;
    }
}