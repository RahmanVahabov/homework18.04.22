using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopContinue = true;
            int choice = 0;

            Company comp = new Company();
            IEmployee emp = new Employee();

            while (loopContinue)
            {

                choice = Menu();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("******** ADD EMPLOYEE ********");
                        Console.WriteLine();
                        Console.Write("Enter your full name: ");
                        emp.FullName = Console.ReadLine();

                        comp.AddEmployee(emp, out _);
                        loopContinue = true;
                        break;
                    case 2:
                        Console.WriteLine("******** VIEW ALL EMPLOYEE DETAILS ********");
                        Console.WriteLine();
                        comp.GetEmployees();
                        loopContinue = true;
                        break;
                    case 3:
                        Console.WriteLine("******** EXITING ********");
                        Console.WriteLine();
                        Console.WriteLine("Program exited...");
                        loopContinue = false;
                        break;
                    default:
                        loopContinue = true;
                        break;
                }
                if (loopContinue)
                    Console.WriteLine("\nReturning to main menu.");
                Console.WriteLine();
            }
        }

        static int Menu()
        {
            Console.WriteLine("\n***** Static Employee Class *****");
            Console.WriteLine();
            Console.WriteLine("1) Add Employee");
            Console.WriteLine("2) View All Employee details");
            Console.WriteLine("3) Exit");
            Console.WriteLine();
            Console.Write("Please input your option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }
    }
}
