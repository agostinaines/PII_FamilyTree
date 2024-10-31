using System.Collections.Generic;
using System.Text;

namespace Library
{
    public abstract class Visitor<T>
    {
        public string Node
        {
            get
            {
                return this.ContentBuilder.ToString();
            }
        }

        protected StringBuilder ContentBuilder { get; } = new StringBuilder();

        public abstract void Visit(Node<T> node);

        public List<Node<T>> GetDescendants(Node<T> node)
        {
            List<Node<T>> descendants = new List<Node<T>>();
            descendants.Add(node);
            
            foreach (var child in node.Children)
            {
                descendants.AddRange(GetDescendants(child));
            }

            return descendants;
        }

        public int CalculateAge(List<Node<Person>> children)
        {
            int age = 0;
            foreach (var node in children)
            {
                age += node.Value.Age;
            }
            return age;
        }

        public int GetMaxAge(List<Node<Person>> children)
        {
            int maxAge = 0;

            foreach (var node in children)
            {
                if (node.Value.Age > maxAge)
                {
                    maxAge = node.Value.Age;
                }
            }

            return maxAge;
        }

        public string GetLongestName(List<Node<Person>> children)
        {
            string longestName = string.Empty;

            foreach (var node in children)
            {
                if (node.Value.Name.Length > longestName.Length)
                {
                    longestName = node.Value.Name;
                }
            }

            return longestName;
        }
    }
}