using System;

namespace Lab1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Task1 myProgram = new Task1();
            myProgram.doSomething();
            Console.WriteLine("hello my friend");
        }

        public void doSomething()
        {
            User employee = new User();
            employee.name = "Tergeltengis";;
            employee.getPhone = 91625500;
            Console.WriteLine("Ner: " + employee.name + " Utas: " + employee.getPhone);
        }
    }
}
