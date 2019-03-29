using System;

namespace PJDataStructures.PJBinaryHeap
{
	/// <summary>
	/// Copyright (c) 2019 Paco Juan Quirós
	/// Licensed under the MIT License.
	///
	/// Nodes are wrappers for the values we will store in the
	/// <see cref="BinaryHeap{T}"/>.
	///
	/// They are quite useful, since they provide the
	/// <see cref="MinusInfiniteWeight"/> field, which will help
	/// us with the filtering.
	/// </summary>
	internal class HeapNode<T> : IComparable<HeapNode<T>>
			where T : IComparable<T>
	{
		public T Element;
		public bool MinusInfiniteWeight;
			
		public HeapNode(T element)
		{
			MinusInfiniteWeight = false;
			Element = element;
		}

		public int CompareTo(HeapNode<T> other)
		{
			if (MinusInfiniteWeight)
				return -1;

			return Element.CompareTo(other.Element);
		}
	}
}