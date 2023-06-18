namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queues!!!\n");

            //StackExecution obj = new StackExecution();

            //obj.Push(70);
            //obj.Push(30);
            //obj.Push(56);

            //obj.Display();

            //obj.Peek();

            //obj.Pop();
            //obj.IsEmpty();

            QueueExecution obj = new QueueExecution();

            obj.Enqueue(56);
            obj.Enqueue(30);
            obj.Enqueue(70);

            obj.Display();

            obj.IsEmpty();

        }
    }
}