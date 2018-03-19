using System;

namespace ChoiceA.LinkedList
{
    public class LinkedList<T>
    {
        public class Node
        {
            public Node Next;
            public T Data;
        }

        private Node head = null;
        public int Count;
        
        public void AddNode(T data)
        {
            Node newNode = new Node
            {
                Next = head,
                Data = data
            };
            head = newNode;
            Count++;
        }

        public Node GetNodeFromTail(int itemsFromTail)
        {
            if (itemsFromTail < 0 || itemsFromTail > Count)
            {
                throw new IndexOutOfRangeException("The number passed must be less than the total number of items");
            }

            var itemIndex = Count - itemsFromTail;
            Node item = head;
            int i = 0;
            while (i < itemIndex)
            {
                item = item.Next;
                i++;
            }
            return item;
        }

    }
}
