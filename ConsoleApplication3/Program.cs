using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> studentList = new List<string>() { "David", "Umar", "Matt", "Aaron", "Mahmoud", "Mitch", "Kris", "Ryan", "Coulton", "Mac", "Lamond", "Nathan", "Keith" };
            PickGroup(studentList, 4);
            Console.ReadKey();
        }
        public static void PickGroup(List<string> studentList, int groupSize)
        {
            //current list of randomly chosen students
            List<string> currentGroupList = new List<string>();

            //used to denote group number and increments when new group is created
            int groupNumber = 1;

            //random number generator
            Random rng = new Random();

            //randomly choose a student name from studentList and repeat
            for (int i = studentList.Count - 1; i >= 0; i--)
            {
                //initiate random selection of name and add to current list and remove from original
                string currentStudent = studentList[rng.Next(0, i + 1)];
                currentGroupList.Add(currentStudent);
                studentList.Remove(currentStudent);

                //when currentGroupList has groupSize names
                if ((currentGroupList.Count == groupSize) || (studentList.Count == 0))
                {
                    Console.WriteLine("GROUP {0}", groupNumber);
                    for (int j = 0; j < currentGroupList.Count; j++)
                    {
                        Console.WriteLine("{0}", currentGroupList[j]);
                    }
                    Console.WriteLine();
                    //remove names from currentGroupList
                    currentGroupList.Clear();
                    groupNumber++;
                }
            }
        }        
    }
}
