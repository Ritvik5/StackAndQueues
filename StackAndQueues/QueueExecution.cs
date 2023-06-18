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

        private void IfFromntIsNull()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is Empty!!!");
            }
        }

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
            IfFromntIsNull();
            while (temp != null)
            {
                Console.Write(temp.data+" | ");
                temp = temp.next;
            }
        }

        public void Dequeue()
        {
            IfFromntIsNull();

            Qnode temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("\nItem deleted is {0}", temp.data);
        }

        public void IsEmpty()
        {
            while (this.front != null)
            {
                Dequeue();
            }
            Display();
        }
    }
}
