using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        Reference alma_ref = new Reference("Alma","27","27");
        Scripture alma_scrip = new Scripture();
        alma_scrip.CreateScripText("\n27. And they were among the people of Nephi , and also numbered among the people who were of the church of God . And they were also distinguished for their zeal towards God, and also towards men ; for they were perfectly honest and upright in all things ; and they were firm in the faith of Christ , even unto the end .");

        Reference nephi_ref = new Reference("3 Nephi", "11", "10", "11");
        Scripture nephi_scrip = new Scripture();
        nephi_scrip.CreateScripText("\n10. Behold , I am Jesus Christ, whom the prophets testified shall come into the world . \n11. And behold , I am the light and the life of the world ; and I have drunk out of that bitter cup which the Father hath given me , and have glorified the Father in taking upon me the sins of the world , in the which I have suffered the will of the Father in all things from the beginning .");

        Reference ether_ref = new Reference("Ether", "12", "27");
        Scripture ether_scrip = new Scripture();
        ether_scrip.CreateScripText("\n27. And if men come unto me I will show unto them their weakness . I give unto men weakness that they may be humble ; and my grace is sufficient for all men that humble themselves before me ; for if they humble themselves before me , and have faith in me , then will I make weak things become strong unto them .");

        Console.Clear();
        Console.WriteLine($"Which Scripture would you like to memorize? (please input numbers)\n 1. {alma_ref.CreateReference()}\n 2. {nephi_ref.CreateReference()}\n 3. {ether_ref.CreateReference()}");
        string scripturechoice = Console.ReadLine();

        if (scripturechoice == "1")
        {
            alma_scrip.MemorizeScripture(alma_ref);
        }
        else if (scripturechoice == "2")
        {
            nephi_scrip.MemorizeScripture(nephi_ref);
        }
        else if (scripturechoice == "3")
        {
            ether_scrip.MemorizeScripture(ether_ref);
        }
    

    }
}