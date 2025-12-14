using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");
        // Console.WriteLine("Test");

        Person Lucy = new Child("Lucy",0, new DateTime());
        Person Travis = new Child("Travis",0,new DateTime());
        Person David = new Parent("David",100, new DateTime());
        Person Harriet = new Parent("Harriet",100, new DateTime());

        List <Person> People = new List<Person>{David,Harriet,Lucy,Travis};

        Chore Laundry = new Laundry("Laundry","Put dirty clothes in the washing machine and then the dryer",7, new DateTime(),5.0,"n/a");
        Chore Dishes = new Dishes("Dishes","Wash dishes by hand or using the dishwasher",3, new DateTime(),2.5,"n/a");
        Chore Shopping = new Shopping("Shopping","Go to the grocery store and buy groceries",14,new DateTime(),0,"n/a", 0.0);
        Chore Vacuum = new Vacuum("Vacuuming","Vacuum floors of the house",7,new DateTime(),5.0,"n/a");

        List <Chore> Chores = new List<Chore>{Laundry,Dishes,Shopping,Vacuum};
        
        string menu1q;
        int menu2q;
        do
        {
            Console.Clear();
            Console.WriteLine("What would you like to do? (Please input number)\n1. Look at Chores\n2. Look at People\n3. Do Chores\n4. Give allowance\n5. Save\n6. Load\n7. Quit");
            menu1q = Console.ReadLine();
            if (menu1q == "1") // see chores
            {
                Console.Clear();
                Console.WriteLine($"Which chore will you look at?");
                for (int i = 0; i < Chores.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {Chores[i].GetTitle()}");
                }
                menu2q = int.Parse(Console.ReadLine());
                Console.Clear();
                Chores[menu2q-1].DisplayDetails();
                Console.ReadLine();

            }
              else if (menu1q == "2") // see people+money
            {
                Console.Clear();
                for (int i = 0; i < People.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {People[i].GetName()} - ${People[i].GetMoney().ToString("0.00")}");
                }
                Console.ReadLine();

            }
            else if (menu1q == "3") // do chore
            {
                Console.Clear();
                Console.WriteLine("Which chore are you doing?");
                for (int i = 0; i < Chores.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {Chores[i].GetTitle()}");
                }
                menu2q = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Who did this chore?");
                for (int i = 0; i < People.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {People[i].GetName()}");
                }
                int menu3q = int.Parse(Console.ReadLine());
                Chores[menu2q-1].DoChore(People[menu3q-1]);

            }
            else if (menu1q == "4") // give allowance
            {
                Console.Clear();
                Console.WriteLine("Who is getting allowance?");
                for (int i = 0; i < People.Count; i++)
                {
                        Console.WriteLine($"{i+1}. {People[i].GetName()}");
                }
                menu2q = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Who is giving allowance?");
                for (int i = 0; i < People.Count; i++)
                {
                        Console.WriteLine($"{i+1}. {People[i].GetName()}");

                }
                int menu3q = int.Parse(Console.ReadLine());
                People[menu2q-1].Allowance(Chores,People[menu2q-1].GetName());
                People[menu3q-1].Allowance(Chores,People[menu2q-1].GetName());
                Console.ReadLine();

            }
            else if (menu1q == "5") // save
            {
                Console.Clear();
                Console.WriteLine("What file will you save to?");
                string filepath = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filepath))
                {
                    for (int i = 0; i < Chores.Count; i++)
                    {
                        outputFile.WriteLine(Chores[i].GetStringRepresentation());
                    }
                    for (int i=0; i<People.Count; i++)
                    {
                         outputFile.WriteLine(People[i].GetStringRepresentation());
                    }
                }
                Console.WriteLine("Your file has been saved");
                Console.ReadLine();

            }
            else if (menu1q == "6") // load
            {
                Console.Clear();
                string filepath;
                do{
                Console.WriteLine("What file are you loading?");
                filepath = Console.ReadLine();
                if (File.Exists(filepath)== false)
                    {
                        Console.WriteLine($"Error: {filepath} does not exist.");
                    }
                } while (File.Exists(filepath) == false);
                Chores.Clear();
                People.Clear();

                string[] allLines = System.IO.File.ReadAllLines(filepath);
                foreach (string line in allLines)
                {
                    string[] oneLine = line.Split('|');
                    if (oneLine[0] == "Laundry")
                    {
                        Chore Laundry1 = new Laundry(oneLine[0],oneLine[1],int.Parse(oneLine[2]),DateTime.Parse(oneLine[3]),double.Parse(oneLine[4]),oneLine[5]);
                        Chores.Add(Laundry1);
                    }
                    else if (oneLine[0] == "Dishes")
                    {
                        Chore Dishes1 = new Dishes(oneLine[0],oneLine[1],int.Parse(oneLine[2]),DateTime.Parse(oneLine[3]),double.Parse(oneLine[4]),oneLine[5]);
                        Chores.Add(Dishes1);
                    }
                    else if (oneLine[0] == "Shopping")
                    {
                        Chore Shopping1 = new Shopping(oneLine[0],oneLine[1],int.Parse(oneLine[2]),DateTime.Parse(oneLine[3]),double.Parse(oneLine[4]),oneLine[5],double.Parse(oneLine[6]));
                        Chores.Add(Shopping1);
                    }
                    else if (oneLine[0] == "Vacuuming")
                    {
                        Chore Vacuum1 = new Vacuum(oneLine[0],oneLine[1],int.Parse(oneLine[2]),DateTime.Parse(oneLine[3]),double.Parse(oneLine[4]),oneLine[5]);
                        Chores.Add(Vacuum1);
                    }
                    else if (oneLine[0] == "Child")
                    {
                        Person child1 = new Child(oneLine[1],double.Parse(oneLine[2]),DateTime.Parse(oneLine[3]));
                        People.Add(child1);
                    }
                    else if (oneLine[0] == "Parent")
                    {
                        Person parent1 = new Parent(oneLine[1],double.Parse(oneLine[2]),DateTime.Parse(oneLine[3]));
                        People.Add(parent1);
                    }
                    
                }
                Console.WriteLine("Your file has been loaded");
                Console.ReadLine();
            }
        } while (menu1q != "7");
    }
}