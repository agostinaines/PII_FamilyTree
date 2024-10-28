using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Node<T>
    {
        private T content;

        private List<T> children = new List<T>();

        public T Content
        {
            get { return this.content; }
        }

        public ReadOnlyCollection<T> Children
        {
            get { return this.children.AsReadOnly(); }
        }

        public Node(T content)
        {
            this.content = content;
        }

        public void AddChildren(T n)
        {
            this.children.Add(n);
        }
    }
}

/* public void Accept(IVisitor visitor)
{
    visitor.Visit(this);
}
}*/

