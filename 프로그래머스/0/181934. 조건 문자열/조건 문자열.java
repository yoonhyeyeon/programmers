class Solution {
    public int solution(String ineq, String eq, int n, int m) {
        int answer = 0;
        
        if( ineq.equals(">") && eq.equals("!") && n > m) {
        	return 1;
        }
        if( ineq.equals("<") && eq.equals("!") && n < m ) {
        	return 1;
        }
        if( ineq.equals(">") && eq.equals("=") && n >= m ) {
        	return 1;
        }
        if( ineq.equals("<") && eq.equals("=") && n <= m ) {
        	return 1;
        }
        
        return answer;
    }
}