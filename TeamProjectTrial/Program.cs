

using TeamProjectTrial;

//original squad
Employee Mara = new Employee("Mara", 80000, "Manager");

Employee Kris = new Employee("Kris", 65000, "Team Chef");

Employee Krista = new Employee("Krista", 80000, "Senior Dev");

Employee Brandon = new Employee("Brandon", 79000, "Office Pet Supervisor");


//added our new recruits
Employee Justin = new Employee("Justin", 40000, "Intern");

Employee Josh = new Employee("Josh", 90000, "Assistant to the Office Pet Supervisor");


//adding everyone to a list of employees
List<Employee> Employees = new List<Employee>();
Employees.Add(Mara);
Employees.Add(Kris);
Employees.Add(Krista);
Employees.Add(Brandon);
Employees.Add(Josh);
Employees.Add(Justin);  

//displaying all names, salaries, and roles
foreach(Employee employee in Employees)
{
    Console.WriteLine($"{employee.Name}, {employee.Salary}, {employee.Position}");
}

