namespace Labb8_OOP_Generic_Collectons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create 5 object of Employee class with diffrent id, name ect.
            Employee E1 = new Employee()
            {
                Id = 1,
                Name = "Ester",
                Gender = "Kvinna",
                Salary = 28000
            };
            Employee E2 = new Employee()
            {
                Id = 2,
                Name = "Sammy",
                Gender = "Kvinna",
                Salary = 24000
            };
            Employee E3 = new Employee()
            {
                Id = 3,
                Name = "Harry",
                Gender = "Man",
                Salary = 27000
            };
            Employee E4 = new Employee()
            {
                Id = 4,
                Name = "Ted",
                Gender = "Man",
                Salary = 20000
            };
            Employee E5 = new Employee()
            {
                Id = 5,
                Name = "Josefin",
                Gender = "Kvinna",
                Salary = 30000
            };
            //Create a stack with the object of Employee
            Stack<Employee> stack = new Stack<Employee>();
            //Retrive object in stack with puch method
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            //Write the content in the stack with a foereach loop
            Console.WriteLine("Hämtar objekt genom push Metoden");
            foreach (Employee employee in stack) 
            {//show info of evry object in the stack
                Console.WriteLine($"Id: {employee.Id} \nNamn: {employee.Name} \nKön: {employee.Gender} \nLön: {employee.Salary}");
                Console.WriteLine($"Antal objekt kvar: {stack.Count} ");
                Console.WriteLine("---------");
            }

            //Retrive the object with pop method
            Console.WriteLine("Hämtar objekt genom pop Metoden");
            while (stack.Count > 0)
            {
                Employee employee = stack.Pop();
                Console.WriteLine($"Id: {employee.Id} \nNamn: {employee.Name} \nKön: {employee.Gender} \nLön: {employee.Salary}");
                Console.WriteLine($"Antal objekt kvar: {stack.Count}");
                Console.WriteLine("---------");
            }

            // push again 
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            Console.WriteLine("Hämtar objekt genom Peek Metoden");
            for (int i = 0; i < 2; i++)
            {
                Employee employee = stack.Peek();
                Console.WriteLine($"Id: {employee.Id} \nNamn:{employee.Name} \nKön:{employee.Gender} \nLön:{employee.Salary} ");
                Console.WriteLine($"Totalt kvar: {stack.Count}");
                Console.WriteLine("---------");
            }

            if (stack.Contains(E3))
            {
                Console.WriteLine($"Anställd 3 finns.");

            }

            Console.WriteLine("****Del2****"); //part two

            List<Employee> minLista = new List<Employee>();
            minLista.Add(E1);
            minLista.Add(E2);
            minLista.Add(E3);
            minLista.Add(E4);
            minLista.Add(E5);

            if (minLista.Contains(E2))
            {
                Console.WriteLine("Employee 2 finns i Listan.");
                Console.WriteLine("---------");

            }
            else
            {
                Console.WriteLine("Employee 2 finns inte i Listan.");
                Console.WriteLine("---------");
            }

            Employee maleEmployee = minLista.Find(e => e.Gender == "Man");
            Console.WriteLine($"Första manliga anställda är: {maleEmployee.Name}.");
            Console.WriteLine("---------");

            List<Employee> maleEmployee2 = minLista.FindAll(e => e.Gender == "Man");
            Console.WriteLine("Alla manliga anställda är");
            foreach (Employee employee in maleEmployee2)
            {
                Console.WriteLine($"Id: {employee.Id} \nNamn: {employee.Name} \nKön: {employee.Gender} \nLön: {employee.Salary}");
                Console.WriteLine("---------");
            }

        }
    }
}