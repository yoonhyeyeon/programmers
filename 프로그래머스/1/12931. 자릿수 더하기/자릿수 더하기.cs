using System;

public class Solution {
    public int solution(int n) {
        int sum = 0;

        while( n > 0 ){
            sum += n % 10; // 일의 자리 수
            n = n / 10;     
        }

        return sum;
    }
}