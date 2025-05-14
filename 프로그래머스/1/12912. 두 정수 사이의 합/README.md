# [level 1] 두 정수 사이의 합 - 12912 

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/12912) 

### 성능 요약

메모리: 31.5 MB, 시간: 16.14 ms

### 구분

코딩테스트 연습 > 연습문제

### 채점결과

정확성: 100.0<br/>합계: 100.0 / 100.0

### 제출 일자

2025년 05월 14일 16:20:53

### 문제 설명

<p>두 정수 a, b가 주어졌을 때 a와 b 사이에 속한 모든 정수의 합을 리턴하는 함수, solution을 완성하세요. <br>
예를 들어 a = 3, b = 5인 경우, 3 + 4 + 5 = 12이므로 12를 리턴합니다.</p>

<h5>제한 조건</h5>

<ul>
<li>a와 b가 같은 경우는 둘 중 아무 수나 리턴하세요.</li>
<li>a와 b는 -10,000,000 이상 10,000,000 이하인 정수입니다.</li>
<li>a와 b의 대소관계는 정해져있지 않습니다.</li>
</ul>

<h5>입출력 예</h5>
<table class="table">
        <thead><tr>
<th>a</th>
<th>b</th>
<th>return</th>
</tr>
</thead>
        <tbody><tr>
<td>3</td>
<td>5</td>
<td>12</td>
</tr>
<tr>
<td>3</td>
<td>3</td>
<td>3</td>
</tr>
<tr>
<td>5</td>
<td>3</td>
<td>12</td>
</tr>
</tbody>
      </table>
---

## 📃 개념
```
public class Solution {
    public long solution(int a, int b) {
        long answer = 0;

        if( a < b ){
            for( int i = a+1; i <= b; i++){
                answer = a += i;
            }
        }else if( a > b ){
            for( int i = b+1; i <= a; i++){
                answer = b += i;
            }
        }else{
            answer = a;
        }
        
        return answer;
    }
}
```
-> 처음에 이렇게 했으나 음수에선 오류 생김 <br />
<hr>
❌ 코드의 문제점 <br>
- answer = a += i; <br />
-> 이 부분은 i를 a 에 누적하고, 그 값을 다시 answer에 넣는 구조 <br>
- a 값이 계속 바뀌면서 a 값이 손실 되고, 누적 계산이 꼬일 수 있음 <br>
- a 나 b 를 변경하지말고, 별도로 answer에만 누적해야 한다. <br>

---
✅ Math.Min(a, b) <br>
a와 b 중에서 작은 값을 반환. <br>
예: Math.Min(3, 5) → 3
<hr> 
✅ Math.Max(a, b) <br>
a와 b 중에서 큰 값을 반환. <br> 
예: Math.Max(3, 5) → 5 <br>

<hr>

> 출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges
