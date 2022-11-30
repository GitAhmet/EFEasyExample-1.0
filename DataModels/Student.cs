using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEasyExample.DataModels
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentUserName { get; set; }
       // public string StudentFirstName { get; set; }
       // public string StudentLastName { get; set; }
       // public string StudentAddress { get; set; } 
       // public int StudentPhoneNumber { get; set; }
       // public string StudentSchoolName { get; set; }

        public List<Class> StudentClasses { get; set; }

    }
}
