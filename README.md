# (C# 코딩) 심플 계산기

##개요
-C# 프로그래밍 학습
-1줄 소개: 버튼을 누르면 입력을 받아 계산하는 프로그램
-사용한 플랫폼:
 -C#, .NET Windows Forms, Visual Studio, GitHUb
 -사용한 컨트롤:
  -Label, TextBox, Button
-사용한 기술과 구현한 기능:
 -Visual Studio를 이용한 UI 디자인



 ##실행 화면(과제 1)
 -과제1 코드의 실행 스크린샷

<img width="705" height="172" alt="4주차 과제 진짜 1" src="https://github.com/user-attachments/assets/43d585fc-de49-4986-bce6-9d3098ceaa6f" />

<img width="872" height="593" alt="4주차 사진 1(1단계)" src="https://github.com/user-attachments/assets/fb1ca764-2213-43b5-b4a1-817aca5d26f6" />
Label과 TextBox, Button을 적절히 배치해서 Button 클릭시 Text Box1에 나오도록 만들었고 계산된 값이 TextBox2에 나오도록 만들었다. 그리고 button 하나하나 이름을 지어서
숫자와 연산 기능을 하도록 만들었다. private void button13_Click(object sender, EventArgs e) => AppendNumber("1"); 이런식으로 만들어 보았다. 

##실행 화면(과제 2)
 -과제2 코드의 실행 스크린샷
 
<img width="672" height="58" alt="4주차 과제 2(뺼셈)" src="https://github.com/user-attachments/assets/28735bb6-3e50-40a8-8761-c235540d23f4" />
<img width="647" height="68" alt="4주차 과제 2(곱하기)" src="https://github.com/user-attachments/assets/115c0ba4-8dc1-4799-aa61-4ba1492d0a80" />
<img width="673" height="62" alt="4주차 과제 2( 나누기)" src="https://github.com/user-attachments/assets/7d85f293-e525-4c22-829f-48a72579077d" />
뺼셈, 곱셈, 나눗셈을 넣고 과제1처럼 계산이 가능하도록 만들었다. SetOperator(string)메서드를 사용하여 사칙 연산이 가능하도록 만들었다.
처음에 나눗셈자리에 /대신 %를 넣어서 다시 바꿔 주었다. 
<img width="732" height="66" alt="4주차 과제 2(나누기 22)" src="https://github.com/user-attachments/assets/3a9cfb33-4571-448c-9647-bc92eecb9c76" />

##실행 화면(과제 3)
 -과제3 코드이 실행 스크린 샷

 <img width="810" height="636" alt="4주차 과제3( C ,CE, Del)" src="https://github.com/user-attachments/assets/9f8e5b3d-e165-4aea-921c-f55ee139f7cd" />
 C 버튼을 누르면 초기화된 상태, 즉 0 나오도록 만들었다. _firstValue = 0; 로 저장된 첫 번째 값을 초기화 하였고,  _operator = ""; 이것으로 저장된 연산자를 초기화 했다.
 _currentInput = "0"; 이 코드를 사용해 현재 입력 값을 0으로 초기화 되도록했다.  _isNewInput = true;로 새 입력 대기 상태로 만들었다.

 CE버튼을 누르면 마지막에 입력한 숫자값을  삭제하도록 만들었다.  _currentInput = "0"; 이 코드를 사용해 현재 입력한 숫자를 0으로 만들었고,  _isNewInput = true;  C와 같이 새 입력 대기
 상태로 만들었다. 

 Del 버튼을 누르면 입력된 글자하나하나 값을 삭제 하도록 했다.  _currentInput = _currentInput[..^1]; 이 코드를 사용해서 마지막 한 글자를 삭제 할 수 있도록 했다. 

 ##실행 화면 (과제 4)
<img width="786" height="558" alt="4주차 과제 4(키보드)" src="https://github.com/user-attachments/assets/d2adbb54-04f1-423e-9aa3-6bb5354a7457" />
 마우스로 클릭하기에는 불편하다고 생각해서 키보드 가능하도록 만들었다. case Keys.D0 or Keys.NumPad0: AppendNumber("0"); break;를 사용하여 키보드로 입력값을 넣을 수 있도록 만들었다. 

 <img width="692" height="276" alt="4주차 과제4(history)" src="https://github.com/user-attachments/assets/978ca8cc-7891-4fd9-b897-fbdb76956263" />

button(history)를 누르면 지금까지 계산했던 기록을 보여준다._history.Add(expression); 이 코드를 통해서 수식을 저장하도록 만들었다. 
그리고 계산을 하지 않았을때 history를 누르면 "기록이 없습니다"라고 뜨도록 만들었다.
<img width="502" height="410" alt="4주차 과제4(결과)" src="https://github.com/user-attachments/assets/d175f48b-d335-4c33-ac90-a0652580fd35" />

<img width="635" height="818" alt="4주차 과제4( 디자인)" src="https://github.com/user-attachments/assets/3421c433-d20a-49b0-ab80-3bc9a6800c39" />
디자인을 꾸며보았다. 애플의 계산기를 생각해서 만들어 보았다.
<img width="742" height="336" alt="4주차 과제( 마지막 코드)" src="https://github.com/user-attachments/assets/5846a3e7-b13f-42ad-8f36-b110c396bad0" />
소괄호와 중괄호를 추가로 넣어봤고 48 % 2(9+3)을 계한해 보았다. 여기서 생략된 곱셈이 존재한다. 생략된 곱셈은 괄호처럼 먼저 계산을 해야하기 때문에 생략된 곱셈까지 먼저 계산하도록 만들었다. 
만약 여기서 결과 값이 2가 나오지 않는다면 그건 틀린것이다. 생략된 곱셈은 무조건 먼저 처리 해줘야 하며 이걸 무시한 경우 논란이 생기는 것이다.
<img width="641" height="922" alt="4주차 과제 최종 이미지" src="https://github.com/user-attachments/assets/cd7ba738-f94d-4674-ade4-7be5f98bb2a5" />
최종 이미지이다.

느낀점: 내가 항상 사용하는 계산기를 C#을 통해 만들어 보았다. 생각보다 많은 코드가 필요했고 과제 4번에서 내가 생각했던 것을 코드로 구현하고 실현이 되니 내 진로에 한발 더 다가간 느낌이었다.

