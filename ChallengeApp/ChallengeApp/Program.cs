using ChallengeApp;

Employee employee1 = new Employee("Andrzej", "Andrzejewski", 34);
Employee employee2 = new Employee("Paweł", "Pawłowski", 24);
Employee employee3 = new Employee("Krzysztof", "Krzysztofiński", 45);


employee1.AddScore(5);
employee1.AddScore(2);
var result = employee1.Result;
Console.WriteLine(result);
//var aaa = Math.Max(result);



