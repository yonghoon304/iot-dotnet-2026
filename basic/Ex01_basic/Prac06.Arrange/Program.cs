namespace Prac06.Arrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름 > ");
            string name = Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine($"안녕하세요,{name}님"); // string포맷이 훨씬 효율적


            // 형변환
            Console.Write("나이 > ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            Console.WriteLine(age.GetType());

            // 3클래스
            Person p1 = new Person();
            p1.Name = "최용훈";
            p1.Age = 28;
            p1.Walk();
        }
    }
    class Person
    {
        public string Name;
        public int Age;

        public void Walk()
        { 
            Console.WriteLine($"{Name}이가 걷습니다");
        }
    }

    // 4. 인터페이스
    public interface IMovable   
    {
        void Move();    // 메서드 구현이 없음. 정의만
    }
}
