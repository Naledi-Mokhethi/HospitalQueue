using System;
using System.Collections.Generic;

namespace HospitalQueue.Class
{
    public class Node
    { 
        public int Priority {  get; set; }
        public Node? Next { get; set; }
        public List<object> Data { get; set; } 

        public Node(List<object> data, int priority)
        {
            Data = data;
            Priority = priority;
            Next = null; 
        }   
    }
}
