namespace _4._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> orders = new Queue<int>();
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] ordersQuantities = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (int order in ordersQuantities)
            {
                orders.Enqueue(order); //put the order to the queue
            }
            Console.WriteLine(orders.Max()); //print the biggest order
            foreach (int orderToServe in ordersQuantities)
            {
                if (foodQuantity < orderToServe) //check if the quantity of food is finished
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
                    break;
                }
                foodQuantity -= orderToServe; //reduce the quantity of food
                orders.Dequeue(); //remove the served order from the queue
            }

            if (orders.Count == 0) //check if the orders are complete or not
                Console.WriteLine("Orders complete");
        }
    }
}