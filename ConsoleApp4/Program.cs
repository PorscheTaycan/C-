using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console; //네이스페이스 선언부
using static System.Math;  //import와 비슷

namespace HelloWorld //네임스페이스지정
{
    class Program //클래스명 지정
    {
        enum Level
        {
            High,
            Noraml,
            Low

        }
        enum Align
        {
            Top,  // 0
            Bottom, // 1
            Left = 4,  // 2인데 지정된 4
            Right  //3인데 위에 지정된 4 때문에 5로 나옴
        }

        /*
          struct Point  //구조체 이름 선언
          {
              public int x; //구조체 내부에 선언된 변수
              public int y;

          }

          struct Profile
          {
              public string Name;
              public int Age;
          }

          struct Student
          {
              public string Name;
              public int Korean;
              public int English;
              public int Math;

          }





          //함수 오버로드
          //전역 변수 파트
          static void GetNum(int number)  // Main안에 같이 넣으면 작동이 안 되는데 밖에 선언하면 작동이 잘 된다.
          {
              Console.WriteLine(number);
          }
          static void GetNum(long number)
          {
              Console.WriteLine(number);
          }





          static int myabs(int x)
          {
              return ((x > 0) ? x : -x);

          }


          static  int intFunc(int x)
          {
              int result = x * 100;
              return x;
          }

           static string GetString()
          {
              return "반환값";
              //void랑 같이 사용을 못해서 string으로 바꿔줌.
          }

          static void ShowMessage(string message)

          {
              Console.WriteLine(message);
              //void와 return 을 같이 사용하면 안 된다.
          }


          static void myfunc() //매개변수, 반환X
          {
              Console.WriteLine("함수실행");
          }

          */
        static void Main() //함수 선언
        {
            /*
           
            WriteLine("hello world! "); //실행문
            //소스코드의 컴파일
            //c# 파일은 program.cs처럼 확장자가 cs임
            //컴파일 과정을 거치면 실행가능한 exe파일이 생성
            //윈도우가 아닌 환경이면 dll을 생성
            //c#컴파일 방식(빌드)
            //1. 소스코드작성 2. 빌드 3. 프로그램 실행
            //네임스페이스.클래스.메서드()
            //main()메서드의 의미:
            //c# 기본 구조에서 반드시 사용되는 main()메서드는
            //프로그램의 시작점을 의미
            //반드시 main()메서드가 있어야 함
            //main()메서드에서 프로그램을 시작하고 종료한다.
            //main() 메서드가 2개면 프로그램 진입점이 2개라는 의미
            //따라서 오류 발생
            //main 대소문자 구분
            //system도 대문자로 시작
            //실행 단축키 : 컨트롤 + f5

            Console.WriteLine("줄\n 바꿈"); // 자동 줄 바꿈
            Console.Write("바꿈 x");  // 줄 바꿈 x
            Console.Write("바꿈 x");
            // 이스케이프 코드 or 이스케이스 시퀀스
            //\n \t \' \''

            //문자 포맷팅
            Console.WriteLine("{0}", "hello");
            Console.WriteLine("{0}, {1}", "hello", "hello2");
            //변수

            //c#에서 자주 사용하는 데이터 형식
            //int : 정수형 데이터 타입
            //long : 큰 정수형 데이터
            //string : 문자열
            //bool : 불 타입
            //double : 실수형 데이터
            //object : c#에서 사용하는 모든 데이터 형식을 담을 수 있다.

            //식별자 규칙
            //첫 글자는 문자, 숫자 x, 길이는 255이하, 공백 포함 불가, 키워드 사용 불가, 대소문자 구분
            int number;   //int number = 0; 이렇게 작성해도 됨
            number = 0;
            Console.WriteLine(number);

            //리터럴 사용
            //변수에는 직접 정수형 또는 문자열 값 저장 가능
            //리터럴이란 : 값 자체를 의미
            //널 리터럴 : null 리터럴 : 값을 가지지 않는 리터럴

            Console.WriteLine(1234);  //정수 리터럴
            Console.WriteLine(3.14f); //실수 리터럴
            Console.WriteLine('a');   //문자 리터럴
            Console.WriteLine("helloooooo");  //문자열 리터럴


            int num2 = 100;
            Console.WriteLine(num2);

            //형식이 같은 변수 여러개 동시 선언
            //데이터 형식 변수 1, 변수 2, 변수 3


            int num_1, num_2, num_3;
            num_1 = 100;
            num_2 = 200;
            num_3 = 300;
            Console.WriteLine("{0}{1}{2}", num_1, num_2, num_3);

            int num_4, num_5, num_6;
            num_4 = num_5 = num_6 = 100;
            Console.WriteLine("{4}{5}{6}", num_4, num_5, num_6);

            //mynum : 파스칼 표시
            //mynum : 캐멀
            //my_num : 스네이크
            // 변수 <-> 상수
            //변수 : 변할 수 있는
            //상수 : 고정 값
            //constant : const 키워드 사용
            const int max = 200;
            Console.WriteLine(max);
            //a = 300; //a는 정수형 상수로 선언되어 있어서 값을 바꿀 수 없음.



            //숫자
            //정수 _ 실수
            //부호가 있는 정수 _ 부호가 없는 정수
            //부호가 있는 : signed : + - 부호가 있는 정수형 -> 음수 양수 표현 가능
            //부호가 없는 : unsigned : 부호없이 +만 다루는 정수형 데이터 타입

            //int 형식 = system.int32와 같다
            //변수 선언시 int 대신 system.int32로 선언 가능
            //using system을 해놓은 상태라면, system생략하고 int32로 선언 가능
            //닷넷 형식 : system32.int32
            //데이터 형식 : int

            //부호 있는 정수 ( +, - )
            // 1.sbyte : system.sbyte
            // 2. short : system.int16
            // 3. int : system.int32
            // 4. long : system.int64

            //부호가 없는 정수 ( + ) 부호가 있는 것의 두 배의 범위를 가진다.
            //1. byte : system.byte
            //2. ushort : system.ulnt16
            //3. uint : system.ulnt32
            //4. ulong : system.ulnt64
           

            int min = -2147483648;
            int max1 = +2147483647;
            Console.WriteLine(min);
            Console.WriteLine(max);

            Console.WriteLine("32비트 int취소 : {0}", int.MinValue);
            Console.WriteLine("64비트 long최대 : {0}", long.MaxValue);
            Console.WriteLine("64비트 ulong최대 : {0}", ulong.MaxValue);

            float f = 3.14f;
            double d = 3.14d;
            decimal m = 3.14m;
            Console.WriteLine("{0},{1},{2}", f, d, m);

            string msg = "helloooooo";
            Console.WriteLine($"{msg}");

            //문자데이터 형식 char
            //숫자 외에 데이터 형식 (bool, char, string 등)
            //c#에서는 문자와 문자열을 구분
            //문자는 char로 데이터 타입 정의
            //문자는 2바이트 공간에 문자 하나를 저장한다.
            //문자는 데이터 선언에 작은 따옴표 사용
            //char c='c'; 형태
            char c = 'c';
            Console.WriteLine(c);
            //2바이트는 16비트 저장 공간을 의미
            //char 키워드로 선언되는 변수는 당일 유니코드 문자 저장
            //영문 및 한글 등 모든 언어 문자 표현 가능
            //단일 캐릭터 char 데이터타입에는 문자 여러개 저장 불가
            //닷넷 형식으로는 system.char로 표현한다.
            System.Char cc = 'a';
            Console.WriteLine(cc);
            char kor = '가';
            char grade = 'a';
            Console.WriteLine(kor);
            Console.WriteLine(grade);
            //char 타입 변수에 문자를 하나 이상 지정할 경우
            //문자리터럴에 문자가 너무 많다는 오류 발생.



            //문자열 데이터 형식 string
            //문자열은 반드시 ""로 묶음
            //닷넷 형식으로는 system.string
            string name = "iot";
            System.String name2 = "iot";
            Console.WriteLine(name2);
            Console.WriteLine(name);
            //문자열 보간법
            Console.WriteLine($"{name2}");
            //string.format() 함수 사용
            string msg1 = string.Format("{0}, {1}", "아", "어");
            string msg2 = "string";
            Console.WriteLine("message : {0}", msg2);
            Console.WriteLine("message : " + msg2);  //더하기 연산
            Console.WriteLine($"message : {msg2}");  //보간법


            //bool
            //true false

            bool bln = true;
            bool bln2 = false;

            Console.WriteLine(bln);
            Console.WriteLine(bln2);

            char ccc = 'a';
            Console.WriteLine(ccc);

            Console.ReadLine(); //입력 대기 input과 동일
            Console.WriteLine(Console.ReadLine());
            //print(input())


            Console.Write("이름을 입력하세요 ");
            string namex = Console.ReadLine();
            Console.WriteLine("{0}을 입력함.", namex);


            //Console.read() 메서드를 사용하면 콘솔에서
            //문자를 하나만 입력받을 수 있다.
            //입력값은 문자에 해당하는 정수로 반환된다.
            //convert.tochar() 메서드를 사용해서 변환
            int aaa = Console.Read();//a
            Console.WriteLine(aaa);//65
            Console.WriteLine(Convert.ToChar(aaa));//a


            //형식 변환
            //Console.readline() 메서드를 통해 콘솔에서 입력받은
            //데이터는 문자열
            //readline()으로 입력받은 문자열을 형 변환

            //1. 명시적 형변환 ex) Console.writeline(convert.tochar(aaa));
            //2. 암시적 형변환 ex) 64 = int32 int32쓰면 64로 들어감

            //암시적 형 변환은 변환 형식이 안전하게 유지되고 데이터가
            //손실되지 않는다.

            int x1 = 123;
            long x2 = x1;
            //암시적 형변환 예


            //long이 int보다 비트수가 많아서
            long x3 = 123;
            int x4 = (int)x3; ;
            //명시적 형변환 예
            //형변환: 캐스팅
            //이 경우에서 (int)하지 않으면 데이터 손실 발생, 오류


            //convert 클래스의 주요 매서드
            //1.tostring() : 숫자 데이터 형식을 문자열로
            //2.toint32() : 정수 형식으로
            //3.todouble() : 실수 형식으로
            //4.tochar() : 문자 형식으로
            //ex) convert.tostring()


            //int.parse() 형변환
            string strnum = "1234";
            int y = int.Parse(strnum);
            Console.WriteLine(y);

            //gettype() 메서드
            int i = 1234;
            string ii = "안녕";
            char iii = 'c';
            double iiii = 3.14;
            Console.WriteLine(i.GetType());
            Console.WriteLine(ii.GetType());
            Console.WriteLine(iii.GetType());
            Console.WriteLine(iiii.GetType());

            //파이썬 type()메서드 비슷하게 활용
            //데이터 타입 확인 메서드

            //이진수 다루기
            Console.WriteLine(Convert.ToString(10, 2));
            //10진수 10을 2진수로 변환
            //이진수 표현 1010
            Console.WriteLine(Convert.ToString(10, 2).PadLeft(8, '0'));
            //8칸 기준으로 이진수 문자열 출력, 앞부분 0으로 채움


            //바이트 선언
            byte b1 = 0b0010;
            Console.WriteLine(b1);  //십진수 2 출력
            //소스코드에서는 기본적으로 십진수 단위로 자료가 처리된다.


            int bin = 0b0001_0001;  //4자리씩 _
            Console.WriteLine(bin);  //17
            int dec = 1_000_000; // 3자리씩 _
            Console.WriteLine(dec);
            int nex = 0xa0_b0_c0;  // 두자리씩 _
            Console.WriteLine(nex);

            //var 키워드로 암시적 형식의 변수 생성
            var num100 = 100;
            Console.WriteLine(num100);
            var strrrr = "안녕하세요";
            Console.WriteLine(strrrr);
            Console.WriteLine(strrrr);
            Console.WriteLine(num100.GetType());
            //system.int32
           
           

            //ReadKey() 메서드
            //키보드에서 입력한 키를 알아내는 메서드
            Console.WriteLine("키보드압력");
            ConsoleKeyInfo cki = Console.ReadKey(true);
            Console.WriteLine(cki.Key);
            Console.WriteLine(cki.KeyChar);
            Console.WriteLine(cki.Modifiers);
            if (cki.Key == ConsoleKey.Q)
            {
                Console.WriteLine("Q를 눌렀다.");
            }

           

            //변수의 기본값을 default 키워드로 설정
            //변수를 선언 및 초기화할 때, 해당 변수의 데이터 형식으로
            //초기화를 한다.
            //초기화할 때 default 키워드로 초기화 가능

            int xxx = default;
            bool bd = default;


            Console.WriteLine(xxx);  //0
            Console.WriteLine(bd);   //False

            // 연산자
            // + - * /
            // 대입 산술 관계 비교 논리 증감 비교 시프트
            // 1개의 항을 연산하는 단항 연산자
            // 2개의 항을 연산하는 이항 연산자
            // 3개의 항을 연산하는 삼한 연산자


            //연산자와 피연산자
            int num1 = 1000;
            int number_11 = num1 + 1233;  //이항 연산자이자 num1, 1233는 피연산자

            //단항연산자 +
            int num_22 = -8;
            num2 = +num2; //8로 바뀜

            //(int) 변환 연산자

           
            //할당 연산자
            // = : 대입 할당
            // += : a+= 10 : a= a+10
            // -=
            // *=
            // /=
            // %=


            //증감연산자
            // ++
            // --
            int m_2 = 10;
            Console.WriteLine(m++);  // 10 -> 이렇게 쓰는 경우가 더 많음
            //m++;
            Console.WriteLine(++m);  //12
            //m--;
            Console.WriteLine(m);  //12
            Console.ReadLine();

            //선 연산 후 대입 (전위연산자) ++a 11
            //선 대입 후 연산 (후위연산자) a++ 10
            //전위 증감 연산 ++a 11
            //후위 증감 연산 a++ 10

           

            //관계 연산자 : 비교 연산자
            // < > <= >= == !=
            //논리 연산자
            // and or not
            // && || !
            //양쪽이 true일때 true : and
            //양쪽 중 하나가 true이면 true : or
            //반대로 뒤집기 : not
            Console.WriteLine(true && true);
            Console.WriteLine(!true);

            var k_22 = 3;
            var j = 5;
            var r = false;
            r = (i == 3) && (j != 3);
            Console.WriteLine(r);
            r = (i != 3) || (j == 3);
            Console.WriteLine(r);

            //조건 연산자
            //조건연산자는 조건에 따라 참일 때와 거짓일 때 결과를
            //다르게 반환한다.
            // ?: 형태로 사용
            Console.WriteLine((5 > 3) ? "TRUE" : "FALSE"); //?를 기준으로 왼쪽은 식 :를 기준으로 왼쪽은 T일 때 나올 식 오른쪽은 F일 때 나올 식

            //sizeof()
            //sizeof(int)  -> 결과값 4

            //if
            //if(조건식)
            //{
            //    실행문


            //}

            //if elif else
            //if else if else

           

            int aaa_33 = 100;
            if (aaa > 100)
            {
                Console.WriteLine(aaa);
            }
            else if (aaa == 100)
            {
                Console.WriteLine(aaa);
            }
            else
            {
                Console.WriteLine(aaa);
            }

           

            //사용자에게 문자를 입력받아서
            //해당 문자에 대한 ascii 상 해당 문자의 숫자가
            //100보다 큰 문자라면 100보다 크다 라고 출력
            //그렇지 않으면 입력 문자에 해당하는 숫자와 문자 출력
            //var 키워드 사용 금지


            int x = Console.Read();
            if (x > 100)
            {
                Console.WriteLine("100보다 크다.");
            }
            else
            {
                Console.WriteLine("{0}, {1}  ", x, Convert.ToChar(x));
            }

            //Console.WriteLine(x);

           

            //switch 문
            //조건문

            //switch(식)
            //{
            //   case 값1:
            //       실행문1:
            //       break;
            //   case 값1:
            //       실행문2:
            //       break;
            //   case 값1:
            //       실행문3:
            //       break;
            //}
            int user1 = Console.Read();
            switch (user1)
            {
                case 65:  //A
                    Console.WriteLine("A를 입력한 것");
                    break;
                case 66:  //B
                    Console.WriteLine("B를 입력한 것");
                    break;
                case 67:  //C
                    Console.WriteLine("C를 입력한 것");
                    break;
                default:  //그 외의 알파벳
                    Console.WriteLine("해당 X");
                    break;
            }


            // for문
            //for( int i= 0; i< 10; i++)
            //{
            //   실행문
            //}
            //i가 0부터 i가 10보다 작은 동안 매 바퀴 i가 1씩 증가하면서 돈다.

            for (int k= 0; k < 10; k++)  // for i in range(10):
            {
                Console.WriteLine(k);
            }
            for (int k = 1000; k > 0; k--)
            {
                Console.WriteLine(k);

            }

            //무한루프
            //for(;;)

            //내가 푼 거
            for (int e = 2; e > 0 && e < 10; e++)
            {
                Console.WriteLine("{0}단 ", e, "\n");
                for (int rvf = 1; rvf > 0 && rvf < 10; rvf++)
                {

                    Console.WriteLine("{0}*{1} = {2}", e, rvf, rvf * e);

                }

            }

            //강사님 설명
            for (int fdd = 1; fdd <= 9; fdd++)
            {

                for (int s = 2; s <= 9; s++)
                {
                    Console.Write($"{s}*{f} = {s*f, 2} ");  //뒤에 2는 공백을 의미함 2칸 정도
                   
                }
               
                Console.WriteLine();
            }


            //while문
            //while(조건식)
            //{
            //    실행문;
            //             }

            int count = 0;
            while(count < 3)
            {
                Console.WriteLine("while내부");
                count++;
            }


            //do while 문
            //do
            // {
            //     실행문;
            //             }while(조건식);
            count = 0;
            do
            {
                Console.WriteLine(count);
                count++;
            }while (count != 0);

            //do while 문은 첫 반복은 무조건 실행한다.
            // 조건식인 while이 뒤에 있기 때문에



            //do while 문은 첫 반복은 무조건 실행한다.
            //조건식인 while이 뒤에 있기 때문에

            //foreach -> 파이썬에선 for 문
            // 배열이나 컬렉션같은 요소를 여러개 담은 데이터 구조에
            //각 데이터가 들어있는 만큼 반복
            //파이썬의 for문과 동일
            //foreach(항목 in 항목들)
            //{
            //   실행문
            //          }


            //[1번]
            string[] names = { "C#", "python" };  //문자열을 담는 것인지 숫자를 담는 것인지 정확하게 써줘야 한다. int[]이냐, string[]이냐
            foreach (string name_22 in names)
            {
                Console.WriteLine(name_22);
            }

            //break
            //continue
            //동일


            //배열이란
            //동일한 데이터 형식을 갖는 데이터의 집합체
            //배열을 사용해서 여러 데이터를 모아서 관리 가능


            //컬렉션
            //colloection
            //C#에서 컬렉션은 배열, 리스트, 딕셔너리가 있다.

            //[2번]
            //new 키워드는 객체를 새로 생성할 때 쓰는 키워드
            //배열
            var array = new string[] { "AAA", "BBB", "CCC" }; //string []이구나라는 것을 앎. var array가
            foreach(string name_23 in array)
            {
                Console.WriteLine(name);
            }

            //1번, 2번 표현 동일

            //리스트
            var list = new List<string> { "L1", "L2", "L3"};  //"L1"이라는 문자열이 뽑혀서 string
            foreach(string name_24 in list)
            {
                Console.WriteLine(name);
            }

            //딕셔너리
            var diction = new Dictionary<int, string> { {0, "000" },{1,"111" },{2, "222" } }; // var인 이유가 {0, "000"}이 뽑히게 되는데 이것이 str인지 int인지 모르기때문에 var
            foreach(var _25 in diction)
            {
                Console.WriteLine(name.Key);
                Console.WriteLine(name.Value);
            }

           

            //배열
            //순서가 있는 집합
            //각 요소는 인덱스로 접근
            //인덱스 0부터
            //*배열은 데이터형식이 동일한 요소들을 포함
            //*배열 new키워드로 생성 가능
            //배열에서 값 하나는 요소element 혹은 항복 item으로 표현
            //반복문 foreach와 조합
            //*필요한 요소의 수를 정해서 메모리를 적게 사용 가능


            string str1 = "c#9.0";
            Console.WriteLine(str1[0]);
            Console.WriteLine(str1[1]);
            Console.WriteLine(str1[2]);

            Console.WriteLine("ABC"[0]);

            //배열은 데이터 형식 이름 뒤에 [] 기호를 사용해서 선언
           
            // 배열 선언 후 new연산자(키워드)를 사용하여 배열의 크기
            //만큼 메모리 영역을 잡을 수 있다.
            int[] numarr;
            numarr = new int[3]; //위에 선언한 numarr 변수에 3칸짜리
            //정수 배열을 선언

            int[] arr2 = new int[5];

            //데이터 형식[] 변수명 = new 데이터타입 [칸];

            //1차원 배열
            int[] intnum = new int[10];  //값이 안 들어간 상태
            //배열의 요소 : 첨자 하나를 가지는 배열
            //메모리 상 10개 공간이 잡힌다.
            //0부터 ~ 9까지 연속적으로 메모리 공간 잡힌다.
           
            intnum[0] = 100;

            int idx = 1;
            int[] xxxxx = { 1, 2, 3 };
            Console.WriteLine(xxxxx[idx]);
            Console.WriteLine(xxxxx[--idx]);

           

            //문제 1. 5칸의 정수 배열을 new로 생성하고
            //각 요소에 1~100사이 임의 숫자 할당
            //인덱스를 활용해서 배열에 저장되어 있는 값들의
            //합과 평균을 정수 출력 소수점 2자리까지 출력


            int[] intnum = new int[5];
            intnum[0] = 1;
            intnum[1] = 40;
            intnum[2] = 86;
            intnum[3] = 67;
            intnum[4] = 28;
            int r1 = intnum[0]+ intnum[1] + intnum[2] + intnum[3] + intnum[4];
            int r2 = (intnum[0] + intnum[1] + intnum[2] + intnum[3] + intnum[4]) / 5;


            Console.WriteLine($"{r1:0.00}");
            Console.WriteLine($"{r2:0.00}");





            //문제 2. 5칸 짜리 1차원 정수 배열을 선언하고
            //사용자에게 5번동안 숫자를 입력 받아
            //위 배열에 값을 할당한다.
            //배열에 저장된 값들의 총 합을 출력한다.

            int[] numarr = { 1, 2, 3, 4, 5 };
            int sum2 = 0;
            for (int i2 = 0; i2 < numarr.Length; i2++)
            {
                string inputV = Console.ReadLine();
                if (int.TryParse(inputV, out int num)) {
                    numarr[i2] = num;
                    sum2 += num;
                }
                sum2 += intnum[i2];
            }



            ////소수점 2자리까지 출력예시
            //float mm = 30.0101F;
            //Console.WriteLine(mm);
            //Console.WriteLine($"{mm:0.00}");

            int[] chararr = new int[5];
            for (int b = 0; b < chararr.Length; b++)
            {
                Console.WriteLine("입력하세요 ");
                int inputValue = Console.Read();
                Console.ReadLine();    //Enter 처리를 해준다.
                chararr[b] = (int)inputValue;
            }
            Console.WriteLine("입력값");
            foreach(int c in chararr)
            {
                Console.WriteLine(c);
            }


            //new 키워드 없이 배열 선언 및 초기화
            //다차원 배열
            //차원이 여러개
            //2차원 3차원 ~~~
            //데이터 형식[,] 배열이름; //2차원
            //데이터 형식[,,] 배열이름; //3차원

            //arr[0,0]
            int[] arr1; //1차원
            int[,] arr2; //2차원
            int[,,] arr3; //3차원

            arr1 = new int[2] { 1, 2 };
            arr2 = new int[2, 2] { {1,2 }, {3,4 } };
            arr3 = new int[2, 2, 2] { {{ 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };


            char[,] arrchar = new char[2, 2];
            arrchar[0, 0] = 'A';
            arrchar[0, 1] = 'B';
            arrchar[1, 0] = 'C';
            arrchar[1, 1] = 'D';

            Console.WriteLine($"{arrchar[0, 0]}");  //표 데이터 / 데이터프레임 / 엑셀 / 행+열


            int[] xxx = { 1, 2, 3 }; //값을 굳이 안 주고도 생성되거나 값을 할당 시킬 수 있다.


            //2차원 배열 선언 및 초기화 문제
            //2x3짜리 2차원 배열을 선언하고
            //2차원 배열 내부에 임의의 값을 할당
            //2차원 배열 내부에 배치된 요소 값을 전부 출력하는데
            //행 열 구조의 표처럼 보이도록 출력

            int[,]table = new int[2, 3] { {1,2,3 },{4,5,6 } };  // 2가 행 // 3이 열
           
            for (int i = 0; i< table.GetLength(0); i++)
            {
              for (int j = 0; j< table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] );
                }
                Console.WriteLine("\n");

            }


            //문제 2. string 3차원 배열 2X2X2를 선언하고 2x2x2 -> 앞 2가 층 중간 2가 행 마지막 2가 열
            //3차원 배열에 모든 요소에 값을 할당
            //3차원 3중 for 사용해서 요소 모두 출력

            string[,,] go = new string[2, 2, 2] { {{ "1", "2" }, { "3", "4" } },{ { "5", "6" }, { "7", "8" } } };

            for (int i = 0; i < go.GetLength(0); i++)
            {
                for (int j = 0; j < go.GetLength(1); j++)
                {
                    Console.Write("\n");
                    for (int k = 0; k < go.GetLength(2); k++)
                    Console.Write(go[i, j, k]);
                }
                Console.WriteLine("\n");

            }


            // 문제 3. 2x3x4
            string[,,] go1 = new string[2, 3, 4] { {{ "01", "02", "03", "04" }, { "05", "06", "07", "08" }, { "09", "10", "11", "12" } },
                { {"13", "14", "15", "16" }, {"17", "18", "19", "20" }, {"21", "22", "23", "24" } } };

            for (int i = 0; i < go1.GetLength(0); i++)
            {
                for (int j = 0; j < go1.GetLength(1); j++)
                {
                    Console.Write("\n");
                    for (int k = 0; k < go1.GetLength(2); k++)
                        Console.Write(go1[i, j, k]+ " ");
                }
                Console.WriteLine("\n");

            }


            //가변 배열
            //차원이 2개 이상인 배열은 다차원 배열.
            //배열 길이가 가변 길이인 배열은 가변 배열.
            //데이터형식[][] 배열 이름; 형태로 사용
            //다차원 배열은 데이터형식[,] 배열이름;
            int[][] ints = new int[2][]; // [2][]형태로 두번째를 비워 둠
            //비워 둔 자리에 동적으로 자료 n개 초기화 가능
            ints[0] = new int[] { 1, 2 }; // 0번째 행에 데이터 2개 저장 ints[0] -> int[]를 뜻한다.
            ints[1] = new int[] { 3, 4, 5 };  // 1번째 행에 데이터 3개 저장    ints[1] -> int[]의 옆 []를 뜻한다.

            //위 배열의 요소를 이중 for 사용하여 콘솔에 출력하세요
            for (int i = 0; i < 2; i++)
            {
                 
                for (int j = 0; j < ints[i].Length; j++)
                {
                    Console.WriteLine(ints[i][j]);  
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //함수
            //함수 function 혹은 매서드 method는 재사용을 목적으로 만든
            //특정 작업 수행 코드 블럭마다
            //C#에 진입점을 의미하는 함수는? Main()함수.  특수한 함수
            //내장함수 or 사용자정의함수
            //내장함수는 C#에서 자주 사용하는 기능을 미리 만들어 제공하는 함수
            //내장함수는 특정 클래스의 함수로 표현된다.
            //위 내장함수들을 API로 표현함
            //사용자 정의 함수는 개발자가 만든 함수

            //사용자 정의 함수의 기본 형태
            //static void 함수 이름()
            //{
            //   함수 실행문
            //}


            //함수 호출의 형태
            //1. 함수이름();  : 단순 호출
            //2. 함수이름(매개변수);  : 매개변수 포함한 호출
            //3. 변수 = 함수이름(매개변수);  : 리턴이 있는 호출

           
            myfunc();

            //매개변수(인자)
            //가변 매개변수 (여러개 인자)
            //c#에서는 클래스 하나에 매개변수의 형식과 개수를
            //다르게 하여 이름이 동일한 함수를 여러 개 만들 수 있다.
            //:함수 오버로드  -> 함수의 이름을 myfunc() 이것과 myfunc(a) , myfunc(b) 이렇게 만들어도 된다.
            //반환값(return)



            ShowMessage("인자");
            string rtValue=GetString();
            Console.WriteLine(rtValue);
            int result = intFunc(10);
            Console.WriteLine(result);


            //static void : 반환값 없음
            //static int : 정수형 반환
            //static string :문자열 반환


            //하나의 숫자를 매개변수를 통해 입력받아서
            //해당 숫자의 음수 혹은 양수로 들어와도
            //절대값으로 리턴해주는 함수 생성
            //함수의 이름은 myabs로 생성
            //조건 연산자 ? : 형태
            Console.WriteLine(myabs(-10));

            //매개변수
            //함수 내 선언되는 변수
            //기본 매개변수 default
            //선택적 매개변수 optional
            //명명된 매개변수 named
           
 
            static void xxx(int x = 1)
            {
                Console.WriteLine(x);
            }

            static void mysum(int first, int second)
            {
                Console.WriteLine(first + second);
            }

            mysum(100, 200);
            mysum(first:200, second:500);
            mysum(second:500, first:500);

            GetNum(1234);  //int 매개변수  GetNum함수의 호출
            GetNum(1234L); //long 매개변수 GetNum함수의 호출

            //함수의 범위
            //클래스와 같은 레벨에 선언 된 변수를 전역 변수 혹은 필드라고 함
            //함수 레벨에서 선언된 변수를 지역변수라고 함
            //동일한 이름으로 변수를 전역변수와 함수 내의 지역 변수로 선언가능
            //함수 내에서는 함수 범위에 있는 지역 변수를 사용한다.
            //함수 범위 내에 선언된 변수가 없으면 전역 변수 내에 선언된 변수를 사용한다.
            //C#에서는 전역변수라는 표현 보다는 필드라는 표현을 주로 씀
            //전역변수(필드)에는 언더스코어를 붙여 변수명을 작성하는 경우가 많음 _result 형태
            // 함수 밖에 있는게 전역변수
            // 함수 안에 있는게 지역변수

            int aaa = 300;   //-> 이 aaa와  , 전역변수이자 필드임 C#에서는 필드로 사용
            static void xxx (int x = 1)
            {
                int aaa = 200;  //-> 이 aaa가 다른 것임, 지역변수
                Console.WriteLine(aaa);
            }




            //화살표 함수 : =>
            //화살표 모양의 연산자를 작성하여 메서드 코드를 줄일 수 있음
            //화살표 함수 arrow function
            //람다식과 비슷한 개념
            static void Hi() => Console.WriteLine("안녕하세요");
            static void Multip(int a, int b) => Console.WriteLine(a * b);
            Hi();
            Multip(100, 200);
            // { }를 없애고 , =>로 작성

            //클래스, 구조체, 열거형, 네임스페이스
            //닷넷에서 제공하는 대부분의 API는 클래스 형태
            //클래스 : Console클래스 String클래스 등 대부분 클래스 구조임
            //구조체 : DateTime 구조체, TimeSpan 구조체 형태로 표현, 클래스와 거의 동일하게 사용
            //열거형 : Color 열거형 등, 특정 목록을 관리하기에 편리함
            //네임스페이스 : System 네임스페이스처럼 여러 클래스, 구조체, 열거형을 포함한 단위

            //Math 클래스
            //닷넷에서 제공하는 수학 관련 내장 클래스 Math
            //Math.PI 원주율
            //Math.Abs() 절대
            //Math.Max() 최대
            //Math.Min() 최소
            //Math.Pow() 거듭제곱
            //Math.Floor() 지정된 십진수보다 작거나 같은 최대 정수값 반환   -> 소수점 뒤에 버리기
            //Math.Ceiling() 지정된 십진수보다 크거나 같은 정수값 반환  -> 반올림?
            //Math.Round() 특정 자리에서 반올림
            Console.WriteLine($"3.15를 소수점 둘째자리에서 반올림:{Math.Round(3.15, 1)}");
            //3.15에서 소수점 1자리까지만 표현 -> 둘째자리에서 반올림



            //구조체 struct -> 파이썬에서는 list
            //하나의 이름으로 서로 다른 데이터 형식을 묶어 관리하는 구조체
            //변수 : 이름 하나, 공간 하나
            //배열 : 이름 하나, 데이터 형식 동일 공간 여러개 int[]  xx={1, 2, 3}
            // int, string 등 서로 다른 자료를 현 집단으로 정의 : 구조체
            // C#에서는 구조체를 활장한 클래스 개념을 제공한다.
            //클래스가 더 상위 개념이고 주로 사용하기에
            //구조체는 이미 내장되어 있는 datetime 구조체 등을 불러서 사용할 때 많이 쓴다.
            //따로 만드는 경우는 별로 없음, 대신에 클래스로 만듦.
               
            //구조체의 선언
            //struct 구조체 이름
            //{
            // 데이터 형식 변수1;
            // 데이터 형식 변수2;
            //}


            //구조체 선언신 struct 키워드를 사용
            //구조체 내부 변수에 .으로 접근 가능
            Point point; //구조체 생성   point 라는 변수이다.   Point라는 데이터 타입을 만든 것이다.
            point.x = 100; //Point 구조체 x변수에 100대입
            point.y = 200;
            WriteLine(point.x); // 구조체 내부 변수 출력



            //구조체 : int or string 등 데이터 타입을 만든 것
            //구조체 배열
            //구조체[] 배열이름 = new 구조체[100];
            static void Print(string name, int age) => WriteLine($"이름:{name} 나이:{age}");
            Profile profile;
            profile.Name = "홍길동";
            profile.Age = 20;
            Print(profile.Name,profile.Age);

            Profile[] names = new Profile[2];
            names[0].Name = "1번 이름";
            names[0].Age = 100;
            names[1].Name = "2번 이름";
            names[1].Age = 200;

            for(int i =0; i < names.Length; i++)
            {
                Print(names[i].Name, names[i].Age);
            }



            //학생이라는 구조체를 만들고
            //학생 구조체는 학생의 국어/영어/수학 점수가 있다.
            //학생은 총 5명이고, 5명의 정보를 하나 students라는 배열에 배치한다.
            //모든 학생의 점수 정보는 임의로 코드상 기재한다.

            //printAvg라는 함수를 선언하고
            //printAvg함수는 학생 5명의 정보를 담은 하나의 배열을 매개변수로 받는다.
            //printAvg함수는 반환값 : 문자열 형태이고 평균점수가 가장 높은 학생의 이름을 return
           
            Student[] students = new Student[5];
         
            students[0].Name = "지영";
            students[0].Korean = 40;
            students[0].Math = 80;
            students[0].English = 50;

            students[1].Name = "수영";
            students[1].Korean = 90;
            students[1].Math = 100;
            students[1].English = 95;

            students[2].Name = "다영";
            students[2].Korean = 60;
            students[2].Math = 60;
            students[2].English = 60;

            students[3].Name = "기영";
            students[3].Korean = 90;
            students[3].Math = 40;
            students[3].English = 10;

            students[4].Name = "시영";
            students[4].Korean = 90;
            students[4].Math = 100;
            students[4].English = 50;

            static string PrintAvg(Student[] para)
            {
                float max = 0.0F;
                int idx = 0;
                for (int i = 0; i < para.Length; i++)
                {
                    float avg =  (para[i].Korean + para[i].Math + para[i].English) / 3;
                    if(avg > max)
                    {
                        max = avg;
                        idx = i;
                    }
                }
                return para[idx].Name;
            }

            string resultV = PrintAvg(students);
            WriteLine(resultV);

            //내장형 구조체
            //DateTime : 시간/날짜 대한 정보를 제공
            //TimeSpan : 시간 날짜 계산 정보 제공
            //Char : 문자 관련 정보 제공

            WriteLine(DateTime.Now);
            WriteLine(DateTime.Now.ToString());
            WriteLine(DateTime.Now.Minute.ToString());
            WriteLine(DateTime.Now.Hour.ToString());
            WriteLine(DateTime.Now.Year.ToString());

            //ms 까지 표현 가능
            TimeSpan dday = Convert.ToDateTime("2025-12-12") -  DateTime.Now;
            WriteLine(dday.ToString());

            if (DateTime.TryParse("2024/12/12", out DateTime d))   //out은 2024/12/12의 조건식이 맞으면 out 뒤에 있는 것인 var d 가 출력할 수 있게 된다. , 인라인 out 변수 : 변수가 선언되고 바로 사용할 수 있게 됨.
            {
                Console.WriteLine(d.ToString());
            }
            else
            {

            }


            //DateTime 구조체의 AddHours() 메서드
            //보통의 1년 : 365일 : 8760시간
            //1년을 시간단위로 8760단계로 표현 가능하다.

            static DateTime myGetTime(int num)
            {
                return ( new DateTime(2024,1,22,0,0,0)).AddHours(--num); // 어떤 시간 객체를 만들 때 이렇게 만듦.
            }
            Console.WriteLine(myGetTime(1));
            Console.WriteLine(myGetTime(8760));
*/
            //열거형 enum
            //타입 이름 하나로 서로 관련 있는 항목들을 묶어 관리하는 열거형 타입
            //열거형 타입은 기억하기 어려운 상수들을 이름을 지어 관리 표현 하는 방식
            //열거형 사용하면 값 리스트 여러개를 이름 하나로 관리할 수 있다.
            //열거형은 enum 키워드를 사용한다

            //Consolecolor 열거형
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();

            Level x = Level.High;
            Console.WriteLine(x);


            Console.WriteLine((int)Align.Bottom);
            //datatype -> enum, struduct, int, floot 등..


            Type cc = typeof(ConsoleColor);
            string[] colors = Enum.GetNames(cc);  //GetNames : 지정된 열거형에서 상수 이름 배열 리턴
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }




        }
    }


}