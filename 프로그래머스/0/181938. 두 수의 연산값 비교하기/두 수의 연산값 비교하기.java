class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        String sum = Integer.toString(a) + Integer.toString(b);
        
        int multiply = 2 * a * b;
        
        if( Integer.valueOf(sum) > multiply || Integer.valueOf(sum) == multiply) {
        	return Integer.valueOf(sum);
        }else {
        	return multiply;
        }
    }
}