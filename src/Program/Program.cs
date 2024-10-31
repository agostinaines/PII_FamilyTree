using Library;
using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person Marimarta = new Person("Marimarta", 86);
            Person Dorothy = new Person("Dorothy", 54);

            Person Lourdes = new Person("Lourdes", 50);
            Person Ines = new Person("Inés", 18);
            Person Titi = new Person("Titi", 3);
            
            Person Ana = new Person("Ana Martinez", 39);
            Person Martina = new Person("Martina Caetano", 18);
            Person Teddy = new Person("Teddy", 2);
            
            
            Node<Person> n1 = new Node<Person>(Marimarta);
            Node<Person> n2 = new Node<Person>(Dorothy);
            // Node<Person> n3 = new Node<Person>()

            Node<Person> n4 = new Node<Person>(Lourdes);
            Node<Person> n5 = new Node<Person>(Ines);
            Node<Person> n6 = new Node<Person>(Titi);
            
            Node<Person> n7 = new Node<Person>(Ana);
            Node<Person> n8 = new Node<Person>(Martina);
            Node<Person> n9 = new Node<Person>(Teddy);
            
            //Personas de romi
            // Node<Person> n10 = new Node<Person>()
            // Node<Person> n11 = new Node<Person>()
            // Node<Person> n12 = new Node<Person>()
            
            n1.AddChildren(n2);
            n1.AddChildren(n7);
            // n3.AddChildren();
            n2.AddChildren(n8);
            n4.AddChildren(n5);
            n5.AddChildren(n6);
            n8.AddChildren(n9);

            PersonVisitor personVisitor = new PersonVisitor();
            
            int totalAge = personVisitor.GetAge(n1);
            Console.WriteLine($"La suma total de las edades de los hijos de Marimarta es: {totalAge}");
            
            int maxAge = personVisitor.GetMaxAge(n1);
            Console.WriteLine($"La edad máxima entre los descendientes de Marimarta es: {maxAge}");
            
            string longestName = personVisitor.GetLongestName(n1);
            Console.WriteLine($"El nombre más largo entre los descendientes de Marimarta es: {longestName}");
        
        }
    }
}
