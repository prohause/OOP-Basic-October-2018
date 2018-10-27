using Farm.Models;

namespace Farm
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var myDog = new Dog();
            myDog.Eat();
            myDog.Bark();
        }
    }
}