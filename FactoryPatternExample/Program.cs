using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your object type");
            string type = Console.ReadLine();
            I1 obj=CreateObj.getobject(type);
            Console.WriteLine(obj.getfname());
            Console.ReadLine();


        }
    }
     class CreateObj      //This is the factory where the object will be created
    {
        public static I1 getobject(string typeofobj)
        {
            I1 obj = null;
            if (typeofobj.ToLower() == "student")
            {
                obj = new Student();
            }
            else
            {
                obj = new Teacher();
            }
            return obj;
        }


    }
    interface I1
    {
        string getname();
        string getfname();
    }
    class Teacher:I1
    {
        public string getname()
        {
            return "Teacher Name";

        }
        public string getfname()
        {
            return "Teacher Father Name";
        }
    }
    
    class Student:I1
    {
        public string getname()
        {
            return "Student Name";

        }
        public string getfname()
        {
            return "Student Father Name";
        }
    }
}
