using System;

namespace BJStack
{
    internal class StackMethod
    {
        public int max;    //스택 용량 : 문제에서는 50
        public int idx;    //쌓인 스택 개수
        public string[] array; //배열에 굳이 괄호를 넣을 필요가 있을까?..( )

        public StackMethod(int max)
        {
            idx = 0;
            this.max = max;
            array = new string[max];
        }

        public int Size()
        {
            return idx;
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

        public void Push()
        {
            if (idx >= max) throw new Exception("50개 이상 입력해서 스택 실패!");
            array[idx++] = "(";
        }

        public void Pop()
        {
            if (idx <= 0) throw new Exception("팝 실패!!");
            //string x = array[cnt];
            array[idx++] = ")";

        }

        public void Peek()
        {
            if (idx <= 0) throw new Exception("!!피크 실패!!");
            string x = array[idx - 1];
            //return x;
        }

        public void Print()
        {
            for (int i = 0; i < idx; i++)
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
            int braketCnt = 0; //괄호 개수
            //int idx;
            StackMethod sm = new StackMethod(50); //최대 용량을 50으로 셋팅
            string Tstring, input;
            Tstring = Console.ReadLine();
            int T = Int32.Parse(Tstring);
            while ( T >0 ) // && T <= 50
            {
                input = Console.ReadLine();

                if (input == "(")
                {
                   sm.Push();
                    braketCnt++;
                }
                else if (input == ")")
                {
                    sm.Pop();
                    braketCnt--;
                }
                else
                    Console.WriteLine("괄호만 입력하쇼!");
                    input = Console.ReadLine();


                if (braketCnt != 0)
                    Console.WriteLine(Result.NO);
                else //합이 0이면
                    if (sm.array[0] == ")")
                        Console.WriteLine(Result.NO);
                    Console.WriteLine(Result.YES);
                T--;

            }
        }
    }
}