using ChallengeApp;


Employee employee1 = new Employee("Andrzej", "Andrzejewski", 34);
Employee employee2 = new Employee("Paweł", "Pawłowski", 24);
Employee employee3 = new Employee("Krzysztof", "Krzysztofiński", 45);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(8);
employee1.AddScore(1);
employee1.AddScore(6);

employee2.AddScore(7);
employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(3);
employee2.AddScore(1);

employee3.AddScore(9);
employee3.AddScore(10);
employee3.AddScore(2);
employee3.AddScore(4);
employee3.AddScore(6);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMax = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMax = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine($"Pracownik: {employeeWithMax.Name} {employeeWithMax.Surname} lat: {employeeWithMax.Age} osiągnął największy wynik: {employeeWithMax.Result}");