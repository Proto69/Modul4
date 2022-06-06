using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CircularQueue<T>
    {
        private int count;
        private T[] array;
        private int start;
        private int end;

        public CircularQueue()
        {
            array = new T[16];
        }

        public CircularQueue(int capacity)
        {
            array = new T[capacity];
        }

        public CircularQueue<T> Enqueue(T item)
        {
            if (count >= array.Length) Grow();
            array[end] = item;
            end = (end + 1) % array.Length;
            count++;
            return this;
        }

        public T Dequeue()
        {
            T item = array[start];
            start++;
            var newArray = new T[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[start];
                start++;
            }
            start = 0;
            array = newArray;
            return item;
        }

        public T Peek()
        {
            return array[start];
        }

        public T[] ToArray()
        {
            var newArray = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[start];
                start = (start + 1) % array.Length;
            }
            return newArray;
        }

        private void Grow()
        {
            var newArray = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[start];
                start = (start + 1) % array.Length;
            }
            start = 0;
            end = count;
            array = newArray;
        }
    }
}
