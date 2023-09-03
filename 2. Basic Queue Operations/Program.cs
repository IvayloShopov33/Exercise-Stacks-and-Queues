namespace _2._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersToTakeAction = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < numbersToTakeAction[0]; i++)
            {
                queue.Enqueue(numbers[i]); //put the numbers to the queue
            }
            for (int i = 0; i < numbersToTakeAction[1]; i++)
            {
                queue.Dequeue(); //remove N number from the queue
            }
            if (queue.Count==0) //check if the queue is emty
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(numbersToTakeAction[2])) //check if the number J is present in the queue
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min()); //takes the smallest number from the queue
            }
        }
    }
}