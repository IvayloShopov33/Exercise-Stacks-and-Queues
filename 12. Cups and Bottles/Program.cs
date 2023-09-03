namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> bottles = new Stack<int>();
            List<int> cupsValues = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bottlesValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (int bottle in bottlesValues)
            {
                bottles.Push(bottle); //push the bottle to the stack of bottles
            }
            int wastedLittersOfWater = 0;
            while (cupsValues.Count > 0 && bottles.Count > 0)
            {
                int bottle = bottles.Pop(); //remove the bottle from the stack
                int cup = cupsValues.First(); //takes the first cup
                cupsValues.RemoveAt(0);
                if (bottle >= cup) //check if the bottle has more litters of water than the cup
                {
                    wastedLittersOfWater += bottle - cup;
                }
                else
                {
                    cup -= bottle;
                    cupsValues.Insert(0, cup); //return the cup to the list of cups with the new value
                }
            }

            if (cupsValues.Count == 0) // check if there are remained cups 
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
            else
                Console.WriteLine($"Cups: {string.Join(' ', cupsValues)}");


            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}"); //print the wasted litters of water
        }
    }
}