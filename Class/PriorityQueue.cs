﻿using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace HospitalQueue.Class
{
    public class PriorityQueue
    {
        private Node? head;
        public void MaxEnqueue(List<object>data , int priority)
        {
            List<object> ModelData = new List<object>();
            Node newNode = new Node(data, priority);

            if (head == null || head.Priority > priority)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node current = head;//Can also reffer to current as runner as it is acting a "counter" when entering the loop 
                while (current.Next != null && current.Next.Priority >= priority)
                {
                    current = current.Next; //increment counter 
                }
                newNode.Next = current.Next; //move node (swap/insert at current position)
                current.Next = newNode;//replace node with new value 
            }
        }
        //public int Dequeue()
        //{
        //    if (IsEmpty())
        //    {
        //        throw new InvalidOperationException("Priority Queue is empty.");
        //    }

        //    int value = head!.Data;
        //    head = head.Next;
        //    return value;
        //}

        //public bool IsEmpty()
        //{
        //    return head == null;
        //}

        //public int Peek()
        //{
        //    if (IsEmpty())
        //    {
        //        throw new InvalidOperationException("Priority Queue is empty.");
        //    }
        //    return head.Data;
        //}
    }
}
