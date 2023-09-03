namespace _6._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs= new Queue<string>();
            string[] initialSongs = Console.ReadLine().Split(", ");
            foreach (string song in initialSongs)
            {
                songs.Enqueue(song); //put the songs to the queue
            }
            string[] commands;
            while (true)
            {
                if (songs.Count==0) //check if the queue of songs is empty
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
                //logic for different commands
                commands = Console.ReadLine().Split();
                if (commands[0]=="Play")
                {
                    songs.Dequeue(); //remove the first song from the queue
                }
                else if (commands[0]=="Add")
                {
                    string songName = string.Empty;
                    for (int i = 1; i < commands.Length; i++)
                    {
                        songName += commands[i]+ " ";
                    }
                    songName=songName.Trim();
                    if (!songs.Contains(songName)) //check if the queue contains that specific song
                        songs.Enqueue(songName);
                    else
                        Console.WriteLine($"{songName} is already contained!");
                }
                else if (commands[0]=="Show")
                {
                    Console.WriteLine(string.Join(", ", songs)); //print the songs from the queue
                }

            }
        }
    }
}