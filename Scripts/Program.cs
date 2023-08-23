using System.Text;
using FakeWriter;

class Program
{
    static void Main()
    {
        bool login = false;

        Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Enter password to use this software");

        while (login == false)
        {
           
            string userInput = Console.ReadLine();

            if (userInput.Equals("Rakis24"))
            {
                login = true;
                Console.WriteLine("Success!");
                StartWriting();
            }
            else
            {
                Console.WriteLine("Wrong password! Try again.");
            }
        }
    }

    static void StartWriting()
    {

        Console.WriteLine("You need to give the path of your text file! (C:/somepath/somefolder)");

        string filePath = Console.ReadLine();

        FileReader fileReader = new FileReader();
        string fileContent = fileReader.ReadAllText(filePath);

        string[] words = fileContent.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        if(words.Length == 0)
        {
            Console.WriteLine("File does not exist or is empty!");
            return;
        }

        Console.Clear();

        Console.WriteLine("Press any key to display the words. Press 'q' to quit.");

        int currentIndex = 0;

        while (currentIndex < words.Length)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.KeyChar == 'q')
            {
                Console.WriteLine("\nQuitting...");
            }
            else
            {
                Console.Write("\b \b");
                Console.Write(words[currentIndex] + " ");
                currentIndex++;
            }
        }
        Console.WriteLine("\nReached the end! Closing in 3 seconds!");
        Thread.Sleep(3000);
    }
}
