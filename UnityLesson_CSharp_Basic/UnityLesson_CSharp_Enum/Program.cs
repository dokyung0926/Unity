using System;
// enum ( enumerated type ) 열거형
// enum 의 기본요소는 모두 int형 .
enum e_PlayerState
{
    IDLE,       // ...00000000
    ATTACK,  // ...00000001
    JUMP,      // ...00000010
    WALK,     // ...00000011
    RUN,        // ...00000100
    DASH,      // ...00000101
    HOME,      // ...00000110
}
// 비트단위의 열거형을 쓰는 이유 :
// enum은 요소간에 겹치지 않는것이 전제
// 열거형은 필요한데 요소간의 중복이 필요한 경우 비트 단위의 열거형을 씀 .
[Flags] // FlagsAttribute attiribute ( 속성 ) enum 정의 요소 자체에 영향을 끼치지 않음 .
             // 단지 ToString() 속성을 참조할때 중복되는 요소들에 대해 모든 요소 표현 가능 .\
enum e_PlayerStateFlags
{
    IDLE = 0,              // ...00000000
    ATTACK = 1 << 0,  // ...00000001
    JUMP = 1 << 1,      // ...00000010
    WALK = 1 << 2,     // ...00000100
    RUN = 1 << 3,        // ...00001000
    DASH = 1 << 4,      // ...00010000
    HOME = 1 << 5,      // ...00100000
    JUMP_ATTACK = JUMP | ATTACK, // ...00000011
}


namespace UnityLesson_CSharp_Enum
{
    class Program
    {
        static bool doAttack = true;
        static bool doJump;
        static bool doWalk;
        static bool doRun;
        static bool doDash;
        static bool doHome;

        static e_PlayerState createMotion = e_PlayerState.DASH;
        static void Main(string[] args)
        {
            // Switch-case 분기문
            // if처럼 참거짓에 따라 분기하지 않고 
            // 변수의 닶에 따라 분기하는 분기문 .

            /*            switch (switch_on)
                        {
                            case 조건1:
                                break;
                            case 조건2:
                                break;
                            case 조건3:
                                break;
                            default:
                                //  어느경우도 해당되지 않을 경우
                                break;
                        }*/

            // string case 예시
            Console.WriteLine("검색할 캐릭터의 이름을 입력하세요");
            string name = Console.ReadLine();
            switch (name)
            {
                case "가렌":
                    Console.WriteLine($"{name} (은)는 챔피언입니다");
                    break;
                case "헤카림":
                    Console.WriteLine($"{name} (은)는 챔피언입니다");
                    break;
                case "티모":
                    Console.WriteLine($"{name} (은)는 챔피언입니다");
                    break;
                default:
                    Console.WriteLine($"{name} (은)는 플레이어입니다");
                    break;
            }


            // 전사 생성과 특정 모션을 취하는 기능
            Warrior warrior1 = new Warrior();
            Console.WriteLine("생성할 전사의 이름을 입력하세요");
            warrior1.name = Console.ReadLine();
            // if문에 따라 
            if (doAttack)
            {
                warrior1.Attack();
            }
            else if (doJump)
            {
                warrior1.Jump();
            }
            else if (doWalk)
            {
                warrior1.Walk();
            }
            else if (doRun)
            {
                warrior1.Dash();
            }
            else if (doHome)
            {
                warrior1.Home();
            }
            else
            {
                // do nothing
            }

            // switch-case 분기
            switch (createMotion)
            {
                case e_PlayerState.IDLE:
                    // do nothing
                    break;
                case e_PlayerState.ATTACK:
                    warrior1.Attack();
                    break;
                case e_PlayerState.JUMP:
                    warrior1.Jump();
                    break;
                case e_PlayerState.WALK:
                    warrior1.Walk();
                    break;
                case e_PlayerState.RUN:
                    warrior1.Run();
                    break;
                case e_PlayerState.DASH:
                    warrior1.Dash();
                    break;
                case e_PlayerState.HOME:
                    warrior1.Home();
                    break;
                default:
                    break;
            }

            // 동작 명령
            Console.WriteLine("전사에게 명령을 내려주세요");
            string motionInput = Console.ReadLine();
            e_PlayerState motion = (e_PlayerState)Enum.Parse(typeof(e_PlayerState), motionInput);
            
            // 예외처리방법
            object motionObject;
            bool isParsed = Enum.TryParse(typeof(e_PlayerState), motionInput, out motionObject);
            motion = (e_PlayerState)motionObject;

            {
                switch (motion)
                {
                    case e_PlayerState.IDLE:
                        // do nothing
                        break;
                    case e_PlayerState.ATTACK:
                        warrior1.Attack();
                        break;
                    case e_PlayerState.JUMP:
                        warrior1.Jump();
                        break;
                    case e_PlayerState.WALK:
                        warrior1.Walk();
                        break;
                    case e_PlayerState.RUN:
                        warrior1.Run();
                        break;
                    case e_PlayerState.DASH:
                        warrior1.Dash();
                        break;
                    case e_PlayerState.HOME:
                        warrior1.Home();
                        break;
                    default:
                        Console.WriteLine("전사는 그런거 할줄 몰라요");
                        break;
                }
            }
        }
    }

    class Warrior
    {
        public string name;
        public void Attack()
        {
            Console.WriteLine($"{name} (이)가 공격함");
        }
        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프함");
        }
        public void Walk()
        {
            Console.WriteLine($"{name} (이)가 걸음");
        }
        public void Run()
        {
            Console.WriteLine($"{name} (이)가 달림");
        }
        public void Dash()
        {
            Console.WriteLine($"{name} (이)가 돌진함");
        }
        public void Home()
        {
            Console.WriteLine($"{name} (이)가 귀환함");
        }
    }
}
