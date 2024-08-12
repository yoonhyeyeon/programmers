import java.util.ArrayList;

public class Solution {
    public int[] solution(int l, int r) {
    	ArrayList<Integer> arr = new ArrayList<Integer>();
    	
    	for( int i = l; i <= r; i++) {
    		if( String.valueOf(i).matches("[05]+") ) {
    			arr.add(i);
    		}
    	}
    	if( arr.isEmpty()) {
    		return new int[] {-1};
    	}
    	
    	int[] a = new int[arr.size()];
    	for( int j = 0; j < arr.size(); j++) {
    		a[j] = arr.get(j);
    	}
    	
    	return a;
    }
}