using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace Library;

public class Person
{
    private string Name { get; set; }
    
    public int Age { get; set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}