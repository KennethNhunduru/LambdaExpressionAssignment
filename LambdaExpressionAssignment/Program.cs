using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list of at least 10 employees with at least two employees having
            //the first name “Joe” in the Main() method.

            //Creating the List of Employee type containing all the employees.
            
            List<Employee> allEmployees = new List<Employee>(); //This list is empty.

            //Using the "Add" method to add the objects of Employee class to the List "AllEmployees".
            
            allEmployees.Add(new Employee { Id = 3245, FirstName = "Kunta", LastName = "Dylan" });
            allEmployees.Add(new Employee { Id = 9729, FirstName = "Joe", LastName = "Benson" });
            allEmployees.Add(new Employee { Id = 3348, FirstName = "Natalie", LastName = "Jackson" });
            allEmployees.Add(new Employee { Id = 6574, FirstName = "Ruby", LastName = "Gray" });
            allEmployees.Add(new Employee { Id = 7034, FirstName = "Joe", LastName = "Ramon" });
            allEmployees.Add(new Employee { Id = 2935, FirstName = "Binta", LastName = "Johnson" });
            allEmployees.Add(new Employee { Id = 3472, FirstName = "Dolores", LastName = "Robertson" });
            allEmployees.Add(new Employee { Id = 5668, FirstName = "Joe", LastName = "Diaz" });
            allEmployees.Add(new Employee { Id = 4487, FirstName = "Thomas", LastName = "White" });
            allEmployees.Add(new Employee { Id = 8163, FirstName = "Rose", LastName = "Sherman" });
            allEmployees.Add(new Employee { Id = 4826, FirstName = "Peter", LastName = "Dubois" });
            allEmployees.Add(new Employee { Id = 3375, FirstName = "Joe", LastName = "Littleman" });

            //Retrieving the data from the List "allEmployees" using a "Foreach" loop.

            foreach (var employee in allEmployees)
            {
                Console.WriteLine("My Id is {0} My FirstName is {1} and My LastName is {2}", 
                    employee.Id, employee.FirstName,employee.LastName);
                
            }
            Console.ReadLine();
            
            Console.WriteLine(); //Inserting a blank line after the entries.

            //Creating a NEW LIST of Employee type containing all employees with the first name “Joe”.

            List<Employee> joeEmployees = new List<Employee>(); //This list is empty.            

            //Filtering out the employees with the first name "Joe" using a "Foreach" loop.

            foreach (var joeData in allEmployees)
            {
                if (joeData.FirstName == "Joe")
                {
                    // Adding employees to the list.
                    joeEmployees.Add(new Employee { Id = joeData.Id, FirstName = joeData.FirstName, LastName = joeData.LastName });                   
                }
            }
           
            //Retrieving the data from the List "joeEmployees" using a "Foreach" loop.

            for (int i = 0; i < joeEmployees.Count; i++)
            {
                Console.WriteLine("My id is {0} my firstname is {1} and my lastname is {2}",
                    joeEmployees[i].Id, joeEmployees[i].FirstName, joeEmployees[i].LastName);                
            }

            Console.ReadLine();

            Console.WriteLine(); //Inserting a blank line after the entries.

            //Performing the same filtering action again, but this time with a LAMBDA EXPRESSION.
            //Using the Where() lambda function to filter the list for the first name "Joe".

            List<Employee> newJoeList = allEmployees.Where(x => x.FirstName == "Joe").ToList();

            //This produces a newJoeList with all the employees with first name "Joe".

            //Retrieving the data from the List "newJoeList" using a "Foreach" loop.

            foreach (var joeList in newJoeList)
            {
                Console.WriteLine("My Id is {0} My FirstName is {1} and My LastName is {2}",
                    joeList.Id, joeList.FirstName, joeList.LastName);                
            }

            Console.ReadLine();

            Console.WriteLine(); //Inserting a blank line after the entries.

            //Making a List of all employees with an Id number greater than 5 using a LAMBDA EXPRESSION.

            List<Employee> newGreaterList = allEmployees.Where(x => x.Id > 5).ToList();

            //This produces a newGreaterList with all the employees with Id greater than 5.

            //Retrieving the data from the List "newGreaterList" using a "Foreach" loop.

            foreach (var joeGreater in newGreaterList)
            {
                Console.WriteLine("My Id is {0} which is greater than 5 My FirstName is {1} and My LastName is {2}",
                    joeGreater.Id, joeGreater.FirstName, joeGreater.LastName);
            }

            Console.ReadLine();
        }
    }
}
