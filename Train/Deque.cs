using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTest
{
    class Deque<T>
    {
        private Stack<T> frontBuffer = new Stack<T>();
        private Stack<T> backBuffer = new Stack<T>();

        public int BackCount { get; private set; }
        public int FrontCount { get; private set; }
        public int Count
        {
            get
            {
                return BackCount + FrontCount;
            }
        }

        public void AddBack(T item)
        {
            backBuffer.Push(item);
            BackCount++;
        }

        public void AddFront(T item)
        {
            frontBuffer.Push(item);
            FrontCount++;
        }

        public T GetFront()
        {
            try
            {
                return frontBuffer.Peek();
            }
            catch { return default; }
        }

        public T GetBack()
        {
            try
            {
                return backBuffer.Peek();
            }
            catch { return default; }
        }

        public T RemoveBack()
        {
            return backBuffer.Pop();
        }

        public T RemoveFront()
        {
            return frontBuffer.Pop();
        }
    }
}
