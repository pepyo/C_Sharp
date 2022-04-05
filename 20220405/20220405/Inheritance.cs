using System;

namespace InheritanceTest
{
    //부모 클래스
    class Animal
    {
        public string name; //이름

        //Animal 클래스 생성자
        public Animal()
        {
            Console.WriteLine($"Animal 생성자");
        }
    }

    //자식 클래스
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine($"Dog 생성자");
        }

        public void printDog(string name)
        {
            base.name = name;
            Console.WriteLine($"Dog의 이름은 {name} 입니다.");
        }
    }

    //자식 클래스
    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine($"Cat 생성자");
        }

        public void printCat(string name)
        {
            base.name = name;
            Console.WriteLine($"Cat의 이름은 {name} 입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.printDog("뽀삐");
            Console.WriteLine("--------------");

            Cat cat = new Cat();
            cat.printCat("여름이");
        }
    }
}