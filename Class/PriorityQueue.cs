using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace HospitalQueue.Class
{
    public class PriorityQueue
    {
        public Node? head;
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
        public string Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("ER Queue is empty.");
            }

            var value = head!.Data;
            head = head.Next;// Before changing the head, we need to write the currrent head to the database 
            return (string)value[0]; //Return next patients name
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("ER Queue is empty.");
            }
            //if (head!.Next != null)
            //    return (string)head!.Data[0]; // used to show the patient that is currently being helped  We are gonna 
            //else
            //    return "There is no next patient";

            return (string)head!.Data[0] + " " + (string)head!.Data[1];
        }
    }
}
