public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];

        for (int i = 0; i < n; i++) {
            answer[i] = (long)x * (i + 1);  // i+1 을 곱해 x부터 x씩 증가
        }
        
        return answer;
    }
}
