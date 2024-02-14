using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


/*namespace ConsoleApp3
{
    internal class Program
    {
        public static string GetName()
        {
            return "이름";
        }
        static void Run()
        {
            Console.WriteLine("Program클래스의 Run메서드 호출");
        }
        static void Main(string[] args)
        {
            //C#의 모든 코드에 반드시 들어가는 클래스 구조
            //닷넷의 공용 형식 시스템의 기본 구문
            //클래스는 데이터와 함수를 묶은 구조
            //클래스 속성(데이터) , 메서드(로직)
            //내장 클래스와 사용자 정의 클래스
            //Console, String, Math 등 내장 클래스
            //클래스는 객체(개체)를 생성하는 템플릿
            //public class 클래스이름 {
            // 클래스 내부 코드
            // 클래스 내부 코드
            // 클래스 내부 코드
            // }
            //public 키워드 생략 가능하지만 여러 클래스를 사용할 때는
            //public을 써야한다.
            //public은 공용
            //private는 공개 X
            Run();  //메서드() : 메서드 레벨 호출 : 같은 클래스의 메서드 호출 1 
            Program.Run();  //클래스명.메서드() : 클래스 레벨의 호출 : 특정 클래스의 메서드 호출 2
            //1번 방식이 가능한 이유는 현재 Run메서드가 Main메서드와 같은 클래스에 있기 때문에
            //호출하려는 메서드가 다른 클래스에 있다면 2번 방식을 사용 해야함

            //static과 정적 메서드
            //C#에서는 static을 정적으로 표현
            //정적 선언된 것은 공유될 수 있다를 의미.
            //스태틱이 붙는 클래스의 모든 멤버는 해당 클래스 내에서 누구나 공유해서 접근 가능
            //메서드에 스태틱이 붙는 메서드를 정적 메서드라고 하는데, 공유 메서드라고도 표현
            Console.WriteLine(GetName());


            //C#기본프로그래밍 단위는 클래스로 샛체를 생성해서 사용



        }
    }
    public class myclass
    {
        static void Run()
        {
            Console.WriteLine("myclass Run method");

        }
    }*/



/*class MyFirstClass
{
    static void StaticMethod() => Console.WriteLine("정적 메서드");  // ex) x = 10
    //클래스 공용

    void InstanceMethod() => Console.WriteLine("인스턴스 메서드");  //ex) self x = 10
    //객체가 호출하는 메서드

    static void Main()
    {
        MyFirstClass.StaticMethod();
        // MyFirstClass.InstanceMethod(); 인스턴스를 통해 접근 가능
        MyFirstClass myFirstClass = new MyFirstClass();
        myFirstClass.InstanceMethod();
        //숫자 두개를 입력 받아 연산하는 더하기 빼기 나누기 곱하기 함수를 만들고
        //인스턴스를 통해서만 사용가능하도록 구성
        //Main안에서 자유롭게 사칙연산 함수 호출
        //결과 출력


    }
}*/
/*
class Cal
{
    void p() => Console.WriteLine("더하기 호출");
    void minus() => Console.WriteLine("빼기 호출");
    void d() => Console.WriteLine("나누기 호출");
    void mul() => Console.WriteLine("곱하기 호출");

    static void Main()
    {
        Cal cal = new Cal();
        cal.InstanceMethod();

        cal.p();
        cal.d();

        //static붙은 정적 메서드는 클래스명.메서드()로 호출 : 정적 멤버, 공유 멤버
        //static이 붙지 않은 메서드는 인스턴스.메서드()로 호출 : 인스턴스 멤버

        string One, Two;
        
        Console.Write("첫 번째 숫자를 입력하세요 : ");
        One = Console.ReadLine();
        //Console.WriteLine(One);

        Console.Write("첫 번째 숫자를 입력하세요 : ");
        Two = Console.ReadLine();
        //Console.WriteLine(Two);

    }

}*/
/*
public class MyClass
{
    public static void MyMethod()
    {
        Console.WriteLine("클래스 메서드");
    }

    //현재 이 클래스에는 public키워드가 붙어있음
    //이 클래스 내부 MyMethod도 public이 붙어있음
    //클래스를 public으로 설정했기에 외부에서 접근 가능(public = 공용)
    //public을 액세스(접근)한정자라고 함
    //대부분 클래스와 메서드를 public을 작성하는 것을 기본으로 함
    //public을 작성하지 않으면 internal로 작동

}

class ClassDescription
{
    static void Main()
    {
        MyClass.MyMethod(); //클래스명.메서드()
    }
}
*/

public class ClassName 
{
    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출");
    }
}

