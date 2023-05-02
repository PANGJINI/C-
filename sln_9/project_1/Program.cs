using System;

namespace project_1
{
    // 클래스 생성하기
    // class 클래스명 (클래스명은 대문자로 작성하자)
    // 클래스는 틀, 설계도 --> 실제 메모리 공간을 갖지는 않음
    class Book
    {
        // 변수(필드) 선언
        public string Title;
        public string Writer;
        public string Publisher;
        public int Published_Date;
        public string Contents;
    }


    class Product
    {
        public string name;
        public int price;
    }



    class Program
    {
        static void Main(string[] args)
        {
            // ❤❤시험 : 클래스의 위치
            // 메인 함수 안에는 클래스를 만들 수 없다.

            // 클래스를 사용하기 위해서는 객체 생성을 해야 함 (객체 할당 new)
            // Book 클래스로부터 book1 객체 생성
            // book1 객체(인스턴스)가 실제 메모리를 가지게 된다.
            Book book1 = new Book();

            book1.Title = "Candy";
            book1.Writer = "Dream";
            book1.Publisher = "(주)KWANGYA";
            book1.Published_Date = 20221219;
            book1.Contents = "햇살에 일어나보니 너무나 눈부셔";

            Console.WriteLine("제  목 : " + book1.Title);
            //Console.WriteLine("제목 : {0}", book1.Title);
            //Console.WriteLine($"제목 : {book1.Title}");
            Console.WriteLine("저  자 : " + book1.Writer);
            Console.WriteLine("출판사 : " + book1.Publisher);
            Console.WriteLine("출판일 : " + book1.Published_Date);
            Console.WriteLine("내  용 : " + book1.Contents);
            Console.WriteLine();


            Book book2 = new Book();
            book2.Title = "Perfume";
            book2.Writer = "DOJAEJUNG";
            book2.Publisher = "(주)KWANGYA";
            book2.Published_Date = 20230417;
            book2.Contents = "짙은 농도에";

            Console.WriteLine("제  목 : " + book2.Title);
            Console.WriteLine("저  자 : " + book2.Writer);
            Console.WriteLine("출판사 : " + book2.Publisher);
            Console.WriteLine("출판일 : " + book2.Published_Date);
            Console.WriteLine("내  용 : " + book2.Contents);
            Console.WriteLine();


            Product product1 = new Product();
            product1.name = "딸기";
            product1.price = 12000;
            Console.WriteLine(product1.name + " : " + product1.price + "원");
            //Console.WriteLine("{0} : {1}원", product1.name, product1.price);
            //Console.WriteLine($"{product1.name} : {product1.price}원");

            
            // 인스턴스를 생성함과 동시에 멤버변수를 초기화 할 수 있음.
            Product product2 = new Product() { name = "나재민", price = 813 };
            Product product3 = new Product() { name = "이해찬", price = 606 };
            Product product4 = new Product() { name = "김도영", price = 201 };
            Console.WriteLine($"{product2.name} : {product2.price}");
            Console.WriteLine($"{product3.name} : {product3.price}");
            Console.WriteLine($"{product4.name} : {product4.price}");
        }
    }
}
