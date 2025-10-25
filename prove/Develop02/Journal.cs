using System.Net;
using System.Runtime.CompilerServices;

public class Journal 

{ 
    public List<Entry> _entries = new List<Entry>(); 
    string menuresponse; 
    public void OpenJournal() 
    { 
        do 
        { 
            Console.WriteLine("Welcome to the Journal program! Please enter a number for what you would like to do:\n 1. Write\n 2. Display\n 3. Save\n 4. Load\n 5. Quit"); 
            menuresponse = Console.ReadLine(); 
            if (menuresponse == "1") //write
            {
                Entry entry1 = new Entry();
                Console.WriteLine($"Date:{entry1._date}\n Prompt: {entry1._prompt}");
                string response = Console.ReadLine();
                entry1._response = response;
                _entries.Add(entry1);
            } 
            else if (menuresponse == "2") //display
            { 
                foreach (Entry entry in _entries)
                {
                    Console.WriteLine(entry);
                }
            } 
            else if (menuresponse == "3") //save
            {
                Console.WriteLine("What Journal are you saving to?");
                string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                    outputFile.WriteLine(entry.ToLine());
            }
                
            } 
            else if (menuresponse == "4") //load
            {
                Console.WriteLine("What is the name of the Journal you want to load?");
                string filename = Console.ReadLine();
                if (File.Exists(filename))
                {
                    string[] linesArray = File.ReadAllLines(filename);
                    _entries = linesArray.Select(line => Entry.FromLine(line)).ToList();
                }
                else
                {
                    Console.WriteLine("There is no file with that name");
                }
            } 
        } while (menuresponse != "5"); 
         
    } 

} 