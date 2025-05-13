class Solution {
    public boolean solution(boolean x1, boolean x2, boolean x3, boolean x4) {
        boolean case1 = x1 || x2;
        boolean case2 = x3 || x4;

        return case1 && case2;
    }
}