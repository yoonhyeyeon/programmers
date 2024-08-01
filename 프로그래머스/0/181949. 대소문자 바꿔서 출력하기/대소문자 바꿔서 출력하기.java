import java.util.Scanner;

public class Solution {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String a = sc.next();
        char s;
        
        for( int i = 0; i < a.length(); i++ ) {
        	s = a.charAt(i);
        	
        	if( Character.isUpperCase(s) == true ) {
        		System.out.print(Character.toLowerCase(s));
        	}else {
        		System.out.print(Character.toUpperCase(s));
        	}
        	
        }
    }
}