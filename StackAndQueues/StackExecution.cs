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

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = top;
            top = newNode;
        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty!!!");
            }
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(" | "+temp.data+" | ");
                temp = temp.next;
            }
        }

    }
}
