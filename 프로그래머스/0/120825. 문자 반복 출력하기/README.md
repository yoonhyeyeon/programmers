# [level 0] 문자 반복 출력하기 - 120825 

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/120825) 

### 성능 요약

메모리: 31 MB, 시간: 0.24 ms

### 구분

코딩테스트 연습 > 코딩테스트 입문

### 채점결과

정확성: 100.0<br/>합계: 100.0 / 100.0

### 제출 일자

2025년 05월 15일 17:06:51

### 문제 설명

<p>문자열 <code>my_string</code>과 정수 <code>n</code>이 매개변수로 주어질 때, <code>my_string</code>에 들어있는 각 문자를 <code>n</code>만큼 반복한 문자열을 return 하도록 solution 함수를 완성해보세요.</p>

<hr>

<h5>제한사항</h5>

<ul>
<li>2 ≤ <code>my_string</code> 길이 ≤ 5</li>
<li>2 ≤ <code>n</code> ≤ 10</li>
<li>"my_string"은 영어 대소문자로 이루어져 있습니다.</li>
</ul>

<hr>

<h5>입출력 예</h5>
<table class="table">
        <thead><tr>
<th>my_string</th>
<th>n</th>
<th>result</th>
</tr>
</thead>
        <tbody><tr>
<td>"hello"</td>
<td>3</td>
<td>"hhheeellllllooo"</td>
</tr>
</tbody>
      </table>
<hr>

<h5>입출력 예 설명</h5>

<p>입출력 예 #1</p>

<ul>
<li>"hello"의 각 문자를 세 번씩 반복한 "hhheeellllllooo"를 return 합니다.</li>
</ul>

## 📃 개념 <br>
<h4>foreach : 컬렉션 안에 있는 걸 하나씩 꺼내서 반복</h4>
ex) foreach(char c in my_string) <br>
char c : 이번에 꺼낸 요소를 c 라는 이름으로 부를거고, 그 요소는 char 타입이다. <br>
in : 어디 안에 들어있는 걸 꺼낼 거냐 <br>
my_string : 이 my_string 안에 들어있는 요소들을 꺼낼 거야 라고 대상을 지정 <br>

---

😊 언제 foreach 를 쓰면 좋을까? <br>
- 배열이나 리스트에 들어있는 모든 요소를 대상으로 뭔가를 할 때 <br>
- 문자열의 모든 문자를 하나씩 처리할 때 <br>
- 몇 번째 요소인지 순서가 중요하지 않고 그냥 '모든 요소'를 다룰 때 <br>

---

<h4>StringBuilder : 문자열을 만들거나 수정하고, 계속 이어 붙이는 작업을 할 때 쓰는 특별한 클래스</h4>

😊 언제 StringBuilder 를 쓰면 좋을까? <br>
- 반복문 안에서 문자열에 계속해서 뭔가를 추가하거나 수정해야 할 때 <br>
- 만들어야 할 문자열의 길이가 아주 길어질 것 같을 때 <br>
-> 이럴 때 string 의 += 연산자보다 훨씬 빠르고 컴퓨터 메모리도 덜 쓴다. <br>

✔ 쓰는 방법 <br>
1. using System.Text 추가
2. new StringBuilder()로 만들기
3. Append()로 추가하기
4. ToString()으로 최종 문자열 만들기 

<hr>

> 출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges
