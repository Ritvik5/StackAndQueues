using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public class StackExecution
    {
        public Node top;

        public StackExecution()
        {
            top = null;
        }

        private void IfTopisNull()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty!!!");
            }
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = top;
            top = newNode;
        }

        public void Display()
        {
            IfTopisNull();
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(" | "+temp.data+" | ");
                temp = temp.next;
            }
        }

        public void Peek()
        {
            IfTopisNull() ;
            Console.WriteLine("\nTop most element in stack is: "+top.data);
        }

        public void Pop()
        {
            IfTopisNull();
            Console.WriteLine("\nValue Popped is :" + top.data);
            top = top.next;
            Display();
        }

        public void IsEmpty()
        {
            while (top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
