using System.Text;

namespace Immutable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person =new Person("salih",21,"male");
            Person person2 = new Person("musabbih", 34, "male");
            Console.WriteLine(person.GetHashCode());
            Console.WriteLine(person2.GetHashCode());
            person2.Name = "Test";
            Console.WriteLine(person2.GetHashCode());//did not change the object code
            Console.WriteLine("checking changigng the state of objects");
            string hello = "hello";
            Console.WriteLine(hello.GetHashCode());
            hello = hello+ "Word";
            Console.WriteLine(hello.GetHashCode());
            hello = hello + "from malizia";
            Console.WriteLine(hello.GetHashCode());// the code is changigng so to prevint it make it immutable using get or read only or Append
            Console.WriteLine("Using string bulder and append to make it immutable dont change the code");
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine(sb.GetHashCode());
            sb.Append("Word");
            Console.WriteLine(sb.GetHashCode());
            sb.Append("frommalizia");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.GetHashCode());//the code of object did not changed
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public Person(string name , int age ,string gender)
        {
            this.Name = name;
            this.age = age;
            this.gender = gender;
        }
        public override bool Equals(object? obj)
        {
            Person? otherPerson = obj as Person;
            if (otherPerson == null) return false;
            return this.Name == otherPerson.Name;
        }
    }
}