using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HACKERS;



namespace Final_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            My_Class.Coloer_Message(ConsoleColor.DarkRed, "Wellcome to My Program\n----------------------");
            My_Class.Coloer_Message(ConsoleColor.Green, "1) Add Student\n2) Print the Data For Student\n3) Print Last Student\n4) Print Number Of Students\n5) Exit\n-----------------------------");
            Linked_List_Student linked_list = new Linked_List_Student();
            int choice = 0;
            do
            {
                Console.WriteLine("Enter Number For Chioce ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    My_Class.Coloer_Message(ConsoleColor.Cyan, "Please Enter A Valid Number");
                }
                switch (choice)
                {
                    case 1:
                        Student new_student = new Student();
                        new_student.Input_Data();
                        Node n1 = new Node(new_student);
                        linked_list.AddInOrderData(n1);
                        break;
                    case 2: linked_list.Print_Data_For_Students();
                        break;
                    case 3: linked_list.Get_Nerd();
                        break;
                    case 4:
                        var count=Linked_List_Student.GetLength;
                        My_Class.Coloer_Message(ConsoleColor.DarkMagenta,"The Number od Students : "+count+"\n");
                        break;
                }
            } while (choice != 5);
            My_Class.Coloer_Message(ConsoleColor.DarkRed, "\nThank you for using my program");
        }
    }
}
