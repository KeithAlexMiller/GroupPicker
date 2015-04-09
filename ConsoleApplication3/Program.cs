using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static List<string> studentList = new List<string>() { "David", "Umar", "Matt", "Aaron", "Mahmoud", "Mitch", "Kris", "Ryan", "Coulton", "Mac", "Lamond", "Nathan", "Keith" };
        
        public static void Main(string[] args)
        {
            List<string> currentGroupList = new List<string>();
            Random rnd = new Random ();
            Console.WriteLine(PickGroup(studentList, 4));
        }
        public static int PickGroup(List<string> studentList, int groupSize)
        {
            int groupNumber = 1;
            //int count = studentList.Count();
            int index = Random.Next(studentList.Count);
            // int numberOfStudents = 124 ---may not be be needed

            while (count > 0)
            {
                
                masterStudentList.random(0, 4);
                // List add current student to current group list
            }
        }
    }
}
