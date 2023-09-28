using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
        
    class program1 : program4
    {
        string name;
        string lastname;
        //method default constructor
        public program1(string name)
        {
            this.name = name;
        }
        public program1(string firstname, string lastname)
        {
            this.lastname = lastname;
        }
        public void callname()
        {
            Console.WriteLine("My full name is" + lastname);
        }
        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
       
        public void getData()
        {
            Console.WriteLine("I am inside the method");
        }
        static void Main(string[] args)
        {
            program1 p = new program1("Chandu");
            program1 p1 = new program1("Chandu1", "samaleti"); ///, "samaleti"
            p.getData();
            p.getName();
            p.Setdata();
            p.callname();

            Console.WriteLine("Hello world");
            int a = 10;
            Console.WriteLine("Number is " + a);
            string name = "chandu";
            //Console.WriteLine("Name is " + name);
            //another way for print the output
            Console.WriteLine($"Name is {name}");
            var age = 25;
            Console.WriteLine("Age is " + age);
            //var is used for only one data type
            //age = "Hai";
            dynamic height = 12.6;
            //Console.WriteLine("Height is " + height);
            height = "chandu";
            Console.WriteLine("Height is " + height);

        }

    }
}
