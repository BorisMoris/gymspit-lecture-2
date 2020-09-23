using System;
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1


namespace Lecture4
{
	class MyList<T>
	{
		private const int INITIAL_CAPACITY = 10;

		private T[] items = new T[INITIAL_CAPACITY];

		private int count = 0;

		private int capacity = INITIAL_CAPACITY;


		public T Get(int i)
		{
			if (i < 0 || i >= count) {
				throw new ArgumentOutOfRangeException();
			}

			return items[i];
		}


		public void Add(T item)
		{
			if (count >= capacity) {
				capacity *= 2;
				Array.Resize(ref items, capacity);
			}

			items[count] = item;
			count += 1;
		}


		public int Count()
		{
			return count;
		}
	}
}
