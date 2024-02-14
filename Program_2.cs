//using ConsoleApp5;
//using Korea.Incheon;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//using In = Korea.Incheon;

/*namespace ConsoleApp5  //파이썬에서는 namespace를 모듈이라고 생각하면 된다. 
{
    namespace Y
    {
        //코드 사용가능
        public class YY
        {
            public void YYY() => Console.WriteLine("YYY");
        }
    }
    namespace X
    {
        //중첩 되어있는 네임스페이스 내부 코드
        public class YY //위의 class YY와 다른 것임.
        {
            public void XXX() => Console.WriteLine("XXX");
        }

    }
    //System, System.Text 등 using으로 불러온 것 들이 네임스페이스임.
    //네임스페이스를 만드는 이유는 프로그램 규모가 커질 때 클래스 이름 중복 등 충돌 방지 목적
    //네임스페이스를 다르게 만들면 동일한 클래스를 하나의 프로젝트에서 사용할 수 있다.
    //서로 관련있는 기능 클래스, 구조체, 열거형 등을 묶는 개념
    //클래스 이름 중복 방지
    //클래스 계층형 구조 형성
    //네임스페이스는 모듈의 의미와 비슷


    //namespace 네임스페이스명으로 네임스페이스 구간 작성
    //클래스와 마찬가지로 첫 글자는 대문자로 작성
    //네임스페이스 구간은 중첩될 수 있음.
*/

/*  //C#에서의 사용자 정의 클래스를 통한 인스턴스 생성시 
  //new 키워드를 사용한다.
  public class Counter
  {
      public void GetCount ()  //GetCount는 static이 지정되지 않은 인스턴스 멤버 형태임.   <-> 클래스 멤버
          //인스턴스 멤버는 인스턴스를 통해 접근 가능을 의미.
      {
          Console.WriteLine("count100");
      }
  }
}
class ObjectNote
{
  static void Main()
  {
      Counter counter = new Counter(); //인스턴스 생성 부분 new키워드 사용
      counter.GetCount(); //인스턴스를 통한 GetCount 메서드 호출
      //Counter.GetCount(); //클래스를 통한 접근 불가 : static이 아님.
  }
}*/


/* public class myMath
 {
     public void sum(int x, int y) {
         int sum = x + y;
         Console.WriteLine(sum);
     }
 }
 class pro
 {
     void Main()
     {
         var mymath = new myMath();  //var 키워드로 식별자 선언 하는 방식 : 익명 형식
         //무명 형식 

         mymath.sum(4, 5);
         int[] x = new int[3];
         //정적 멤버와 인스턴스 멤버
         //클래스 내에 선언되는 모든 멤버는 위 2가지 유형 중 하나이다.
         //정적 멤버이거나 인스턴스 멤버이거나
         //선언시 static키워드를 붙이면 정적멤버
         //static이 없으면 인스턴스 멤버
         //static키워드가 붙은 멤버에 접근시 클래스이름.멤버이름;
         //인스턴스 멤버 접근시 인스턴스명.멤버이름;

         //static이 붙은 변수는 클래스 변수라고 하고
         //static이 붙지 않은 변수는 인스턴스 변수라고 함.
         //static은 공유의 의미


     }
 }*/

