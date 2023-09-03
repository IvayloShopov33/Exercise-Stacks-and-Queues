using System.Text;

namespace _9._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> previousStatesOfTheText = new Stack<string>();
            for (int i = 1; i <= commandsCount; i++)
            {
                string[] commands = Console.ReadLine().Split();
                int commandNumber = int.Parse(commands[0]);
                if (commandNumber == 1)
                {
                    string textToAppend = commands[1];
                    text.Append(textToAppend); //appends someString to the end of the text
                    previousStatesOfTheText.Push(text.ToString());
                }
                else if (commandNumber == 2)
                {
                    int countOfCharsToDelete = int.Parse(commands[1]);
                    text = text.Remove(text.Length - countOfCharsToDelete, countOfCharsToDelete); //erases the last count elements from the text
                    previousStatesOfTheText.Push(text.ToString());
                }
                else if (commandNumber == 3)
                {
                    int index = int.Parse(commands[1]);
                    Console.WriteLine(text[index - 1]); //returns the element at position index from the text
                }
                else if (commandNumber == 4)
                {
                    //undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation
                    previousStatesOfTheText.Pop();
                    text = text.Clear(); //removes all characters from the string
                    if (previousStatesOfTheText.Count > 0) //check if stack is (not) empty
                    {
                        text.Append(previousStatesOfTheText.Peek()); //appends text from previous command
                    }
                }
            }
        }
    }
}