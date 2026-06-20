using Hello;

Animal person1 = new Animal("Surafel");
person1.sayhi();

namespace Hello
{
    public class Animal
    {
        public string? name;

        public Animal(string name)
        {
            this.name = name;
        }
        public void sayhi()
        {
            Console.WriteLine($"Hello everyone i'm {name}");
        }
    }
}
