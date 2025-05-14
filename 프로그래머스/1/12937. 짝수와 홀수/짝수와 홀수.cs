public class Solution {
    public string solution(int num) {

        string a = "Even";
        string b = "Odd";
        
        if( num % 2 == 0 ){
            return a;
        }else{
            return b;
        }
        
    }
}