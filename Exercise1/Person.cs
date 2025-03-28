namespace Exercise1;

public class Person
{
    public string FirstName { get; set; } = "Undefined";
    public string LastName { get; set; } = "Undefined";
    public int Age { get; set; }
    private static int InstanceCount { get; set; } = 0;

    public Person()
    {
        IncreaseInstanceCount();
    }

    public Person(string firstName, string lastName, int age) : this()
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public void Speak()
    {
        Console.WriteLine($"Hello, my name is {FirstName} {LastName}");
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Age}";
    }

    public string GetFullName() => $"{FirstName} {LastName}";

    private static void IncreaseInstanceCount()
    {
        InstanceCount++;
    }

    public static int GetInstanceCount()
    {
        return InstanceCount;
    }
}
