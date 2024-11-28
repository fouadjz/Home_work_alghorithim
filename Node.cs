using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Excercise
{
    class Node
    {
        Student student;
        public Student Student
        {
            get { return student; }
            set { student = value; }
        }
        Node next;
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node() { }
        public Node(Student student)
        {
            this.Student = student;
        }
    }
}
