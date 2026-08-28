using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml;

namespace Main
{
    public class NumberBaseball
    {
    // 숫자 야구
    // 컴퓨터가 서로 다른 3개의 숫자로 이루어진 숫자를 하나 선택한다.
    // 사용자는 숫자를 입력하여 정답을 맞혀야 한다.
    // 각 자리의 숫자와 위치가 모두 같으면 Strike, 숫자는 같지만 위치가 다르면 Ball이다.
    // [조건]
    // 0~9 사이의 숫자 3개를 사용하며, 첫 번째 숫자는 0이 될 수 없다.
    // 세 자리 숫자의 각 숫자는 서로 달라야 한다.
    // 정답을 맞힐 때까지 계속 입력받는다.
    // 정답을 맞히면 시도 횟수를 출력한다.
        //0~9 사이의 숫자를 배열로 저장
        int[] intArr =  {0,1,2,3,4,5,6,7,8,9};
        Random random = new Random();
        
        int finalThreeDigit;
        bool Guessing = true;
        public void RandomThreeDigit()
        {
            while (true)
            {
                int oneDigit = random.Next(10); //일의 자릿수
                int twoDigit = random.Next(10);//십의 자릿수
                int threeDigit = random.Next(10);//백의 자릿수
                //예 123 세자리 수를 랜덤으로 뽑아야하기떄문
                if(oneDigit == twoDigit || twoDigit == threeDigit || threeDigit == oneDigit || threeDigit == 0) continue;
                else
                {
                    
                    finalThreeDigit = threeDigit*100 + twoDigit*10 + oneDigit*1;
                    break;
                }
                
            }
        }
        public void PlayerGuess()
        {
            RandomThreeDigit();
            int guessCount = 0;
            Console.WriteLine("서로 다른 숫자로 이루어진 세자리수 숫자를 입력하시오");
            //Console.WriteLine($"{finalThreeDigit}");
            while (Guessing)
            {
                int strikeCount = 0;
                int ballCount = 0;
                string playerNumberGuess = Console.ReadLine();
                int.TryParse(playerNumberGuess, out int output);
                int playerGuessHundreds = output / 100;
                int playerGuessTens = (output /10) % 10;
                int playerGuessOnes = output % 10;
                int hundreds = finalThreeDigit/100;
                int tens = (finalThreeDigit /10) % 10;
                int ones = finalThreeDigit % 10;
                guessCount++;
                if(output == finalThreeDigit)
                {
                    Console.WriteLine($"3 Strike 정답입니다!(총 시도 횟수 : {guessCount})회");
                    Guessing = false;
                    return; 
                }
                if(playerGuessHundreds == hundreds)strikeCount++;
                if(playerGuessTens == tens)strikeCount++;
                if(playerGuessOnes == ones)strikeCount++;
                if (playerGuessHundreds == tens || playerGuessHundreds == ones) ballCount++;
                if (playerGuessTens == hundreds || playerGuessTens == ones) ballCount++;
                if (playerGuessOnes == hundreds || playerGuessOnes == tens) ballCount++;
                Console.WriteLine($"Strike : {strikeCount}, Ball : {ballCount} (총 시도 횟수 : {guessCount})회");
            }
        }
    }
}