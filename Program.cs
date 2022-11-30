using EFEasyExample.DataModels;
using System;
using System.Linq;

namespace EFEasyExample

{
    class Program
    {
        static void Main(string[] args)
        {
            using Context myContext = new Context();

            var myClass = myContext
                .Class
                .FirstOrDefault(c => c.MaxClassSize > 0);

            myClass.ClassName = "changed Name !";

            myContext.Students.Add(new Student()
            {
                StudentUserName = "Joe Smith",
                StudentClasses = new List<Class>()
                {
                    new Class()
                    {
                        ClassLanguage = Enums.Language.English,
                        ClassName = "myFirstClass",
                        MaxClassSize = 12
                    },
                    new Class()
                    {
                        ClassLanguage = Enums.Language.French,
                        ClassName = "myScondClass",
                        MaxClassSize  = 25
                    }
                }

            });
            myContext.SaveChanges();
        }
    }
}

