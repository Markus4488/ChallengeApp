using ChallengeApp;

var employee = new Employee("Andrzej", "Andrzejewski");
employee.Addgrade(2);
employee.Addgrade(3);
employee.Addgrade(7);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");