using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one of the following");
            Console.WriteLine("Press 1 for Dynamic Queue simulation");
            Console.WriteLine("Press 2 for Dynamic Stack simulation");
            int choose = (Convert.ToInt32(Console.ReadLine()));
            switch (choose)
            {
                case 1:
                    DynamicQueue<int> TestQueue = new DynamicQueue<int>();
                    EventHendlerForQueueAndStack hendler = new EventHendlerForQueueAndStack();
                    TestQueue.EvendHendlerAddelem += hendler.MessageAdd;
                    TestQueue.EvendHendlerRemoveItem += hendler.MessageRem;
                    TestQueue.EventHandlerBufferIsFull += hendler.MessageFull;
                    TestQueue.EventHandlerBufferIsEmpty += hendler.MessageEmpty;

                    Console.WriteLine("Press 1 for Enque");
                    Console.WriteLine("Press 2 for Dequeue");
                    Console.WriteLine("Press 3 for Print");
                    for (int i = 0; i < 100; i++)
                    {
                        int action = (Convert.ToInt32(Console.ReadLine()));
                        switch (action)
                        {
                            case 1:
                                TestQueue.Enqueue(Convert.ToInt32(Console.ReadLine()));
                                break;

                            case 2:

                                Console.WriteLine(TestQueue.Dequeue());
                                break;

                            case 3:
                                TestQueue.Print();
                                break;
                            default:
                                Console.WriteLine("Unsuported expression");
                                break;
                        }
                    }

                    break;
                case 2:
                    DynamicStack<int> TestStack = new DynamicStack<int>();
                    Console.WriteLine("Press 1 for Push");
                    Console.WriteLine("Press 2 for Pop");
                    Console.WriteLine("Press 3 for Peek");
                    Console.WriteLine("Press 4 for Print");
                    for (int i = 0; i < 100; i++)
                    {
                        int action = (Convert.ToInt32(Console.ReadLine()));
                        switch (action)
                        {
                            case 1:
                                TestStack.Push(Convert.ToInt32(Console.ReadLine()));
                                break;

                            case 2:

                                Console.WriteLine(TestStack.Pop());
                                break;

                            case 3:

                                Console.WriteLine(TestStack.Peek());
                                break;

                            case 4:
                                TestStack.Print();
                                break;
                            default:
                                Console.WriteLine("Unsuported expression");
                                break;
                        }
                    }


                    break;
                default:
                    Console.WriteLine("Unsuported expression");
                    break;
            }
        }
    }
}
