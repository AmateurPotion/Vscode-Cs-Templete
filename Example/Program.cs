using System;

using Exdll;

namespace Example {
    class Program {
        static void Main(string[] args) {

            // 변수
            int exitInfo = 0;
            string inputString;
            string[] codeList = {"1", "1.2"};
            ConsoleKeyInfo consoleKey;

            Console.WriteLine("프로그램 종료 명령어는 exit 입니다.");
            Console.Write("실행할 코드의 번호를 입력해주세요.({0}) : ", string.Join(", ", codeList));
            
            // 입력부
            inputString = Console.ReadLine();

            switch(inputString) {

                case "1":
                Exdll.Program.Main(codeList); // 메소드나 클래스명이 같을 때도 이렇게 직접 경로를 지정해 호출가능. 물론 추천하진 않음
                // 위와 같은 방법으로 메소드를 사용할 경우 솔루션에 해당 dll을 참조로 추가시켜둔 상태에서  using 없이도 사용가능.
                break;

                case "1.2":
                Class1 c1 = new Class1();
                c1.Output();
                break;

                case "exit":
                exitInfo = 1; // 종료 명령어로 프로그램 종료시 대기 없이 바로 종료
                break;

                default:
                Console.WriteLine("실행할 수 있는 코드의 번호를 입력해주세요.");
                Console.WriteLine("프로그램 종료 명령어는 exit 입니다.");
                Main(codeList); // 잘못된 값을 입력했을 경우 재시작
                break;
            }
            
            // 종료 전 대기
            if(exitInfo == 0) {
                Console.WriteLine("프로그램을 종료하려면 아무 키나 눌러주세요.");
                consoleKey = Console.ReadKey();
            }
        }
    }
}
