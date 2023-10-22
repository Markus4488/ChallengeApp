namespace ChallengeApp;

public class Employee
{

    private List<float> grades = new List<float>();
    public Employee(string name, string surname) //konstruktor
    {
        this.Name = name;
        this.Surname = surname;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }

    public void Addgrade(float grade) //metoda
    {
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else
        {
            Console.WriteLine("invalid grade value");
        }
    }
    public void Addgrade(string grade) //metoda
    {
        if (float.TryParse(grade, out float result))
        {
            this.Addgrade(result);
        }
        else
        {
            Console.WriteLine("String is not float");
        }
    }
    public void Addgrade(int grade) //metoda
    {
        float value = (float)grade;
        this.Addgrade(value);
    }

    public Statistics GetStatistics_ForEach()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }
        statistics.Average /= this.grades.Count;
        return statistics;
    }

    public Statistics GetStatistics_For()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;

        for (int i = 0; i < this.grades.Count; i++)
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[i]);
            statistics.Min = Math.Min(statistics.Min, this.grades[i]);
            statistics.Average += this.grades[i];
        }
        statistics.Average /= this.grades.Count;
        return statistics;
    }

    public Statistics GetStatistics_DoWhile()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;
        var i = 0;
        do
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[i]);
            statistics.Min = Math.Min(statistics.Min, this.grades[i]);
            statistics.Average += this.grades[i];
            i++;
        }
        while (i < this.grades.Count);
        statistics.Average /= this.grades.Count;
        return statistics;
    }

    public Statistics GetStatistics_While()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;
        var i = 0;
        while (i < this.grades.Count)
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[i]);
            statistics.Min = Math.Min(statistics.Min, this.grades[i]);
            statistics.Average += this.grades[i];
            i++;
        }
        statistics.Average /= this.grades.Count;
        return statistics;
    }
}