/* public class Category
 {
     public void Print(int i) => Console.WriteLine(i);
 }
 class ClassArray
 {
     static void Main()
     {
         Category[] category = new Category[3]; //카테고리라는 클래스로 구성된 배열
         category[0] = new Category(); //카테고리라는 클래스도 데이터타입 중 하나로 취급
         category[1] = new Category(); //해당 배열에는 카테고리클래스의 인스턴스를 넣을 수 있다.
         category[2] = new Category();

         for (int i = 0; i < category.Length; i++)
         {
             category[i].Print(i);
             Console.WriteLine(category[i].ToString());
         }
     }

 }
}   */
/*
namespace A
{ 
    public class Car
    {
        public void Go() => Console.WriteLine("A네임스페이스의 Car의 Go");
    }
}

namespace B
{
    public class Car
    {
        public void Go() => Console.WriteLine("B네임스페이스의 Car의 Go");
    }
}

class NamespaceNote
{
    static void Main()
    {
        A.Car acar= new A.Car();  //네임스페이스 A에 있는 class Car를 통해 만든 인스턴스
        B.Car bcar = new B.Car();  //B네임스페이스의 class Car를 통한 인스턴스 생성
        acar.Go();
        bcar.Go();  //네임스페이스가 적용되어 있는 클래스를 사용할 때 : 네임스페이스명. 클래스 형태로 사용
         
    }
}

*/
/*
namespace Korea
{
    namespace Seoul
    {
        public class Car
        {
            public void Run() => Console.WriteLine("서울 car run");
        }
        
    }

    namespace Incheon
    {
        public class Car
        {
            public void Run() => Console.WriteLine("인천 car run");
        }
    }
}

namespace namespaceDescription
{
    class NamespaceDescription
    {
        static void Main()
        {
            Korea.Seoul.Car s = new Korea.Seoul.Car(); 
            s.Run();
            Korea.Incheon.Car i = new Korea.Incheon.Car();
            i.Run();

            Car Seoul = new Car();  //using Korea.Seoul
            Seoul.Run();
            In.Car ic = new In.Car();  //using In=Korea.Incheon
            ic.Run();
        }
    }
}

*/

//필드 : 클래스의 부품 역할, 클래스의 내부 상태 값 저장 용도의 변수 등
//클래스 내에 선언된 변수 또는 배열 등을 C#에서 필드라고 표현한다.
//필드는 대부분 private 액세스 한정자를 사용한다.
//클래스 내에서 데이터를 담는 역할
//필드는 개체의 상태를 저장한다.

//필드는 선언 후 초기화하지 않아도 자동으로 초기화된다.
//int형 같은 경우는 0으로 초기화, string.Empty(공백)으로 초기화 bool 타입은 false , obj필드 null값으로 초기화 -> " "이렇게 사용하지 않아도 string.Empty를 넣어도 된다.


//지역변수와 전역변수
//C#에서 변수 선언시 Main() 메서드 같은 메서드 내에서 선언하거나 메서드 밖에서 선언이 가능하다.
//메서드 내에서 선언된 변수 또는 배열 등을 지역 변수라고 함.
//메서드 밖에서 선언된 변수 또는 배열 : 전역 변수라고 함.
//C#에서는 전역 변수라는 용어 사용하지 않고 메서드와 동일하게 엑세스 한정자를 붙여 필드라고 함.


//지역변수 : 메서드가 종료되면 변수는 자동 소멸
//전역변수 (필드) : 메서드 내부가 아닌 클래스 내에 선언된 변수
//C#에서 필드는 변수와 마찬가지로 주로 소문자로 식별자 이름 시작

//필드의 종류
//변수 형식의 필드 : 지역 변수와 마찬가지로 값을 대입하여 사용 가능
//상수 형식의 필드 : 필드와 비슷하지만 값을 한 번 초기화 하면 다시 값을 바꿀 수 없음
//읽기전용 필드 : readonly 키워드를 붙이는 읽기 전용 필드도 상수 필드와 비슷한 역할, 상수와 차이점 : 초기화시키지 않아도 됨.
//배열 형식의 필드 : 배열을 필드레벨로 올린 개념, 값을 여러개 저장 가능
//개체 필드 : object 외 여러 개체를 담는 필드

//public static int intNum; 정적인 정수 필드
//public string str : 인스턴스 형식의 문자 필드
//public int num : 인스턴스 정수 필드

//private : 현재 클래스 내 사용O, 외부에서 진입 X 감춤
//public : 현재 클래스 내 사용O, 외부에서 공개
//protected : 현재 클래스 내 사용O, 상속 받은 대상만 접근 가능


