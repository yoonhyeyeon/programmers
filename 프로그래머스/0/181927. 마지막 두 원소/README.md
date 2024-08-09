# [level 0] 마지막 두 원소 - 181927 

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/181927?language=java) 

### 성능 요약

메모리: 76.5 MB, 시간: 0.03 ms

### 구분

코딩테스트 연습 > 코딩 기초 트레이닝

### 채점결과

정확성: 100.0<br/>합계: 100.0 / 100.0

### 제출 일자

2024년 08월 09일 13:08:59

### 문제 설명

<p>정수 리스트 <code>num_list</code>가 주어질 때, 마지막 원소가 그전 원소보다 크면 마지막 원소에서 그전 원소를 뺀 값을 마지막 원소가 그전 원소보다 크지 않다면 마지막 원소를 두 배한 값을 추가하여 return하도록 solution 함수를 완성해주세요.</p>

<hr>

<h5>제한사항</h5>

<ul>
<li>2 ≤ <code>num_list</code>의 길이 ≤ 10</li>
<li>1 ≤ <code>num_list</code>의 원소 ≤ 9</li>
</ul>

<hr>

<h5>입출력 예</h5>
<table class="table">
        <thead><tr>
<th>num_list</th>
<th>result</th>
</tr>
</thead>
        <tbody><tr>
<td>[2, 1, 6]</td>
<td>[2, 1, 6, 5]</td>
</tr>
<tr>
<td>[5, 2, 1, 7, 5]</td>
<td>[5, 2, 1, 7, 5, 10]</td>
</tr>
</tbody>
      </table>
<hr>

<h5>입출력 예 설명</h5>

<p>입출력 예 #1</p>

<ul>
<li>마지막 원소인 6이 그전 원소인 1보다 크기 때문에 6 - 1인 5를 추가해 return합니다.</li>
</ul>

<p>입출력 예 #2</p>

<ul>
<li>마지막 원소인 5가 그전 원소인 7보다 크지 않기 때문에 5의 두 배인 10을 추가해 return합니다.</li>
</ul>


> 출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges

## 개념
- 배열에 새로운 요소 추가하는 여러 방법 <br />
1. 배열의 길이를 확장하여 요소 추가하기 <br />
```
// 기존 배열
int[] originalArray = {1, 2, 3};
// 새로운 요소 추가를 위해 길이를 1 늘린 새 배열 생성
int[] newArray = Arrays.copyOf(originalArray, originalArray.length + 1);
// 새로운 요소 추가
newArray[newArray.length - 1] = 4;
System.out.println("새로운 요소 추가 후 배열: " + Arrays.toString(newArray));
```
2. ArrayList를 사용해 요소 추가하기
```
// 기존 배열
Integer[] originalArray = {1, 2, 3};
// ArrayList로 변환
ArrayList<Integer> arrayList = new ArrayList<>(Arrays.asList(originalArray));
// 새로운 요소 추가
arrayList.add(4);
// ArrayList를 다시 배열로 변환
Integer[] newArray = arrayList.toArray(new Integer[0]);
System.out.println("새로운 요소 추가 후 배열: " + Arrays.toString(newArray));
```
3. System.arraycopy() 메서드를 사용해 요소 추가하기
```
// 기존 배열
String[] originalArray = {"apple", "banana", "orange"};
// 새로운 요소 추가를 위해 길이가 1 더 긴 새 배열 생성
String[] newArray = new String[originalArray.length + 1];
// 기존 배열의 모든 요소를 새 배열로 복사
System.arraycopy(originalArray, 0, newArray, 0, originalArray.length);
// 새로운 요소 추가
newArray[newArray.length - 1] = "grape";
System.out.println("새로운 요소 추가 후 배열: " + Arrays.toString(newArray));
```

#### - else if ( num_list[num_list.length - 1] < num_list[num_list.length - 2]) 가 아니라 else 를 써야 하는 이유
<h5>
else if를 사용했을 때 문제가 발생한 이유는 만약 num_list[num_list.length - 1]가 num_list[num_list.length - 2]와 같다면, 어떤 코드도 실행되지 않고, 새 배열의 마지막 요소가 설정되지 않는다. 이는 문제에서 요구하는 조건을 만족하지 않으므로, "실패" 결과가 발생한 것이다.
</h5>

