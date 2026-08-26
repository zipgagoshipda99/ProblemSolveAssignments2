//LeastCommonMultiple
namespace Main
{
    public class LCM
    {
        //LCM == LeastCommonMultiple
        //최대공약수, 최소공배수 유클리드 호제법을 이용하여 구하는 프로그램
        //자연수 2개 입력 받기
        //입력받은 string을 자연수로 (자료)형변환 

       
        public void LeastCommonMultiple()
        {
            Console.WriteLine("첫번째 숫자 입력 >");
            string input1 = Console.ReadLine();
            Console.WriteLine("두번째 숫자 입력 > ");
            string input2 = Console.ReadLine();
            
            bool[] boolArray = {false, false};
            boolArray[0] = int.TryParse(input1, out int output1);
            boolArray[1] = int.TryParse(input2, out int output2);
            //최소 공배수를 구하기 위해서 처음 입력받은 값들은 따로 A,B에 저장 
            //(output1과 output2는 반복문에서 숫자가 달라질거이므로.)
            
            int A = output1;
            int B = output2;
            int remainder = 1;  
            //형변환 실패하였을때를 대비하기 위한 예외처리
            if(boolArray[0] == false || boolArray[1] == false || boolArray[0] == false && boolArray[1] == false)
            {
                Console.WriteLine("숫자 입력이 잘못되었습니다.");
                return;
            }
            for(int i = 0; remainder != 0; i++)
            {
                //유클리드 호제법을 사용했을때 r = A % B , A % B 나머지가 B % r 나머지와 같다. 
                remainder = A % B;
                A = B; //A 자리에 B가 가고 (왜냐하면 나누는 수(B)가 나눠지는 수고 나머지(remainder)가 나누는 수 이므로) 
                //A를 B라고 저장.
                B = remainder;//A를 나누는 수 B를 나머지(remainder)로 대체.
            }
            Console.WriteLine($"최대공약수: {A}"); //output1는 remainder가 0아니 아니기 전 루프 까지의 나누는 수 이기 때문 (output1 = output2이므로)
            Console.WriteLine($"최소공배수: {output1 * output2 / A}");
            //최소공배수 == (두수의 곱 (ex : a * b) / 최대공약수 )

        }
    }
}