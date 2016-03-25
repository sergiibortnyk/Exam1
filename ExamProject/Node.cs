using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class Node<T>
    {
        private T node;
        private Node<T> next;
        private Node<T> prev;

        public Node (T node)
        {
            this.node = node;
            next = null;
            prev = null;
        }

        public T NodeElement
        {
            get
            {
                return node;
            }
            set
            {
                node = value;
            }    
        }
        public Node<T> NextElement
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
        public Node<T> PrevElement
        {
            get
            {
                return prev;
            }
            set
            {
                prev = value;
            }
        }
    }
}
