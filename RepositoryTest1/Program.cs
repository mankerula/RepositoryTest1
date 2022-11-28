namespace RepositoryTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Foo();

        }

        private static void Foo()
        {
            Console.WriteLine("Det här är en funktion som finns i en annan branch än main");
        }
    }
}