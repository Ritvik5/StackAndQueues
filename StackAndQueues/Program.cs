namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queues!!!");

            StackExecution obj = new StackExecution();

            obj.Push(70);
            obj.Push(30);
            obj.Push(56);

            obj.Display();
            
        }
    }
}