using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagementApplication
{
    class GroupDoesntExistException:Exception
    {
        public GroupDoesntExistException(string msj):base(msj)
        {

        }
    }
}
