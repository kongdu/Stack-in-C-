using System;

namespace BJStack
{
    internal class StackMethod
    {
        public int max;    //스택 용량
        private int cnt;    //쌓인 스택 개수
        private int[] array; //스택의 첫 요소에 대한 포인터를 C#으로 어떻게 바꾸지? 일단 배열로

        public StackMethod(int max)
        {
            cnt = 0;
            this.max = max;
            array = new int[max];
        }

        public int Size()
        {
            return cnt;
        }

        /*--- 스택 용량 ---*/

        public int Capacity()
        {
            return max;
        }

        public bool Push(int x)
        {
            if (cnt >= max) //스택 가득차면
                return false;
            array[cnt++] = x;
            return true;
        }

        public int Pop()
        {
            if (cnt <= 0) throw new Exception("팝 실패!!");
            int x = array[--cnt];
            return x;
        }

        public int Peek()
        {
            if (cnt <= 0) throw new Exception("!!피크 실패!!");
            int x = array[cnt - 1];
            return x;
        }

        public void Print()
        {
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }
    }

    internal class StackCSharp_yeon
    {
        private static void Main(string[] args)
        {
            StackMethod sm = new StackMethod(50);

            while (true)
            {
                string input, menu;
                Console.WriteLine("현재 데이터 수: {0}/{1}\n", sm.Size(), sm.Capacity());
                Console.WriteLine("(1)푸시 (2)팝 (3)피크 (4)출력 (0)종료 : ");
                menu = Console.ReadLine();
                int num = Int32.Parse(menu);

                if (num == 0) break;
                switch (num)
                {
                    //푸시
                    case 1:
                        Console.Write("데이터 : ");
                        input = Console.ReadLine();
                        int x = Int32.Parse(input);
                        if (sm.Push(x) == false)
                            Console.WriteLine("오류: 푸시에 실패함");
                        break;
                    //팝
                    case 2:
                        Console.WriteLine("팝 데이터는 {0}입니다\n", sm.Pop());
                        break;
                    //피크
                    case 3:
                        Console.WriteLine("피크 데이터는 {0}입니다\n", sm.Peek());
                        break;
                    //출력
                    case 4:
                        sm.Print();
                        break;
                }
            }
        }
    }
}