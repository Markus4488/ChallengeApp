using ChallengeApp;

var employee = new Employee("Andrzej", "Andrzejewski");


Console.WriteLine("       Welcome to TEST program");
Console.WriteLine("=======================================");
Console.WriteLine();

do
{
    Console.WriteLine();
    Console.WriteLine($"Enter grade no {employee.GetCount() + 1}      /to finish enter >q</");
    var input = Console.ReadLine();
    
    if (input == "q")
    {
        break;
    }
    employee.Addgrade(input);
    
}
while (true);

var statistics = employee.GetStatistics();

Console.WriteLine($"Entered {employee.GetCount()} grades.");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");