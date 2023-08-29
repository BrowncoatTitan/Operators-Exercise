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

            int a = 17; int b = 4;
            Console.WriteLine(a + "/" + b + " is " + a / b + " remainder " + a % b); 

            Console.WriteLine("Hello! Please input a number " +
                "to be used as the radius of a circle.");
            double o;
            double.TryParse(Console.ReadLine(), out o);
            string formattedArea = Circle.AreaOfCircle(o).ToString("0.00");
            Console.WriteLine(formattedArea);
        }
    }
}
