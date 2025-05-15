using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int n) {
        StringBuilder answerBuilder = new StringBuilder();

        foreach(char c in my_string){
            for(int i = 0; i < n; i++){
                answerBuilder.Append(c);
            }
        }
        
        return answerBuilder.ToString();
    }
}