using System;
using System.Collections.Generic;
namespace unityLesson_CSharp_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------
            // List
            // -----------------------------
            List<int> _list = new List<int>();
            _list.Add(3);
            _list.Add(2);
            _list.Add(1);
            _list.Add(0);
            _list.Add(3);

            // 0번째 인덱스부터 탐색하고, 첫번째로 인자와 같은 요소를 발견하면 삭제 .
            // 삭제 성공 시 true 반환, 인자와 같은 요소를 못찾으면 false 반환 .
            _list.Remove(3);
            int length = _list.Count;
            for (int i = 0; i < length; i++)
            {
                int tmpNumber = _list[i];
                Console.WriteLine(tmpNumber);
            }

            foreach (int num in _list)
            {
               Console.WriteLine(num);
            }

            // -----------------------------
            // Dictionary
            // -----------------------------
            Dictionary<string, string> _dic = new Dictionary<string, string>();
            _dic.Add("검사", "양손대검을 사용하여 물리공격을 하는 클래스");
            _dic.Add("마법사", "지팡이를 사용하여 마법공격을 하는 클래스");
            _dic.Add("수호자", "창과 방패를 사용하여 물리공격 및 방어 위주의 클래스");

            _dic.Remove("검사");
            bool isSwordMasterExist = _dic.ContainsKey("검사");
            if (isSwordMasterExist)
            {
                string tmpValue = _dic["검사"];
                Console.WriteLine($"검사 : {tmpValue}");
            }
            else
            {
                Console.WriteLine("검사를 찾을 수 없습니다 .");
            }

            foreach (string sub in _dic.Keys)
            {
                string tmpValue = _dic[sub];
                Console.WriteLine($"{sub} : {tmpValue}");
            }

            foreach (string sub in _dic.Values)
            {
                Console.WriteLine(sub);
            }

            foreach (KeyValuePair<string,string> sub in _dic)
            {
                string tmpKey = sub.Key;
                string tmpValue = sub.Value;
                Console.WriteLine($"{tmpKey} : {tmpValue}");
            }

            // ---------------------------------------
            // Queue ( List와 비슷하나, FIFO ( First Input, First Output ) 체계이다. )                                 
            // ---------------------------------------
            Queue<int> _queue = new Queue<int>();

            _queue.Enqueue(10);
            _queue.Enqueue(20);
            _queue.Enqueue(30);

            Console.WriteLine(_queue.Peek()); // 가장 첫번째에 있는 값을 반환 
            Console.WriteLine(_queue.Dequeue()); // 가장 첫번째에 있는 값을 제거하고 반환
            Console.WriteLine(_queue.Dequeue());
            Console.WriteLine(_queue.Dequeue());


            // ---------------------------------------
            // Stack ( List와 비슷하나, LIFO ( Last Input, First Output ) 체계이다 . )
            // ---------------------------------------
            Stack<int> _stack = new Stack<int>();

            _stack.Push(10);
            _stack.Push(20);
            _stack.Push(30);

            
           Console.WriteLine(_stack.Peek()); // 가장 마지막에 있는 값을 반환
           Console.WriteLine(_stack.Pop()); 
           Console.WriteLine(_stack.Pop());
           Console.WriteLine(_stack.Pop());

        }
    }
}