public class ClassAndMember    // 청록색으로 나오는 것은 클래스명
{
    public static void Main(string[] args)
    {

        /* ClassName.MemberName();
         Console.WriteLine(Environment.Version);  //닷넷 버전
         Console.WriteLine(Environment.OSVersion);  //운영체제 버전
         Console.WriteLine(Environment.UserName);  //사용자 이름
         Console.WriteLine(Environment.CurrentDirectory);  //현재 폴더
         Console.WriteLine(Environment.MachineName);  //PC명
         //Environment.Exit(0);  //닷넷 프레임워크에 내장된 클래스로 Exit 메서드를 통해 프로그램 강제 종료 
         //시스템 환경 변수들

         Console.WriteLine("-----------------------------------------------");

         //Process.Start("Notepad.exe");  //프로세스 관련 클래스
         //Process.Start("Explorer.exe", "https://naver.com");
         //exe 파일 실행 Start함수

         //Random
         //난수 생성
         Random random = new Random();
         Console.WriteLine(random.Next());  //임의의 정수를 얻음
         Console.WriteLine(random.Next(5));  //0~4
         Console.WriteLine(random.Next(1,10)); //1~9 임의의 수
         Console.WriteLine(random.NextDouble()); //실수 반환
         Console.WriteLine(random.Next(1,46));*/

        //Main()함수 내 작성
        //int[] arr = new int[6];
        //중복 제외 처리 for문 통해서 처리
        //중복이 나오면 for의 인덱스를 무효 처리(중복제거)


        //특정 6개의 중복없는 당첨 번호를 임의로 지정해놓고
        //Random클래스를 활용, 랜덤으로 뽑은 숫자 6개와 동일한지 검사하는 코드 작성
        //Random으로 뽑은 숫자 6개는 중복되지 않아야 함.
        //Random으로 뽑은 숫자는 배열에 담아서 관리함.

        /* Random random = new Random();

         int[] arr = new int[6];
         int i, ran = 0;

         ran = 0;
         while (ran < 6)
         {
             int r = random.Next(0, 100);
             for(i = 0; i < ran; i++) 
                 if (arr[i] == r) break;
                 if (ran == i) arr[ran++] = r;

         }
         Array.Sort(arr);
         for (i = 0; i<6; i++)
             Console.Write(arr[i]);
         Console.WriteLine();


         }*/

        /*

        Console.WriteLine("6개 랜덤 숫자 중복 제거 생성");
        Random random = new Random();  //random 클래스를 이용한 random 객체 생성
        int[] arr = new int[6];  // 6개의 숫자를 담을 6칸의 빈 정수 배열 선언
        int temp = 0;  // 임시 값을 담을 temp변수 선언
        int count = 0;
        for (int i = 0; i < 6; i++)
        { // 6개의 난수를 배열에 넣는 것을 목적으로 6바퀴 for문 구성
            count++;
            temp = random.Next(1, 46);  //random 객체의 Next함수로 1~45중 하나의 숫자 랜덤 생성
            bool flag = false;  //중복 여부를 판단하기 위한 bool타입의 flag변수 생성
            if (i > 0 && i < 6)  //위 for문이 1~6사이 정상 범위일 때만 진입하는 조건
            {
                for (int j = 0; j <= i; j++)
                {  //2중 for문 j를 0부터 i까지 반복
                    if (arr[j] == temp)  //임시로 뽑은 난수가 정수배열 arr의 j인덱스에 있는지 반복 검사
                    {
                        flag = true;  //이미 있는 중복 숫자인 경우 flag를 true로 전환
                    }
                }
            }
            if (flag)  //만약 flag가 true로 전환된 중복 상황이라면
            {
                --i;  //최상단 for문의 인덱스를 1단계 롤백
            }
            else  //중복이 아니라면 i번째 인덱스 자리에 temp를 배치
            {
                arr[i] = temp;
            }
        }
            for(int i=0; i<6; i++)  //6개를 다 채워넣은 배열 arr를 숫자 반복 출력
            {
                Console.Write("{0} ", arr[i]);  //문자열 포메팅 {0}을 사용하여 출력
            }
            Console.WriteLine(count);  //줄바꿈
        }*/



        //액세스한정자 public외 다른 종류
        //private
        //internal(디폴트)
        //sealed


        //String : 가장 많이 사용하는 문자열 처리 관련 속성 메서드 제공 클래스
        //StringBuilder : 대용량 문자열 처리 관련 속성 및 메서드
        //Array : 배열관련 주요 메서드 및 속성


        /*
                //합계
                //개수
                //평균
                //최대 최소

                //내가 푼 것
                int[] numbers = { -2, -5, -3, -7, -1};  //최대값 알고리즘
                int r = 0;

                for (int i = 0; i<numbers.Length-1; i++)
                {

                    if (numbers[i] > numbers[i+1])
                    {
                        r = numbers[i];
                    }
                    else
                    {
                        r = numbers[i + 1];
                    }

                }
                Console.WriteLine($"최대 {r}" );

                // 강사님이 푼 것
                int max = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
                Console.WriteLine(max);


                //순위 : 배열 80 70 50 30 90 //두 개의 배열로 2중 포문

                //내가 푼 것 
                int[] scores = { 90, 87, 100, 95, 80 };
                int[] ranking = Enumerable.Repeat(1, 5).ToArray();

                for (int i = 0; i < scores.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < scores.Length; j++)
                    {
                        if(scores[i] < scores[j])
                        {
                            count++;
                        }

                    }

                    Console.WriteLine($"scores {scores[i]},{count+1}");
                }
                Console.WriteLine(ranking);
                Console.WriteLine(ranking[0]);

                //강사님이 푼 것
                for (int i = 0; i < scores.Length; i++)
                {
                    ranking[i] = 1; //i번째 인덱스의 랭킹을 1등으로 초기화

                    for (int j = 0; j < scores.Length; j++)
                    {
                        if (scores[j] > scores[i]) //첫 바퀴일 때, 90보다 90이 크냐 90보다 87이 크냐... 90보다 80이 크냐
                        {
                            ranking[i]++; //해당 수 만큼 ++
                        }
                    }
                }
                for (int x = 0; x < ranking.Length; x++)
                {
                    Console.WriteLine(ranking[x]);
                }
        */

        //정렬 오름차순 내림차순 : 선택 정렬 : 데이터 하나 기준으로 나머지 데이터와 비교하여 자리를 바꾸는 행위를 반복, Temp 임시 변수 사용

        /* //내가 푼 것
         int[] num = {1, 3, 5, 7, 4, 2, 6};
         int Temp = 0;
         for (int i = 0; i<num.Length; i++)
         {
             for (int j = i+1; j < num.Length; j++)
             {
                 if (num[i] > num[j])
                 {
                     Temp = num[i];
                     num[i] = num[j];
                     num[j] = Temp;

                 }

             }
             Console.WriteLine(num[i]);
         }


         //강사님이 푼 것 
         int[] data = { 3, 2, 1, 5, 4 };
         int N = data.Length;
         for (int x = 0; x<N-1; x++)  //마지막 자리 제외 반복
         {
             for(int y = x+1; y < N; y++) //x로 지목된 요소 뒤 요소부터 반복
             {
                 if (data[y] < data[x])  //부호를 < or >로 바꾸면 내림 or 오름으로 변경 됨
                 {
                     int temp = data[x];
                     data[x] = data[y];
                     data[y] = temp;   
                 }

             }

         }

         for (int x = 0; x < N; x++)   //출력
         {
             Console.WriteLine(data[x]); 
         }
        */


        //검색 : 이진 검색 / 순차 검색 : 정렬이 되어 있다는 가정하에 가능  //int[] x = {10,20,30,40,50,60,70,80,90}
        //-> while 반복 찾으면 탈출 //작으면 endindex변경 //크면 startindex변경
        
                int[] x = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
                int N = 20;
                int Startidx = x[0];
                int Endidx = x[x.Length-1];
                int index = 0;
                
                
                while(true)
                {
                    int Avg = (Startidx + Endidx) / 2;
                    if(N>Avg) 
                    { 
                        index = Array.IndexOf(x, Avg);
                        Startidx = x[index];
                    Console.WriteLine($"'start'{Startidx}");
                    

                    }   
                    else if ( N < Avg )
                    {
                        index = Array.IndexOf(x, Avg);
                        Endidx = x[index];
                    Console.WriteLine($"'end'{Endidx}");
                    
                    }
                    else if (N == Avg)
                    {
                        index = Array.IndexOf(x, Avg);
                        Console.WriteLine($"'avg'{index}");
                    break;
                    }
                }

                

/*
        int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int n = data.Length;
        int search = 7;
        bool flag = false;
        int index = -1;
        int count = 0;

        int low = 0;
        int high = n - 1;
        while(low<=high) {
            count++;
        
            int mid = (low + high) / 2;
            if (data[mid] == search)
            {
                flag = true;
                index = mid;
                break;
            }
            if (data[mid] > search)
            {
                high = mid - 1;

            }
            else
            {
                low = mid + 1;
            }
        }

        if (flag) 
        {
            Console.WriteLine(" ");
            Console.WriteLine($"{search}, {index}, {count}");

        }
        else
        {
            Console.WriteLine("없음");
        }
        */

        //병합
        //최빈값



    }
}


