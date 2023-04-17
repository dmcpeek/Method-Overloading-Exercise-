namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine(Methods.Add(2358, 1234));

                Console.WriteLine(Methods.Add(3.1415926m, 2.356789m));

                Console.WriteLine(Methods.Add(1, 1, true));
        }
    }
}
