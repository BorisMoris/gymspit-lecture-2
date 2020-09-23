using System;
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=netcore-3.1


namespace Lecture4
{
	class MyLinkedList<T>
	{
		public class MyListNode {
			public T Item { get; private set; }
			public MyListNode next = null;


			public MyListNode(T item)
			{
				Item = item;
			}
		}

		private MyListNode first = null;

		private MyListNode last = null;

		private int count = 0;


		public MyListNode GetFirst()
		{
			return first;
		}


		public MyListNode GetLast()
		{
			return last;
		}


		public void AddFirst(T item)
		{
			MyListNode node = new MyListNode(item);
			node.next = first;
			first = node;
			if (last == null) {
				last = node;
			}
			count += 1;
		}


		public void AddLast(T item)
		{
			MyListNode node = new MyListNode(item);
			if (first == null) {
				first = node;
			}
			if (last != null) {
				last.next = node;
			}
			last = node;
			count += 1;
		}


		public void AddAfter(T item, MyListNode after)
		{
			MyListNode node = new MyListNode(item);
			node.next = after.next;
			after.next = node;
			if (last == after) {
				last = node;
			}
			count += 1;
		}


		public int Count()
		{
			return count;
		}
	}
}
