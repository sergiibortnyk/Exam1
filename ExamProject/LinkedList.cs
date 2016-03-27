using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class LinkedList<T> : ILinkedList<T> where T : IEquatable<T>, IComparable <T>
    {
        //definition of fields: header - first node of list, tailer - last node of list, counter - number of nodes in the list
        private Node<T> header;
        private Node<T> tailer;
        private int counter;

        //constructor for empty list
        public LinkedList()
        {
            header = null;
            tailer = null;
            counter = 0;
        }

        //method which adds value of generic type to the beginning of the list
        public void AddFirst(T addedvalue)
        {
            if (header == null)
            {
                header = new Node<T>(addedvalue);
                tailer = header;
            }
            else
            {
                Node<T> temp = header;
                header = new Node<T>(addedvalue);
                temp.PrevElement = header;
                header.NextElement = temp;
            }
            counter++;
        }

        //method which adds value of generic type to the end of the list
        public void AddLast(T addedvalue)
        {
            if (header == null)
            {
                header = new Node<T>(addedvalue);
                tailer = header;
            }
            else
            {
                Node<T> temp = tailer;
                tailer = new Node<T>(addedvalue);
                temp.NextElement = tailer;
                tailer.PrevElement = temp;
            }
            counter++;
        }

        public void RemoveFirst()
        {
            if (header == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                header = header.NextElement;
                header.PrevElement = null;
            }
            counter--;
        }

        public void RemoveLast()
        {
            if (tailer == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                tailer = tailer.PrevElement;
                tailer.NextElement = null;
            }
            counter--;
        }

        public bool Find(T value)
        {
            Node<T> temp = header;
            while (temp != null)
            {
                if (value.Equals(temp.NodeElement))
                {
                    return true;
                }
                temp = temp.NextElement;
            }
            return false;
        }

        public void Remove(T removedvalue)
        {            
            Node<T> temp = header;
            Node<T> prevNode = null;
            while (temp != null)
            {                
                if (removedvalue.Equals(temp.NodeElement))
                {
                    break;
                }
                prevNode = temp;
                temp = temp.NextElement;
            }
            if (temp != null)
            {
                counter--;
                if (counter == 0)
                //list will be empty after removal
                {
                    header = null;
                }
                //header is removed
                else if (prevNode == null)
                {
                    header = temp.NextElement;
                    header.PrevElement = null;
                }
                //tailer is removed
                else if (temp == tailer)
                {
                    temp.PrevElement.NextElement = null;
                    tailer = temp.PrevElement;
                }
                //node in the middle is removed
                else
                {
                    temp.PrevElement.NextElement = temp.NextElement;
                    temp.NextElement.PrevElement = temp.PrevElement;
                }
            }
        }

        public int Lenght()
        {
            return counter;            
        }

        public Node<T> First()
        {
            if (header == null)
            {
                Console.WriteLine("List is Empty");
                return null;
            }
            else
            {
                return header;
            }               
        }

        public Node<T> Last()
        {
            if (tailer == null)
            {
                Console.WriteLine("List is Empty");
                return null;
            }
            else
            {
                return tailer;
            }                
        }

        public void Sort()
        {
            Node<T> currentNode = null;
            T temp= default(T);

            for (int i = 0; i < counter; i++)
            {
                currentNode = header;                
                while (currentNode.NextElement != null)
                    {
                        if (currentNode.NodeElement.CompareTo(currentNode.NextElement.NodeElement) > 0)
                        {
                            temp = currentNode.NodeElement;
                            currentNode.NodeElement  = currentNode.NextElement.NodeElement;
                            currentNode.NextElement.NodeElement = temp;                            
                        }
                        currentNode = currentNode.NextElement;
                    }
            }
        }

        public void Print()
        {
            Node<T> temp = header;
            int k = 1;
            while (temp != null)
            {                
                Console.WriteLine("Element {0} in the list: {1}", k, temp.NodeElement);
                temp = temp.NextElement;
                k++; 
            }                  
        }
    }
}