namespace Hello_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username");
            String userName = Console.ReadLine();
            Console.WriteLine(userName);
            Console.Write("Enter num1 :");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter num2 :");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("결과값 = "+ (num1+num2));
        }
    }
}
