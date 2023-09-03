namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pricePerBullet=int.Parse(Console.ReadLine());
            int sizeOfGunBarrel=int.Parse(Console.ReadLine());
            int[] bulletsSize=Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>();
            int[] locksSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>();
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            foreach (int bullet in bulletsSize)
            {
                bullets.Push(bullet); //push the bullets to the stack
            }
            foreach (int @lock in locksSize)
            {
                locks.Enqueue(@lock); // put the lock in the queue
            }
            int usedBulletsCount = 0;
            while (bullets.Count>0 && locks.Count>0)
            {
                int bullet=bullets.Pop(); // remove the bullets from the stack
                int @lock=locks.Peek(); // takes the first lock
                if (bullet <= @lock)
                {
                    locks.Dequeue(); //remove the lock from the queue
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                usedBulletsCount++;
                if (usedBulletsCount%sizeOfGunBarrel==0 && bullets.Count>0)
                    Console.WriteLine("Reloading!");
            }

            if (locks.Count>0) //check if all the locks are removed from the queue
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int expenses = usedBulletsCount * pricePerBullet;
                int totalIncome = valueOfIntelligence - expenses;
                int bulletsLeft = bulletsSize.Length - usedBulletsCount;
                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${totalIncome}");
            }
        }
    }
}