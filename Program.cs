using System;
using System.IO;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text, enter 'start' to start writing into the Journal, and 'stop' to end writing:");

            string input;
            string journalContent = "";
            bool writing = false;

            while ((input = Console.ReadLine()) != "stop")
            {
                if (input == "start")
                {
                    writing = true;
                }
                else if (writing)
                {
                    journalContent += input + Environment.NewLine;
                }
            }

            DateTime date = DateTime.Now;
            string fileName = date.ToString("yyyy-MM-dd") + ".txt";
            journalContent = "Captain's log Stardate " + date.ToString("yyyy-MM-dd") + Environment.NewLine +
                              Environment.NewLine +
                              journalContent +
                              Environment.NewLine +
                              "Jean-Luc Picard";

            File.WriteAllText(fileName, journalContent);
            Console.WriteLine("Journal saved as " + fileName);
            Console.ReadLine();
        }
    }
}