using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_miss_alaa
{
    class Node
    {
        public int Data { get; set; }
        Node next;
        internal Node Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node() { }
        public Node(int data) { Data = data; }
    }
}
