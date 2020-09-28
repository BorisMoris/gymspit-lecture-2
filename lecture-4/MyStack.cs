using System;
using System.Linq;
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=netcore-3.1


namespace Lecture4
{
	class MyStack<T>
	{
		private const int INITIAL_CAPACITY = 10;

		private T[] items = new T[INITIAL_CAPACITY];

		private int count = 0;

		private int capacity = INITIAL_CAPACITY;


		public void Push(T item)
		{
			if (count >= capacity) {
				capacity *= 2;
				Array.Resize(ref items, capacity);
			}

			items[count] = item;
			count += 1;
		}


		public T Pop()
		{
			if (!(count > 0)) {
				throw new Exception();
			}

			T item = items[count - 1];
			items[count - 1] = default(T);
			count -= 1;
			return item;
		}


		public T Peek()
		{
			if (!(count > 0)) {
				throw new Exception();
			}

			return items[count - 1];
		}


		public bool IsEmpty()
		{
			return !(count > 0);
		}

        //new methods:
        
        public void Clear()
        {
            Array.Clear(items, 0, count);
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public bool Contains(T searchedItem)
        {
            
            for(int i = 0; i<count;i++) {
                if(Equals(searchedItem, items[i]))
                {
                    return true;
                }
            }            
            return false;            
        }


        
        public void ReverseOrder()
        {
            ArrayReverse(0, count - 1);
        }
        

        //Tried implementing my own method instead of using Array.Reverse

        public void ArrayReverse(int firstIndex, int lastIndex)
        {
            if (firstIndex >= lastIndex)
            {
                return;
            }
            
            T temp = items[firstIndex];
            items[firstIndex] = items[lastIndex];
            items[lastIndex] = temp;
            firstIndex++;
            lastIndex--;
            ArrayReverse(firstIndex, lastIndex);
        }
	}
}
