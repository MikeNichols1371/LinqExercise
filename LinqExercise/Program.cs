using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
         
        
        static void Main(string[] args)
        {
            Console.WriteLine($"The Sum of the array equals: {numbers.Sum()}");
            Console.WriteLine();

            Console.WriteLine($"The Average of the array equals: {numbers.Average()}");
            Console.WriteLine();

            Console.WriteLine($"The array sorted in ascending order is:");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine($"The array sorted in descending order is: ");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("The numbers in the array greater than 6 are: ");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Four of the numbers in the array in ascending order are: ");
            numbers.OrderBy(x => x).Take(4).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("The array listed with my age inputted at index 4 is: ");
            numbers[4] = 25;
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            //TODO: Print the Average of numbers

            //TODO: Order numbers in ascending order and print to the console

            //TODO: Order numbers in decsending order adn print to the console

            //TODO: Print to the console only the numbers greater than 6

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();
            
            Console.WriteLine("Employees first names starting with C or S in ascending order");
            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();

            Console.WriteLine("Employees over 26 in order by age and first name");
            employees.Where(x => x.Age > 26).OrderBy(x => (x.Age)).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"Full Name: {x.FullName}\n Age: {x.Age}" ));
            Console.WriteLine();

            
            Console.WriteLine("Sum  and Average of employees Years of Experience with 10 years or less experiance over age 35");
            var filter = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var sum =filter.Sum(x => x.YearsOfExperience);
            var average = filter.Average(x => x.YearsOfExperience);
            Console.WriteLine($"Sum: {sum}\nAverage: {average}");
            Console.WriteLine();

            Console.WriteLine("Adding new employee to list without using .Add");
            var addEmployee = new Employee("Mike", "Nichols", 25, 0);
            employees.Append(addEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));
            

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35

            //TODO: Add an employee to the end of the list without using employees.Add()


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
