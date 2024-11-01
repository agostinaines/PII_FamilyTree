using Library;
using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person marimarta = new Person("Marimarta", 86);
            Person dorothy = new Person("Dorothy", 54);
            Person jily = new Person("Jily", 26);

            Person lourdes = new Person("Lourdes", 50);
            Person ines = new Person("Inés", 18);
            Person titi = new Person("Titi", 3);
            
            Person ana = new Person("Ana Martinez", 39);
            Person martina = new Person("Martina Caetano", 18);
            Person teddy = new Person("Teddy", 2);

            Person alicia = new Person("Alicia", 79);
            Person enrica = new Person("Enrica", 47);
            Person guillermo = new Person("Guillermo", 11);
            
            // Personas de Luis
            Node<Person> n1 = new Node<Person>(marimarta);
            Node<Person> n2 = new Node<Person>(dorothy);
            Node<Person> n3 = new Node<Person>(jily);

            Node<Person> n4 = new Node<Person>(lourdes);
            Node<Person> n5 = new Node<Person>(ines);
            Node<Person> n6 = new Node<Person>(titi);
            
            Node<Person> n7 = new Node<Person>(ana);
            Node<Person> n8 = new Node<Person>(martina);
            Node<Person> n9 = new Node<Person>(teddy);
            
            //Personas de romi
            Node<Person> n10 = new Node<Person>(alicia);
            Node<Person> n11 = new Node<Person>(enrica);
            Node<Person> n12 = new Node<Person>(guillermo);
            
            n1.AddChildren(n2);
            n1.AddChildren(n7);
            n2.AddChildren(n3);
            n2.AddChildren(n8);
            n4.AddChildren(n5);
            n5.AddChildren(n6);
            n8.AddChildren(n9);
            n10.AddChildren(n11);
            n11.AddChildren(n12);
            

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