//C# 생성자 함수
//C#에서 생성자는 클래승서 맨 먼저 호출되는 메서드로, 클래스 기본값 등을 설정한다.
//개체를 생성하면서 하고자하는 코드를 작성하는 부분(초기화 작업)
//생성자는 생성자 메서드라고도 함.
//생성자 함수의 이름은 클래스의 이름과 동일하게 작성한다.
//생성자는 여러개가 선언될 수 있음.
//생성자를 여러개 만드는 경우 : 생성자마다 매개변수를 다르게 설정하여 여러개 만들 수 있음.
//메서드가 오버로드되는 것 처럼 생성자도 오버로드 됨.
//생성자 함수는 void를 포함한 반환값을 가지지 않는다.
//public 생성자함수명으로 작성




/*
namespace ConstructorParameter
{
    class My
    {
        private object 친구;
        private string _name; //인스턴스 필드
        private int _age; //인스턴스 필드
        private string _description = "ddddddddd";  //인스턴스 필드
        public static string _x = "x"; // 클래스 필드

        public string pname { get; private set; } = "초기값";  //초기값 설정 가능 //set에 private를 주면 읽기전용 프로퍼티
         /*public string pname
        {
            get 
            {
                return _name;  //return을 항상 쓴다.
            }
            set 
            {
                _name = "프로퍼티를 통한 이름 set";  //private field와 외부 인스턴스의 연결성은 프로퍼티 (get과 set을 통해서)
            } 
        }  //인스턴스 프로퍼티 //"public 반환형식 프로퍼티면 {get; set;}"으로 작성 //조회는 get
        //위 pname프로퍼티는 get을 통해 프로퍼티값을 조회할 수 있고
        //set을 통해 프로퍼티값을 할당할 수 있음.
        //프로퍼티도 static이 없기 때문에 인스턴스 마다 분리
        //외부에 공개되는 필드라고 여김
        //set을 세터 get을 게터로 표현해도 됨
        


      
        public My()
        {
            Console.WriteLine("생성자 호출");
        }
        public void PrintMy()
        {
            Console.WriteLine(this._name, this._age);
        }
        public void PrintMy2()
        {
            Console.WriteLine(this._description);
            Console.WriteLine(_x);
        }
    }
    class ConstructorParameter 
    {
        static void Main()
        {
            My myinfo = new My("AAA", 222);
            myinfo.PrintMy();
            My my = new My();
            my.PrintMy2();
            my.pname = "프로퍼티";  //set
            Console.WriteLine(my.pname);  //get
            myinfo.pname = "프로퍼티2";  //set
            Console.WriteLine(myinfo.pname);  //get
            Console.WriteLine(my.pname);  //인스턴트 단위로 구분된다. 

        }


    }

}

*/


/*
public class Dog
{
    private string name;
    public Dog(string name)  //매개변수가 있는 생성자
    {
        this.name = name;
    }   
    public string Cry()
    {
        return name + "cry";
    }
}

class pro
{
    static void Main()
    {
        Dog dog1 = new Dog("1번 강아지");
        dog1.Cry();

        Dog dog2 = new Dog("2번 강아지");
        dog1.Cry();
    }
}
*/

/*
class Car
{
    public Car()
    {
        Console.WriteLine("생성자 함수 호출");
    }
    static void Main()
    {
        var car = new Car();
        Console.WriteLine("1111111111");
    }
}
*/

