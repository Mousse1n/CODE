using System;
using System.Drawing;

namespace HomeworkStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            StackByLinkedList stack = new StackByLinkedList();
            for (int i = 0; i < 20; i++)
            {
                stack.Push(i);
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }

    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }
    }

    class SingleLinkedList
    {
        public Node Head { get; }

        public SingleLinkedList()
        {
            this.Head = new Node(-1);
        }


        public void Add(Node newNode)
        {
            var temp = Head.Next;
            newNode.Next = temp;
            Head.Next = newNode;
        }

        public Node Remove()
        {
            if (Head.Next == null)
            {
                throw new Exception("链表为空");
            }
            var r = Head.Next;
            Head.Next = r.Next;
            return r;
        }

        public void Traverse()
        {
            if (Head.Next == null)
            {
                Console.WriteLine("链表为空");
                return;
            }
            var temp = Head.Next;
            while (temp != null)
            {
                Console.WriteLine($"[Data : {temp.Data}]");
                temp = temp.Next;
            }
        }
    }

    class StackByLinkedList
    {
        private int top = -1;
        private SingleLinkedList datas = new SingleLinkedList();

        public int Count { get => top + 1; }
        public bool IsEmpty { get => top == -1; }

        public void Push(int data)
        {
            Node node = new Node(data);
            datas.Add(node);
            top++;
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("栈空");
            }
            top--;
            return datas.Remove().Data;
        }

        public int Peek()
        {
            if (IsEmpty)
            {
                throw new Exception("栈空");
            }
            return datas.Head.Next.Data;
        }
    }
}
