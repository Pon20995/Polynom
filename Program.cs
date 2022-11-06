
namespace Task_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var polynom1 = new Polynomial(new[] { 5, 1, 0, 4, 0});
            var polynom2 = new Polynomial(new[] { 1, 0, 0, 1, 6 });

            Polynomial result = polynom1 + polynom2;
            Polynomial result1 = polynom1 * polynom2;
            Polynomial result2 = polynom1 - polynom2;

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);


            Console.ReadKey();
        }
    }

    
}
