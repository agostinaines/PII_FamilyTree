using System.Collections.Generic;

namespace Library
{
    public class PersonVisitor : Visitor<Person>
    {
        public override void Visit(Node<Person> node)
        {
            ContentBuilder.AppendLine(node.Value.Name);
        }
        
        public int GetAge(Node<Person> node)
        {
            return CalculateAge(GetDescendants(node));
        }
        public int GetMaxAge(Node<Person> node)
        {
            List<Node<Person>> allDescendants = GetDescendants(node);

            int maxAge = 0;
            foreach (var descendant in allDescendants)
            {
                if (descendant.Value.Age > maxAge)
                {
                    maxAge = descendant.Value.Age;
                }
            }
            return maxAge;
        }
        public string GetLongestName(Node<Person> node)
        {
            List<Node<Person>> allDescendants = GetDescendants(node);

            string longestName = string.Empty;
            foreach (var descendant in allDescendants)
            {
                if (descendant.Value.Name.Length > longestName.Length)
                {
                    longestName = descendant.Value.Name;
                }
            }
            return longestName;
        }
    }
}