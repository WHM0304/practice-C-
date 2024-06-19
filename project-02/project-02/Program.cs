namespace project_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            // 자바랑 다르게 String 이 아니라 string 이 소문자 이다
            // foreach(var name in names)
            // {
            //     Console.WriteLine($"{name.ToLower()}");
            // }

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            // foreach(var name in names)
            // {
            //     Console.WriteLine($"{name.ToUpper()}");
            // }


            // 리스트를 배열처럼 인덱스로 참조가능
            // Console.WriteLine($"{names[0]}");
            // Console.WriteLine($"{names[1]}");
            // // 갯수 세는것도 가능
            // Console.WriteLine($"{names.Count}");

            var index = names.IndexOf("Felipe");

            // if(index != -1)
            // {
            //     Console.WriteLine($"{names[index]}의 index는 {index} 에 위치해있다");
            // }

            // 사전순으로 정렬시키는 method()
            names.Sort();
            // foreach(var name in names)
            // {
            //     Console.WriteLine($"{name.ToUpper()}");
            // }

            var finbonacciNumbers = new List<int> { 1, 1 };

            var previous = finbonacciNumbers[finbonacciNumbers.Count - 1];
            var previous2 = finbonacciNumbers[finbonacciNumbers.Count - 2];
            finbonacciNumbers.Add(previous + previous2);


            // foreach(var item in finbonacciNumbers)
            // {
            //     Console.WriteLine(item);
            // }



            // 피보나치 수 20개 만들기

            // for(int i=1; i<18; i++)
            // {
            //     var num1 = finbonacciNumbers[finbonacciNumbers.Count-1];
            //     var num2 = finbonacciNumbers[finbonacciNumbers.Count-2];
            //     finbonacciNumbers.Add(num1 + num2);

            // }
            // foreach(var item in finbonacciNumbers)
            // {
            //     Console.WriteLine(item);
            // }


            // While 문으로 밑에 처럼 똑같이 사용할수있음

            // var fibonacciNumbers = new List<int> {1, 1};

            // while (fibonacciNumbers.Count < 20)
            // {
            //     var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //     var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            //     fibonacciNumbers.Add(previous + previous2);
            // }
            // foreach(var item in fibonacciNumbers)
            // {
            //     Console.WriteLine(item);
            // }


        }
    }
}
