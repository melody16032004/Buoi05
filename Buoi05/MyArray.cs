using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05
{
    class IntNode
    {
        private int data;
        private IntNode next = null;
        private IntNode previous = null;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public IntNode Next
        {
            get { return next; }
            set { next = value; }
        }
        public IntNode Previous
        {
            get { return previous; }
            set { previous = value; }
        }

        public IntNode() { }
        public IntNode(int data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }

    }
    class LinkedList
    {
        private IntNode head = null;
        private IntNode tail = null;
        private int count = 0;

        public IntNode Head { get; set; }
        public IntNode Tail { get; set; }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddFirst(int x)
        {
            IntNode newNode = new IntNode(x);
            if (IsEmpty())
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
                newNode.Previous = null;
            }
        }
        public void AddLast(int x)
        {
            IntNode newNode = new IntNode(x);

            if (IsEmpty())
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
        }

        public void InsertAfter(int x, int y)
        {
            IntNode p = new IntNode(y);
            IntNode newNode = new IntNode(x);

            if (p == tail)
            {
                AddLast(x);
            }
            else
            {
                newNode.Previous = p;
                newNode.Next = p.Next;
                p.Next = newNode;
            }
        }
        public void InsertBefore(int x, int y)
        {
            IntNode p = new IntNode(y);
            IntNode newNode = new IntNode(x);

            InsertAfter(x, y);
            SwapNode(p, newNode);
        }
        public void SwapNode(IntNode p, IntNode newNode)
        {
            int tmp = p.Data;
            p.Data = newNode.Data;
            newNode.Data = tmp;
        }

        public void DisplayNext()
        {
            IntNode p = head;
            while (p != null)
            {
                if (p.Next == null)
                {
                    Console.Write(p.Data + "  \n\n");
                }
                else
                {
                    Console.Write(p.Data + " -> ");
                }
                p = p.Next;
            }
        }
        public void DisplayPrevious()
        {
            IntNode p = tail;
            while (p != null)
            {
                if (p.Previous == null)
                {
                    Console.Write(p.Data + "  \n\n");
                }
                else
                {
                    Console.Write(p.Data + " <- ");
                }
                p = p.Previous;
            }
        }
    }
}