/*
class Scope
{
    static string globalV = "전역변수"; //전역 변수 혹은 필드라고 표현
    static void Main()
    {
        string localV = " 지역변수";
        Console.WriteLine(localV); //지역변수 출력
        Console.WriteLine(globalV); //전역변수(필드) 출력
        Test();  //같은 클래스 내에 함수는 바로 호출 -> Scope.Test(); 라고 안 작성해도 된다. 
    }
    static void Test() => Console.WriteLine(globalV); //전역 출력 함수
}

*/
/*
class Say
{
    private string message = "안녕하세요";  //private라 감춰져 있어서 .찍어도 나오지 않는다. 다른 클래스에서 
    public string Message2 = "안녕하세요2";
    public void Hi(string a)
    {
     //   string message = "123";   //-=> 지역 변수 지역변수라서 123 123이 실행 얘가 없으면 안녕하세요 , 반갑습니다. 인 필드(전역 변수)가 실행이된다.
        Console.WriteLine(message);
        this.message = a;  //this키워드로 자신 클래스 (say)인스턴스인 개체 내부에 선언된 message필드로 접근
        Console.WriteLine(message);
      
    }
}

class FieldIntializer
{
    static void Main()
    {
        Say say = new Say();
        say.Hi("반갑습니다2");
        say.Message2 = "hello";
    }
}
*/
/*
class Schedule
{
    private string[] weekDays = { "월", "화", "수", "목", "금", "토", "일" };  //배열 필드
    public void PrintWeekDays()
    {
        foreach(string day in weekDays) 
        {
            Console.WriteLine(day);
        }
        Console.WriteLine();
    }
    public static void XX()
    {
        Console.WriteLine("XXXXXXX");
    }
    public void XXX()
    {
        Console.WriteLine("XXXXXXX");
    }
}

class FieldArray
{
    static void Main()
    {
        Schedule schedule = new Schedule();
        schedule.PrintWeekDays();
        schedule.XXX();
        Schedule.XX();
    }
}
*/

//개별적으로 관리할 때는 스태틱
namespace Account
{
    class Account
    {

        //private int sendmoney; //송금 


        DateTime date = DateTime.Today;

        private int money;
        private int accountnumber;
        private string _name;  //예금주
        private string _bank;  //은행명
        private string _date;  // 통장개설




        public void deposit(int dlqrma)
        {

            this.money += dlqrma;

        }

        public void withdraw(int cnfrma)
        {
            money -= cnfrma;
        }


        public int Accountnumber()
        {

            Random random = new Random();
            accountnumber = random.Next(0, 100);
            //Console.WriteLine("{0:D10},1111")
            return accountnumber;
        }



        public Account()
        {
            Console.Write("이름 입력");
            string name = Console.ReadLine();
            this._name = name;
            this.money = 0;
            this._bank = "mybank";
            this._date = $"{date.Year}{date.Month}{date.Day}";
            this.accountnumber = Accountnumber();

            Console.WriteLine($"이름 : {this._name} 은행명 : {this.money} 통장 개설일 : {this._bank} 계좌번호 : {this._date}ss: {this.accountnumber}");

        }


        //public Balancecheck(string name, string mybank, int date, int accountnumber)
        //{
        //    Console.WriteLine($"이름 : {name} 은행명 : {mybank} 통장 개설일 : {date} 계좌번호 : {accountnumber});
        //}




        static void Main()
        {
            Account account = new Account();
            string menu;
            int money = 0;
            string dlqrma;

            Console.WriteLine("1. 잔액조회 2. 입금 3. 출금");
            menu = Console.ReadLine();
            Console.WriteLine();
            if (menu == "1")
            {
                Console.WriteLine(money);
            }
            if (menu == "2")
            {

                dlqrma = Console.ReadLine();
                int b = int.Parse(dlqrma);
                account.deposit(b);
                Console.WriteLine(money);

            }






        }

    }


}

//클래스필드, 인스턴스 필드, 프로퍼티의 get, 프로퍼티의 set, 메서드 ,생성자를 포함하는 클래스 구조 만들기
//계좌 클래스 만들기
//입금 
//출금 -> 잔액 필드를 건들여야함.

//잔액조회 -> 프로퍼티로 만들면 됨.
//계좌번호 (10자리 숫자, 앞에 4자리는 은행코드 1111/ 다음 2자리는 랜덤 숫자/ 다음 4자리는 0001부터 순차증가)
//예금주 -> 필드 (이름)
//은행명 -> 필드 (mybank)
//통장개설일 -> 필드 (data 클래스 활용해서 인스턴스 생성 시점으로 자동 배치 [연/월/일])


//송금(상대방 은행과 계좌번호를 입력해서 송금) -> 인스턴스간의 교류


