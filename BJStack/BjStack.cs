using System;

namespace BJStack
{
    internal class StackMethod
    {
        public int max;    //스택 용량 : 문제에서는 50
        private int cnt;    //쌓인 스택 개수
        private string[] array; //배열로

        public StackMethod(int max)
        {
            cnt = 0;
            this.max = max;
            array = new string[max];
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

        /*
        public bool Push(int x)
        {
            if (cnt >= max) //스택 가득차면
                return false;
            array[cnt++] = x;
            return true;
        }*/

        public int Push()
        {
            if (cnt >= max) throw new Exception("50개 이상 입력해서 스택 실패!");
            //array[cnt++] = x;
            cnt++;
            return cnt;
        }

        public int Pop()
        {
            if (cnt <= 0) throw new Exception("팝 실패!!");
            string x = array[--cnt];
            return cnt;
        }

        public void Peek()
        {
            if (cnt <= 0) throw new Exception("!!피크 실패!!");
            string x = array[cnt - 1];
            //return x;
        }

        public void Print()
        {
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }

        public bool IsVps()
        {
            int count = 0;
            if (count % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
    }

    internal class StackCSharp_yeon
    {
        private enum Result
        { YES, NO }

        private static void Main(string[] args)
        {
            StackMethod sm = new StackMethod(50);
            string Tstring, input;
            Tstring = Console.ReadLine();
            int T = Int32.Parse(Tstring);
            input = Console.ReadLine();
            if (input == "(")
            {
                sm.Push();
            }
            else if (input == ")")
            {
                sm.Pop();
            }
            if (cnt % 2 == 0)
                Console.WriteLine(Result.YES);
            else
                Console.WriteLine(Result.NO);

            //Console.WriteLine(Result.YES);

            /*
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
            }*/
        }
    }
}