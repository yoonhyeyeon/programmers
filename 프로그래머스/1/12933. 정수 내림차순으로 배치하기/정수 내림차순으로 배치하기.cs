using System;

public class Solution {
    public long solution(long n) {
        // 숫자를 문자열로 바꿔서 배열로 만듬
        char[] c = n.ToString().ToCharArray();
    
        // 내림차순 변경
        Array.Sort(c);
        // 거꾸로 (큰 것->작은 것)
        Array.Reverse(c);
    
        // 정렬된 배열을 다시 숫자로
        string s = new string(c);
        return long.Parse(s);
    }
}