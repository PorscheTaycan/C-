using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    //delegate 대리자
    //대리자는 매개변수 목록 및 반환 형식이 있는 메서드 참조를
    //나타내는 형식이다.
    //함수 기능을 대신 호출하는 개념으로 사용한다.

    //대리자는 delegate키워드를 사용해서 만들 수 있다.
    //대리자는 함수 자체를 하나의 데이터로 보고 다른 메서드를 실행하는 기능이다.
    //한 번에 메서드 하나 이상을 대신해서 호출할 수 있다.

    //메서드의 매개변수로 대리자 변수(개체)를 넘길 수 있다.
    //대리자를 사용하여 함수의 매개변수로 함수 자체를 전달할 수 있다.
    //대리자는 동일한 메서드 시그니처를 갖는 메서드 참조를 담는 그릇 역할
    //대리자를 사용하면 함수를 모아 놓았다가 나중에 실행하거나 실행을 취소할 수 있다.
    //대리자는 앞에 배울 이벤트를 만들어 내는 중간 단계의 작업이다.

    //public class Print {
    //public static void Show(string message) { Console.WriteLine(message);}
    //}


    //이벤트
    //이벤트는 특정 상황이 발생할 때 객체 또는 클래스에서 알림을 제공할 수 있도록 하는 멤버로,
    //버튼 클릭, 마우스 오버 등 같은 이벤트 기반 프로그래밍에 사용되는 개념
    //콘솔앱은 마우스클릭 X 
    //데스트톱앱 윈도우앱에서 자주 사용한다.
    //event 키워드를 사용한다. 

    //사건 사고 등 의미 : 프로그래밍에서는 함수 실행 되는 결과를 의미
    //이벤트 : 클릭과 마우스오버 같은 동작 자체
    //이벤트처리기 : 특정 이벤트를 담당하기 위해 만든 메서드


    //이벤트와 대리자를 사용해서 메서드 등록 및 호출하기
    //대리자는 이벤트를 위한 중단 단계이다.
    //이벤트는 메서드 여러 개를 등록한 후 실행시키는 역할
    //이벤트는 OS가 가장 먼저 반응한다.
    //운영체제 레벨에서 마우스 및 키보드 등 장치와 연동할 때 이벤트를 사용한다.



    //클래스 - 부분 클래스 partial class 분할 클래스
    //클래스의 기능이 많아 클래스 규모가 커지면 클래스를 나눌 수 있음.
    //분할클래스 방식으로 역할 분담 가능
    //컴파일시 하나의 클래스로 처리
    //분할클래스들을 클래스명




    //클래스의 상속
    //클래스 간 부모 자식 관계를 설정해서 상속 가능
    //상속은 부모클래스에 정의된 기능을 사용하거나 확장 / 수정하여 자식 클래스를 만드는 것
    //public class A
    //{
    //  A클래스의 코드
    //
    //}

    //public class B : A
    //{
    //   A를 상속받은 B클래스의 코드
    //}



    //System.object 클래스는 닷넷 모든 클래스의 부모 클래스이다.
    //새롭게 만드는 모든 클래스는 System.Object클래스를 상속받아 만드는 것


    //기본 base클래스 : 부모클래스를 의미
    //파생 derived클래스 : 다른 클래스의 자식 클래스가 되는 클래스를 파생 클래스라고 함. 혹은 sub클래스라고 함.

    //부모클래스와 자식클래스 
    // 콜론 : 기호로 상속 관계를 지정하면 부모 클래스의 public 멤버들을 자식 클래스에서 그대로 물려받아 사용 가능
    // protected 도 사용 가능

    //this 키워드
    //클래스 내에서 this는 자신을 의미하고, this() : 자신의 생성자를 나타냄
    //base 키워드
    //base는 자신의 부모클래스를 의미
    //base() : 부모클래스의 생성자

    //상속관련 코드
    namespace ConstructorParameter
    {
        public class ParentClass : Object
        {
            public ParentClass(string Message) => Console.WriteLine(Message);
            protected void Print1() => Console.WriteLine("부모클래스의 함수");
        }

        public class ChildClass : ParentClass
        {
            public ChildClass(string Message):base(Message) { }  //생성자 함수 함수 이름과 동일하면 생성자 함수임
            //:base() 부모의 생성자 
            public void Print2() => base.Print1();

        }
        class Demo
        {
            static void Main()
            {

                string msg = "매개변수";
                var child = new ChildClass(msg);    
                //ParentClass p = new ParentClass("생성자 매개변수 텍스트");
                //Console.WriteLine(p.ToString());  

                //ChildClass c = new ChildClass();
                //c.Print2();
                // ParentClass.Print1(); Protected로 되어 있는 멤버는 외부 클래스에서 접근 불가
            }
        }

    }
    /*        class Parent:Object // Object는 안 써도 기본값 최상단에 있는 값임.
    {
        public void AA() => Console.WriteLine("parent_AA");
        public override string ToString()  //부모클래스의 함수 덮어쓰기 할 때 override를 사용한다. 
        {
            return "부모클래스";
        }
    }
    class Child:Parent
    {
        public void BB() => Console.WriteLine("Child_BB");
        public override string ToString()
        {
            return "자식클래스tostring";
        }
    }
    class Demo
    {
        static void Main()
        {

            var child = new Child();
            Console.WriteLine(child.ToString());
            child.AA();
            child.BB();

        }

    }

}*/



    //분할 클래스 작성 방법임
    /*namespace ConstructorParameter
    {

        public partial class Person
        {
            public string Name { get; set; } //프로퍼티 생성
            public int age {  get; set; }   //나이 프로퍼티 생성
        }
        public partial class Person 
        {
            public void Print() => Console.WriteLine($"{Name}:{age}");  
        }

        class PartialCalss
        {
            static void Main()
            {
                Person person = new Person(); //Person 인스턴스 만들어주고
                person.Name = "학생1";
                person.age = 10; ;
                person.Print();  //메서드 사용
            }
        }
        //class PartialCalssDemo  //public 안 써도 됨.
        //{ 
        //    static void Main()  //public 안 써도 됨.
        //    {
        //        var hello = new Hello();  //인스턴스 하나 만들어도 합쳐져서 사용할 수 있음. 
        //        hello.Hi();
        //        hello.Bye();  //인스턴스 생성 후 두 개로 나뉜 partial 클래스 내부 멤버에 접근 가능
        //        //부분 클래스(분할 클래스)를 사용하여 CS파일 하나 또는 하나 이상에서 이름이 동일한 클래스 개발 가능
        //    }
        //}

    }*/
    /* class PattialClassDemo
     {



         public class ButtonClass 
         {

             public delegate void EventHandler();  // 이벤트핸들러라는 대리자 생성
             public event EventHandler Click; //클릭이라는 이름의 이벤트 생성, event키워드와 대리자 형식을 함께 사용   //click이라는 이벤트가 생긴거임

             public void Onclick()  //Click이벤트에 등록된 메서드가 있다면 이벤트가 호출되는 함수   //Onclick이라는 함수 
             {
                 if(Click != null)  //이벤트에 함수가 등록되어있는지 검사
                 {
                     Click();
                 }
             }
         }

         class ConstructorParameter
         {
             static void Main()
             {
                 ButtonClass btn = new ButtonClass(); //위 buttonclass의 인스턴스 생성 //btn 인스턴스
                 btn.Click += Hi1;  //btn인스턴스의 click이벤트에 함수 등록
                 btn.Click += Hi2;
                 btn.Onclick();//btn 인스턴스의 Onclick함수 호출


             }
             static void Hi1() => Console.WriteLine("hi1호출");
             static void Hi2() => Console.WriteLine("hi2호출");
         }

         //public delegate void Runner();

         //public delegate void PrintDelegate(string message);
         //public delegate void SumDelegate(int a, int b);
         //public delegate void Lambda();
         //public delegate int Lambda2(int i);

         //static void Main()
         //{
         //    RunnerCall(new Runner(Go));
         //    RunnerCall(new Runner(Back));



         //    
         //    Print.Show("매개변수텍스트");
         //    PrintDelegate pd = new PrintDelegate(Print.Show);
         //    pd("pd매개변수 텍스트");

         //    PrintDelegate am = delegate (string messeage)
         //    {
         //        Console.WriteLine(messeage);
         //    };
         //    am("am익명함수 매개변수텍스트");

         //    SumDelegate sd = delegate (int a, int b) { Console.WriteLine(a + b); };
         //    sd(4, 5);
         //    Lambda hi = () => Console.WriteLine("Lamdba람다 호출");  //람다 형식으로 함수 선언
         //    hi();
         //    Lambda2 square = x => x * x;  //매개변수와 반환값이 있는 람다식
         //    Console.WriteLine(square(5));

         //}

         //public class CarDriver
         //{

         //    public static void GoForward() => Console.WriteLine("앞");
         //    public static void GoBackward() => Console.WriteLine("뒤");
         //    public static void GoLeft() => Console.WriteLine("좌");
         //    public static void GoRight() => Console.WriteLine("우");




         //}

         //public class Insa
         //{

         //    public void Bye() => Console.WriteLine("잘가");

         //}
         //public delegate void GoHome();

         //class ConstructorParameter
         //{
         //    delegate void Say();
         //    private static void Hello() { Console.WriteLine("Hello"); }
         //    private static void Hi() { Console.WriteLine("Hi"); }


         //    static void Main()
         //    {

         //        CarDriver.GoForward();
         //        CarDriver.GoBackward();
         //        CarDriver.GoLeft();
         //        CarDriver.GoRight();
         //        GoHome go = new GoHome(CarDriver.GoLeft);
         //        go += new GoHome(CarDriver.GoRight);
         //        go += new GoHome(CarDriver.GoRight);
         //        go += new GoHome(CarDriver.GoRight);
         //        go += new GoHome(CarDriver.GoRight);
         //        go -= new GoHome(CarDriver.GoRight);
         //        go();

         //        Say say;
         //        say = new Say(Hi);
         //        say += new Say(Hello);
         //        say();

         //        //Insa 클래스 불러오는 방법
         //        Insa insa = new Insa();
         //        Say say2 = new Say(insa.Bye);
         //        say2 += new Say(insa.Bye);
         //        say2();



         //         SayDelegate say = delegate ()  //익명 메서드 혹은 무명 메서드 방식으로 delegate 지정
         //        {
         //            Console.WriteLine("delegate");
         //        };
         //        say(); //호출



         //        SayPointer saypointer = new SayPointer(Hello);
         //        //saypointer라는 식별자를 가진 SayPointer인스턴스를 만들고 생성자 대신
         //        //실행할 메서드 이름을 지정하는 방식으로 대리자 객체 생성
         //        saypointer(); //대리자 변수에 괄호를 붙여 호출 - 호출 방식1
         //        saypointer.Invoke();  // 대리자에 invoke 함수를 통한 호출 - 호출 방식2 : 명시적 호출



         //        SayDelegate say = Hi;  //함수를 데이터로 보고 say라는 식별자의 대리자 개체에 hi지정
         //        say(); //hi라는 함수의 호출을 대리자 say를 통해 호출 가능, 대리자를 통한 함수 호출
         //        //위 코드처럼 이미 있는 함수(hi)를 대신 호출하는 개념이 대리자의 목적이다.
         //        //대리자 변수 = new 대리자(메서드 이름);
         //        //대리자 변수 += new 대리자(메서드 이름); 형태로 사용 가능
         //    }

         //    }

         //    // delegate void SayDelegate();



         //    // delegate void SayPointer();  //delegate 키워드를 사용해서 void SayPointer()로 매개변수
         //    //및 반환 값이 없는 메서드를 대신 호출하는 대리자를 생성한 코드.

         //    // static void Hello() => Console.WriteLine("dele");
         //    //대리자에 담아 대신 호출할 hello 메서드 선언



         //    // static void Hi() => Console.WriteLine("안녕하세요.");  //함수 Hi생성
         //    // delegate void SayDelegate();  //대리자 생성




         //}
         //static void RunnerCall(Runner runner) => runner();  //대리자를 매개변수로 전달
         //static void Go() => Console.WriteLine("앞");
         //static void Back() => Console.WriteLine("뒤");

     }*/
}
