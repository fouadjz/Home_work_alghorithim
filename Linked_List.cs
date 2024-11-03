using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_miss_alaa
{
    class Linked_List<Type>
    {
        Node first;
        int Length_of_Linked_List = 0;
        public Node First
        {
            get { return first; }
            set { first = value; }
        }
        public bool IsEmpty() { return first == null; }
        public int Getcount() //the Method return a number of nodes   in Linked List
        {
            int counter = 0;
            Node move = first;
            while (move.Next != null)
                move = move.Next; counter++;
            return counter;
        }
        public void AddFrst(Node temp)
        {
            temp.Next = first;
            first = temp;
            Length_of_Linked_List++;
        }
        public void AddLast(Node temp)
        {
            if (IsEmpty()) { AddFrst(temp); return; }
            Node move = first;
            while (move.Next != null)
                move = move.Next;
            temp.Next = move.Next;
            move.Next = temp;
            Length_of_Linked_List++;
        }
        public void Add_at_index(Node temp, int index)
        {
            if (IsEmpty() || index < 0)
                AddFrst(temp);
            if (index > Length_of_Linked_List)
                AddLast(temp);
            Node move = first;
            int c = 0; index--;
            while (c != index)
            { move = move.Next; c++; };
            temp.Next = move.Next;
            move.Next = temp;
            Length_of_Linked_List++;
        }
        public void Delete_First()
        {
            if (IsEmpty()) return;
            first = first.Next;
        }
        public void Delete_Last()
        {
            if (IsEmpty()) return;
            if (Length_of_Linked_List == 1) { Delete_First(); return; }
            Node move = first;
            while (move.Next.Next != null)
                move = move.Next;
            move.Next = null;
        }
        public void Delett_at_by_data(int data)
        {
            if (IsEmpty()) return;
            if (first.Data == data)
            {
                first = first.Next;
                Length_of_Linked_List--;
                return;
            }
            Node current = first.Next;
            Node previous = first;
            while (current != null)
            {
                if (current.Data == data)
                {
                    previous.Next = current.Next;
                    Length_of_Linked_List--;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }
        public void Print()
        {
            Node move = first;
            while (move != null)
            {
                Console.WriteLine(move.Data);
                move = move.Next;
            }
        }
    }
}