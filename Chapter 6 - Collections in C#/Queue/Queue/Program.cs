using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // defininf a queue of integers
            Queue<int> queue = new Queue<int>();
            // adding an element
            queue.Enqueue(1);
            // printing the element in the front of the queue
            Console.WriteLine("The value in the front of the queue is {0}", queue.Peek());
            queue.Enqueue(8);
            Console.WriteLine("The value in the front of the queue is {0}", queue.Peek());
            queue.Enqueue(16);
            Console.WriteLine("The value in the front of the queue is {0}", queue.Peek());
            queue.Enqueue(4);
            Console.WriteLine("The value in the front of the queue is {0}", queue.Peek());
            int queueItem = queue.Dequeue();
            Console.WriteLine("The value in the front after dequeue is {0}", queue.Peek());

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
                Console.WriteLine("{0} element(s) left in the queue", queue.Count);
            }
            Console.WriteLine("\n\n");


            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in RecieveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while(ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }


            Console.ReadKey();
        }

        // a method that create an array of orders and return it
        static Order[] RecieveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1, 5),
                new Order(2, 7),
                new Order(6, 2),
            };
            return orders;
        }
        static Order[] RecieveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3, 8),
                new Order(4, 1),
                new Order(5, 3),
            };
            return orders;
        }

    }

    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }
        public Order(int id, int quantity)
        {
            this.OrderId = id;
            this.OrderQuantity = quantity;
        }

        // print that the order was processed
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} was processed.");
        }
    }
}
