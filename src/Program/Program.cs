using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ana = new Person("Ana Martinez", 39);
            Person Martina = new Person("Martina Caetano", 18);

            Node<Person> raiz = new Node<Person>(Ana);
            Node<Person> nosequeponeraca = new Node<Person>(Martina);
            
            Person Luis = new Person("Luis", 18);
            Person Marimarta = new Person("Marimarta", 86);
            Person Lunin = new Person("Lunin", 24);
            Person Dorothy = new Person("Dorothy", 54);
            Node<Person> n1 = new Node<Person>(Marimarta);
            Node<Person> n2 = new Node<Person>(Dorothy);
            Node<Person> n3 = new Node<Person>(Lunin);
            Node<Person> n4 = new Node<Person>(Luis);
            n1.AddChildren(n2);

            /*
            Node n1 = new Node(Ana);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);*/

            // visitar el árbol aquí
        }
    }
}
