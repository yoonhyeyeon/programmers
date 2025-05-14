# [level 1] 평균 구하기 - 12944 

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/12944) 

### 성능 요약

메모리: 31.6 MB, 시간: 0.27 ms

### 구분

코딩테스트 연습 > 연습문제

### 채점결과

정확성: 100.0<br/>합계: 100.0 / 100.0

### 제출 일자

2025년 05월 14일 13:44:32

### 문제 설명

<p>정수를 담고 있는 배열 arr의 평균값을 return하는 함수, solution을 완성해보세요.</p>

<h4>제한사항</h4>

<ul>
<li>arr은 길이 1 이상, 100 이하인 배열입니다.</li>
<li>arr의 원소는  -10,000 이상 10,000 이하인 정수입니다.</li>
</ul>

<h4>입출력 예</h4>
<table class="table">
        <thead><tr>
<th>arr</th>
<th style="text-align: center">return</th>
</tr>
</thead>
        <tbody><tr>
<td>[1,2,3,4]</td>
<td style="text-align: center">2.5</td>
</tr>
<tr>
<td>[5,5]</td>
<td style="text-align: center">5</td>
</tr>
</tbody>
      </table>

## 개념
- 마지막에 answer / 2 -> 합계의 절반
- 평균 -> 합계 ÷ 배열 길이
---
- 마지막에 암시적 형변환이 안되는 이유 (왜 명시적 형변환이 필요한가?)
- double answer = sum / length;  -> sum / length는 int / int 연산이 먼저 일어나고, <br />
  그 결과인 정수를 double 로 암식적으로 변환한다. <br />
  ex ) sum / length = 10 / 4 = 2 <- 소수점은 잘림 <br />
       그 다음 , answer = (double)2 = 2.0  <br />
       
✅ 왜 명시적 형변환이 필요한가 ? <br />
- double answer = (double)sum / arr.Length; <br />
->  여기서는  sum이 먼저 double로 변환되므로, <br />
    double / int -> 부동소수점 나눗셈이 일어나고 <br />
    결과는 정확한 평균인 2.5가 된다.

🔄 정리
| 표현식                                     | 결과    | 설명                 |
| --------------------------------------- | ----- | ------------------ |
| `double answer = sum / length;`         | `2.0` | 정수 나눗셈 후 실수 변환     |
| `double answer = (double)sum / length;` | `2.5` | 먼저 실수로 변환 → 정확한 평균 |

> 출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges
