namespace CSharp10;

public class Person
{
    public int Id { get; set; }
    public string FullName { get; init; } = string.Empty; //init C# 9 and later
}
