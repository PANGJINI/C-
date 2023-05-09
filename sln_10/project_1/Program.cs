using System;

namespace project_1
{
    class Program
    {


        static void Main(string[] args)
        {
            //메인 함수 안에는 클래스를 만들 수 없다😝
            Book book = new Book();
            book.Title = "졸려와요졸려우ㅏ요졸려졸려졸려졸려";
            book.Writer = "황진";
            book.Publisher = "(주)유한";

            Console.WriteLine("제  목 : " + book.Title);
            //Console.WriteLine("제목 : {0}", book.Title);
            //Console.WriteLine($"제목 : {book.Title}");
            Console.WriteLine("작  가 : " + book.Writer);
            Console.WriteLine("출판사 : " + book.Publisher);
            Console.WriteLine();



            Product product = new Product();
            product.name = "아메리카노 마시고싶다";
            product.price = 2500;
            Console.WriteLine($"{product.name} : {product.price}");
            Console.WriteLine();

            //인스턴스 생성과 동시에 초기화
            Product productA = new Product() { name = "싱글레귤러", price = 3200 };
            Product productB = new Product() { name = "싱  글  킹", price = 4000 };
            Product productC = new Product() { name = "파  인  트", price = 8900 };
            Product productD = new Product() { name = "쿼      터", price = 17000 };

            Console.WriteLine($"{productA.name} : {productA.price}원");
            Console.WriteLine($"{productB.name} : {productB.price}원");
            Console.WriteLine($"{productC.name} : {productC.price}원");
            Console.WriteLine($"{productD.name} : {productD.price}원");
            Console.WriteLine();



            MyMath mymath = new MyMath();
            //Console.WriteLine(mymath.PI);
            //-->에러
            Console.WriteLine(MyMath.PI);
            //클래스명으로 바로 PI에 접근할 수 있다.
            /* ⭐⭐시험⭐⭐ 클래스 변수
             * 클래스 변수를 만들 때는 static 키워드를 사용한다.
               클래스 이름으로 곧바로 사용하는 변수와 메소드를 클래스 변수/클래스 메서드라고 한다.
             * static --> 미리 메모리공간에 올라가있는 변수(전역변수)
                          메모리 공간이 할당이 되어있는 것.
                          다른 클래스에서 참조할 때도 다시 메모리 공간을 생성해줄 필요가 없다
            */



            Car car = new Car();
            car.Hi(); car.Go();



        }
    }
}
