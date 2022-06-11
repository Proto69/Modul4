using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinkedArray<T>
    {
        class Node
        {
            private Node nextNode;
            private T value;

            public Node(T value)
            {
                Value = value;
            }
        }

        using Node;
        private int count;
        private Node head;
        private Node tail;

        public LinkedArray<T> Add(T value)
        {
            var node = new Node(value);
            if (head == null) head = node;
            else
            {
                if (tail == null) tail = head;
                tail.NextNode = node;
                tail = node;
            }
            Count++;
            return this;
        }

        public LinkedArray<T> Remove(T value)
        {
            if (head != null)
            {
                Node currentNode = head;
                Node prevNode = head;
                while(true)
                {
                    if (currentNode == null) throw new ArgumentException("There is no value like this!");
                    if (currentNode.Value.Equals(value)) break;
                    prevNode = currentNode;
                    currentNode = currentNode.NextNode;
                }
                //Проверка дали не махаме head-a
                if (currentNode == head) head = head.NextNode;
                //Проверка дали не махаме tail-a
                else if (currentNode == tail) tail = prevNode;
                else prevNode.NextNode = currentNode.NextNode;
                Count--;
            }
            else throw new ArgumentException("The LinkedArray is empty!");
            return this;
        }

        public int GetIndex(T value)
        {
            int index = 0;
            Node currentNode = head;
            while (!currentNode.Value.Equals(value))
            {
                if (currentNode.NextNode == null) return -1;
                currentNode = currentNode.NextNode;
                index++;
            }
            return index;
        }

        public int Count { get => count; private set => count = value; }
    }
}
