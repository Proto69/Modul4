using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyQueue<T>
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
        private Node head;
        private Node tail;


        public MyQueue<T> Enqueue(T item)
        {
            Node node = new Node(item);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.NextNode = node;
                tail = node;
            }
            Count++;
            return this;
        }

        public T Dequeue()
        {
            CheckIfEmpty();
            T result = head.Value;
            head = head.NextNode;
            Count--;
            return result;
        }

        public T Peek()
        {
            CheckIfEmpty();
            return head.Value;
        }

        public T[] ToArray()
        {
            CheckIfEmpty();
            T[] arr = new T[count];
            Node node = head;
            for (int i = 0; i < count; i++)
            {
                arr[i] = node.Value;
                node = node.NextNode;
            }
            return arr;
        }

        private void CheckIfEmpty()
        {
            if (head == null) throw new Exception("The queue is empty!");
        }

        public int Count { get => count; private set => count = value; }

    }
}
