using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagementApplication
{
    public class Student
    {
        public string FullName { get; set; }
        public int GroupNo { get; set; }
        public bool Type { get; set; }
        public Student(string fullname, int groupno, bool type)
        {
            FullName = fullname;
            GroupNo = groupno;
            Type = type;
        }
        public override string ToString()
        {
            var result = Type ? "zemanetli" : "zemanetsiz";
            return $"Full name: { FullName} Group No:  { GroupNo} Type:  { result}";
        }
        public Student()
        {

        }
    }
}
