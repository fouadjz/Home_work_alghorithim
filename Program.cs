using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Home_work_miss_alaa
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to C# Language\n-----------------------");
            Linked_List<int> Link1 = new Linked_List<int>();
            Node n1=new Node(3);
            Node n2 = new Node(5);
            Node n3 = new Node(2);
            Node n4 = new Node(0);
            Node n5 = new Node(9);
            //Add
            Link1.AddFrst(n1);
            Link1.AddFrst(n2);
            Link1.Add_at_index(n4, 2);
            Link1.AddLast(n3);
            Link1.AddLast(n5);
            // Delete
            //Link1.Delete_First();
           //Link1.Delete_Last();
            //Link1.Delett_at_by_data(2);
            Link1.Print();
 
        }
    }
}