using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person Marimarta = new Person("Marimarta", 86);
            Person Dorothy = new Person("Dorothy", 54);

            Person Ines = new Person("Inés", 18);
            Person Titi = new Person("Titi", 3);
            
            Person Ana = new Person("Ana Martinez", 39);
            Person Martina = new Person("Martina Caetano", 18);
            
            
            Node<Person> n1 = new Node<Person>(Marimarta);
            Node<Person> n2 = new Node<Person>(Dorothy);

            Node<Person> n3 = new Node<Person>(Ines);
            Node<Person> n4 = new Node<Person>(Titi);
            
            Node<Person> n5 = new Node<Person>(Ana);
            Node<Person> n6 = new Node<Person>(Martina);
            
            n1.AddChildren(n2);
            n3.AddChildren(n4);
            n1.AddChildren(n5);
            n2.AddChildren(n6);
        }
    }
}
