namespace _1._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersToTakeAction = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackOfTheNumbers = new Stack<int>();
            for (int i = 0; i < numbersToTakeAction[0]; i++)
            {
                stackOfTheNumbers.Push(numbers[i]); //push the numbers to the stack
            }
            for (int i = 0; i < numbersToTakeAction[1]; i++)
            {
                stackOfTheNumbers.Pop(); //remove N numbers from the stack
            }
            if (stackOfTheNumbers.Count == 0) //check if the stack is emty
            {
                Console.WriteLine(0);
            }
            else if (stackOfTheNumbers.Contains(numbersToTakeAction[2])) //check if the number M is present in the stack
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stackOfTheNumbers.Min()); //takes the smallest number from the stack
            }
        }
    }
}