using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            List<string> studentList = new List<string>() { "David", "Umar", "Matt", "Aaron", "Mahmoud", "Mitch", "Kris", "Ryan", "Coulton", "Mac", "Lamond", "Nathan", "Keith" };
            PickGroup(studentList, 4);
            Console.ReadKey();
        }
        public static void PickGroup(List<string> groupList, int groupSize)
        {
            List<string> currentGroupList = new List<string>();
            int groupNumber = 1;
            //int count = studentList.Count();
            Random rnd = new Random();
            string currentStudent = string.Empty;
            while (groupList.Count > 0)
            {
                int index = rnd.Next(groupList.Count);
                currentStudent = groupList[index];
                if (groupList.Count > groupSize)
                {
                    // get groupSize# of currentStudent and add to currentGroupList
                    currentGroupList.Add(currentStudent); // do (groupSize) times;
                    groupList.RemoveAt(index);
                }
                else if (groupList.Count <= groupSize && groupList.Count > 0)
                {
                    currentGroupList.Add(currentStudent); 
                    groupList.RemoveAt(index);
                }
                if (currentGroupList.Count == groupSize)
                {
                    Console.WriteLine("Group: " + groupNumber);
                    Console.WriteLine(currentGroupList[0]);
                    Console.WriteLine(currentGroupList[1]);
                    Console.WriteLine(currentGroupList[2]);
                    Console.WriteLine(currentGroupList[3]);
                    currentGroupList.Clear();
                    groupNumber++;
                }
                else if (currentGroupList.Count < groupSize)
                {
                    Console.WriteLine("Group: " + groupNumber);
                    Console.WriteLine(currentGroupList[0]);
                    currentGroupList.Clear();
                }

            }
        }
    }
}
