class Solution {
    public int[] solution(int[] num_list) {
    	// 길이가 1 더 긴 새 배열 생성
        int[] answer = new int[num_list.length + 1];
        // 기존 배열의 모든 요소를 새 배열로 복사
//        System.arraycopy(num_list, 0, answer, 0, num_list.length);
        for(int i = 0; i < num_list.length; i++) {
        	answer[i] = num_list[i];
        }
        
    	// 마지막원소 > 그전 원소 = 마지막원소 - 그전 원소
    	if( num_list[num_list.length-1] > num_list[num_list.length - 2] ) {
    		// 새로운 요소 추가
    		answer[num_list.length] = num_list[num_list.length- 1 ] - num_list[num_list.length- 2 ];
    	}else{   // 마지막원소 < 그전 원소 = 2 * 마지막원소
    		answer[num_list.length] = num_list[num_list.length - 1] * 2;
    	}
        
        return answer;
    }
}