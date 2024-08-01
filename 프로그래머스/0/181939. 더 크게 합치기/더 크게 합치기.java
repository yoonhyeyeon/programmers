class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        String sumA = Integer.toString(a)+Integer.toString(b);
        String sumB = Integer.toString(b)+Integer.toString(a); 
        
        if( Integer.valueOf(sumA) >= Integer.valueOf(sumB) ) {
        	answer = Integer.valueOf(sumA);
        }else {
        	answer = Integer.valueOf(sumB);
        }
        
        return answer;
    }
}