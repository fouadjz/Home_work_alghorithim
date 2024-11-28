using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HACKERS;
namespace Final_Excercise
{
    class Linked_List_Student
    {
        Node First;
        Node Last;
        static int length;

        public static int GetLength
        {
            get { return length; }
        }
        public void AddInOrderData(Node temp)
        {
            if (First == null)
            {
                AddFirst(temp);
                return;
            }
            if (length == 1)
            {
                if (First.Student.Result >= temp.Student.Result)
                {
                    AddFirst(temp);
                }
                else
                {
                    AddLast(temp);
                }
                return;
            }
            Node move = First;
            if (temp.Student.Result <= First.Student.Result)
            {
                AddFirst(temp);
                return;
            }
            while (move.Next != null && move.Next.Student.Result <= temp.Student.Result)
            {
                move = move.Next;
            }
            temp.Next = move.Next;
            move.Next = temp;
            length++;
        }
        public void AddLast(Node temp)
        {
            if (First == null)
            {
                AddFirst(temp); return;
            }
            Last.Next = temp;
            Last = temp;
            length++;
        }
        public void AddFirst(Node temp)
        {
            if (First == null)
                Last = temp;
            temp.Next = First;
            First = temp;
            length++;
        }
        public void Print_Data_For_Students()
        {
            Node move = First;
            while (move != null)
            {
                My_Class.Coloer_Message(ConsoleColor.DarkBlue, "The ID is : " + move.Student.ID);
                My_Class.Coloer_Message(ConsoleColor.DarkBlue , "The Name is " + move.Student.Name);
                My_Class.Coloer_Message(ConsoleColor.Yellow,"the outcome of exam is : "+move.Student.Result+"\n" + "The Reuslt is :" + move.Student.Results_Exam) ;
                Console.WriteLine("-------------------");
                move = move.Next;
            }
        }
        public void Get_Nerd()
        {
            Node nerd = First;
            double Max_Result = 0;
            string Name = "";
            while (nerd != null && nerd.Student.Result >= Max_Result)
            {
                Max_Result = nerd.Student.Result;
                Name = nerd.Student.Name;
                nerd = nerd.Next;
            }
            My_Class.Coloer_Message(ConsoleColor.DarkYellow, "The Name :" + Name);
            My_Class.Coloer_Message(ConsoleColor.DarkYellow,"The Result :"+Max_Result);
            Console.WriteLine("-------------------");
        }
    }
}