using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseManagementApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Group> groups = new List<Group>();
            Group<Student> group = new Group<Student>();
            Student student = new Student();

            for (int i = 1; i != 0; i++)
            {

                Console.WriteLine("Ashagidakilardan birini sec:");
                Console.WriteLine("1.Yeni qrup yarat:");
                Console.WriteLine("2.Qruplarin siyahisini goster:");
                Console.WriteLine("3.Qrup uzerinde duzelish et:");
                Console.WriteLine("4.Qrupdaki telebelerin siyahisini goster.");
                Console.WriteLine("5.Butun telebelerin siyahisini goster:");
                Console.WriteLine("6.Telebe yarat:");

                int value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("1.Yeni qrup yarat:");
                        Group group1 = new Group();
                        groups.Add(group1);
                        Console.WriteLine("================================");
                        break;
                    case 2:
                        Console.WriteLine("2.Qruplarin siyahisini goster:");
                        foreach (var item in groups)
                        {
                            Console.WriteLine($" Group No: {item.No}\n Category:{item.Category}\n Is group online? {item.isOnline}\n Limit:{item.Limit}");
                        }
                        Console.WriteLine("================================");

                        break;
                    case 3:
                        Console.WriteLine("3.Qrup uzerinde duzelish et:");
                        Console.WriteLine("Enter the group no:");
                        string groupno = Console.ReadLine();
                        Console.WriteLine("Enter the new no of group:");
                        groupno = Console.ReadLine();
                        bool isExist = true;
                        while (isExist)
                        {
                           throw new Exception("Bu adda qrup movcuddur.");
                            Console.WriteLine("Grup adini yeniden daxil edin:");
                            string No = Console.ReadLine();
                            if (isExist)
                            {
                                Console.WriteLine("Grup adini yeniden daxil edin:");
                              No = Console.ReadLine();
                            }
                        }
                        Console.WriteLine("=================================");
                        break;
                    case 4:
                        Console.WriteLine("4.Qrupdaki telebelerin siyahisini goster.");
                        break;
                    case 5:
                        Console.WriteLine("5.Butun telebelerin siyahisini goster:");
                        break;
                    case 6:
                        Console.WriteLine("6.Telebe yarat:");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
