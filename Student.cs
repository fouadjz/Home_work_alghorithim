using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HACKERS;
namespace Final_Excercise
{
    class Student
    {

        public static int idcounter =1;
        public string Name { set; get; }
        public double First_Exam { set; get; }
        public double Second_Exam { set; get; }
        public double Result { set {Result=value;} get { return (First_Exam + Second_Exam) / 2; } }
        public  int ID {  set; get; }
        public  enum Mark
        {
            Successful,Failed,Good,Very_Good,Excellent
        }
        
        public Mark Results_Exam { get; set; }
        /// <summary>
        /// this Methode its Calculate for Result 
        /// </summary>
        public void  CalcResult()
        {
          
            //double Result = (First_Exam + Second_Exam) / 2; 
            if(Result>=90)
            { Results_Exam = Mark.Excellent; }
            else if (Result >= 80 && Result < 90) { Results_Exam = Mark.Very_Good; }
            else if (Result >= 70 && Result < 80) { Results_Exam = Mark.Good;}
            else
            { Results_Exam = (Result >= 60) ? Mark.Successful : Mark.Failed; }
        }
        public Student( string Name)
        {
            this.Name = Name;
        }

        public Student( string Name, int First_Exam, int Second_Exam) : this( Name)
        {
            this.First_Exam = First_Exam;
            this.Second_Exam = Second_Exam;
        }
        public void Input_Data()
        {
            Console.WriteLine("Enter the Name");
            Name = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter the Mark Of First Exam");
                try
                {
                    First_Exam = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    My_Class.Coloer_Message(ConsoleColor.Cyan, "Please Enter A Valid Number");
                }
            } while (First_Exam > 100 || First_Exam < 0);
            do
            {
                Console.WriteLine("Enter the Mark Of Second Exam");
                try
                {
                    Second_Exam = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    My_Class.Coloer_Message(ConsoleColor.Cyan, "Please Enter A Valid Number");
                }
            } while (Second_Exam > 100 || Second_Exam < 0);
            CalcResult();
        }
        public Student()
        {
            this.ID = idcounter++;
        }
    }
}
