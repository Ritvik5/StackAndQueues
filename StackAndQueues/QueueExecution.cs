using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public class QueueExecution
    {
        public Qnode front;
        public Qnode rear;

        public void Enqueue(int data)
        {
            Qnode node = new Qnode(data);

            if (this.rear == null)
            {
                this.rear = this.front = node;
            }
            else
            {
                this.rear.next = node;
                this.rear = node;
            }
            Console.WriteLine("{0} is inserted in the list",data);
        }

        public void Display()
        {
            Qnode temp = front;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty!!!");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data+" | ");
                temp = temp.next;
            }
        }
    }
}
