namespace project_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 4;
            // if(( a +b+c > 10)|| (a==b))
            // {
            //     Console.WriteLine("The answer is greater than UP");
            //     Console.WriteLine("And the first number is equal to the second");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is greater than down");
            //     Console.WriteLine("Or the first number is not equal to the second");
            // }

            // int counter = 0;
            // // while (counter <10)
            // // {
            // //     Console.WriteLine($"Hello! {counter}");
            // //     counter++;
            // // }

            // do
            // {
            //     Console.WriteLine($"{counter}");
            //     counter++;
            // } while(counter<10);

            // for(int counter =0; counter <10;counter++)
            // {
            //     Console.WriteLine($"{counter}");
            // }

            // for(int row = 1; row <11; row++)
            // {
            //     Console.WriteLine($"The row is {row}");
            // }
            // for(char column = 'a'; column<'k' ; column++)
            // {
            //     Console.WriteLine($"The column is {column}");
            // }



            //  for(int row = 1; row <11; row++)
            // {
            // for(char column = 'a'; column<'k' ; column++)
            // {
            //     Console.WriteLine($"The column is {column}");
            // }
            //     Console.WriteLine($"The row is {row}");
            // }

            // 1~20 까지 정수 중에 3으로 나눌수 있는 정수의 합 구하기
            int sum = 0;
            for (int i = 1; i < 21; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"{sum}");




        }
    }
}
