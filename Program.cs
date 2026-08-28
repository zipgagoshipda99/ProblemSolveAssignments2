using Main;

Console.WriteLine("Hello, World!");
LCM lcm = new LCM();
NumberBaseball numberBaseball = new NumberBaseball();

Console.WriteLine("과제 뭐 볼지 선택 \n Q : 유클리드 호제법을 이용한 최대공약수 & 최소공배수 구하기 \n E : 숫자 야구");
ConsoleKey consoleKey = Console.ReadKey().Key;
Console.WriteLine("\n");
switch (consoleKey)
{
    case ConsoleKey.Q:
        lcm.LeastCommonMultiple();
        break;
    case ConsoleKey.E:
        numberBaseball.PlayerGuess();
        break;
}