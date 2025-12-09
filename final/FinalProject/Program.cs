using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        Console.WriteLine("Test");

        Person Lucy = new Child("Lucy",0);
        Person David = new Parent("David",100);

        List <Person> People = new List<Person>{Lucy, David};

        Chore Laundry = new Laundry("Laundry","Put dirty clothes in the washing machine and then the dryer",7, new DateTime(2025,11,27),5.0,Lucy);
        Chore Dishes = new Dishes("Dishes","Wash dishes by hand or using the dishwasher",3, new DateTime(2025,12,3),2.5,David);
        Chore Shopping = new Shopping("Shopping","Go to the grocery store and buy groceries",14,new DateTime(2025,11,30),0,David, 50.0);
        Chore Vacuum = new Vacuum("Vacuuming","Vacuum carpets of the house",7,new DateTime(2025,11,20),5.0,Lucy);

        List <Chore> Chores = new List<Chore>{Laundry,Dishes,Shopping,Vacuum};
        
        string menu1q;
        int menu2q;
        do
        {
            Console.Clear();
            Console.WriteLine("What would you like to do? (Please input number)\n1. Look at Chores\n2. Look at People\n3. Quit");
            menu1q = Console.ReadLine();
            if (menu1q == "1")
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
            else if (menu1q == "2")
            {
                Console.Clear();
                for (int i = 0; i < People.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {People[i].GetName()}");
                }
                Console.ReadLine();
            }
        } while (menu1q != "3");
    }
}