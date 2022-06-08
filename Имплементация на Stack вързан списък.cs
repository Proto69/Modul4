using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyStack<T>
    {
        class Node
        {
            private T value;
            private Node nextNode;

            public Node(T value)
            {
                Value = value;
            }

            public T Value { get => value; set => this.value = value; }
            public Node NextNode { get => nextNode; set => nextNode = value; }
        }

        private int count;
        private Node top;

        public MyStack<T> Push(T item)
        {
            Node node = new Node(item);

            if (top == null) top = node;
            else
            {
                node.NextNode = top;
                top = node;
            }
            Count++;
            return this;
        }

        public T Pop()
        {
            CheckIfEmpty();
            T result = top.Value;
            top = top.NextNode;
            Count--;
            return result;
        }

        public T Peek()
        {
            CheckIfEmpty();
            return top.Value;
        }

        public T[] ToArray()
        {
            CheckIfEmpty();
            T[] arr = new T[Count];
            Node node = top;
            for (int i = 0; i < Count; i++)
            {
                arr[i] = node.Value;
                node = node.NextNode;
            }
            return arr;
        }

        private void CheckIfEmpty()
        {
            if (top == null) throw new Exception("The queue is empty!");
        }

        public int Count { get => count; set => count = value; }
    }
}
