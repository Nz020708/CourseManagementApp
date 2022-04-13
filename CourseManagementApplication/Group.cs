using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagementApplication
{
    public class Group
    {
        List<Student> students = new List<Student>();
        public string No { get; set; }
        public string Category { get; set; }
        //public Category categories;
        public bool isOnline { get; set; }
        public int Limit { get; set; }
        public static int BP = 100;
        public static int DB = 100;
        public static int SA = 100;

        public Group()
        {
            #region Enum
            // switch (category)
            //{//
            // case Category.Programming:
            //
            //   No = $"BP{BP}";
            // BP++;
            //break;
            //case Category.Design:
            //  No = $"DB{DB}";
            //break;
            //case Category.SystemAdministration:
            //  No = $"SA{SA}";
            //break;
            //default:
            //  Console.WriteLine("Bele bir qrup yoxdur.");
            //break;
            //}
            //categories = category;
            #endregion
            Console.WriteLine("Enter Category:");
            Category = Console.ReadLine();
            while (String.IsNullOrEmpty(Category) || String.IsNullOrWhiteSpace(Category))
            {
                throw new Exception("Duzgun daxil etmediniz.");
                if (String.IsNullOrEmpty(Category) || String.IsNullOrWhiteSpace(Category))

                {
                    Console.WriteLine("Yeniden cehd et:");
                    Category = Console.ReadLine();
                }
            }

            Console.WriteLine("Enter Group No:");
            No = Console.ReadLine();
            while (String.IsNullOrEmpty(No) || String.IsNullOrWhiteSpace(No))
            {
                Console.WriteLine("Duzgun daxil etmediniz.");
                if (String.IsNullOrEmpty(No) || String.IsNullOrWhiteSpace(No))
                {
                    Console.WriteLine("Yeniden cehd et:");
                    No = Console.ReadLine();
                }



                Console.WriteLine("Enter group is online or not:");
                isOnline = Convert.ToBoolean(Console.ReadLine());
                if (isOnline)
                {
                    Console.WriteLine("Group is online.");
                    Console.WriteLine("Student limit is 15.");
                    Limit = 15;
                }
                else
                {
                    Console.WriteLine("Group is offline.");
                    Console.WriteLine("Student limit is 10.");
                    Limit = 10;
                }
                
            }
        }
    }
}
