using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public class Qnode
    {
        public int data;
        public Qnode next;

        public Qnode(int data)
        {
            this.data = data;
            next = null;
        }

    }
}
