# [level 1] x만큼 간격이 있는 n개의 숫자 - 12954 

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/12954) 

### 성능 요약

메모리: 31.3 MB, 시간: 0.26 ms

### 구분

코딩테스트 연습 > 연습문제

### 채점결과

정확성: 100.0<br/>합계: 100.0 / 100.0

### 제출 일자

2025년 05월 14일 14:19:00

### 문제 설명

<p>함수 solution은 정수 x와 자연수 n을 입력 받아, x부터 시작해 x씩 증가하는 숫자를 n개 지니는 리스트를 리턴해야 합니다. 다음 제한 조건을 보고, 조건을 만족하는 함수, solution을 완성해주세요.</p>

<h4>제한 조건</h4>

<ul>
<li>x는 -10000000 이상, 10000000 이하인 정수입니다.</li>
<li>n은 1000 이하인 자연수입니다.</li>
</ul>

<h4>입출력 예</h4>
<table class="table">
        <thead><tr>
<th>x</th>
<th>n</th>
<th>answer</th>
</tr>
</thead>
        <tbody><tr>
<td>2</td>
<td>5</td>
<td>[2,4,6,8,10]</td>
</tr>
<tr>
<td>4</td>
<td>3</td>
<td>[4,8,12]</td>
</tr>
<tr>
<td>-4</td>
<td>2</td>
<td>[-4, -8]</td>
</tr>
</tbody>
      </table>

## 개념
- answer[i] = (long)(x * (i + 1));   ->  음수 일 때 처리 X

⚠️ 캐스팅 위치가 중요한 이유
(long)(x * (i + 1))  <br />
-> (x * (i + 1)) 가 int 범위를 초과하면 오버플로우 후  long 으로 변환되므로 틀린 값이 나올 수 있음. <br />
(long)x * (i + 1) <br />
- 먼저 x가 long 으로 변환되므로 전체 계산이 long 범위에서 안전하게 수행된다. <br />
---
✅ 오버플로우(Overflow)란?
값이 변수의 자료형이 저장할 수 있는 최대값을 초과할 때 발생하는 현상이다. <br />

🧠 오버플로우가 발생하면?
- 에러 없이 잘못된 값이 저장됨
- 디버깅 어려움
- 프로그램 버그의 원인이 됨

✅ 해결 방법: 더 큰 자료형 사용
int 대신 long을 사용하면 범위가 넓어져서 오버플로우를 방지할 수 있다. <br />

> 출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges
