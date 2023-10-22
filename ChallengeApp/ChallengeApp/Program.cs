using ChallengeApp;

var employee = new Employee("Andrzej", "Andrzejewski");
employee.Addgrade("roman");
employee.Addgrade("344");
employee.Addgrade(3);
employee.Addgrade(2);
var statistics1 = employee.GetStatistics_ForEach();
var statistics2 = employee.GetStatistics_For();
var statistics3 = employee.GetStatistics_DoWhile();
var statistics4 = employee.GetStatistics_While();

Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");