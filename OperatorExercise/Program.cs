namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 100; //Exercise 1
            int y = 2;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % ++y);

            Console.WriteLine("Hello! Please input a number " +
                "to be used as the radius of a circle.");
            double o = double.Parse(Console.ReadLine());
            string formattedArea = o.ToString("0.00");
            Console.WriteLine(Circle.AreaOfCircle(o));
        }
    }
}
