// See https://aka.ms/new-console-template for more information
using santa;


List<Elf> elves = new List<Elf>(){
    {new Elf("Jingle", 600, 1000, 18)},
    {new Elf("Dash", 700, 1000, 1)},
    {new Elf("Bubbles", 800, 1200, 10)},
    {new Elf("Sparkle", 1000, 1100, 17)},
    {new Elf("Cookie", 1100, 1600, 4)},
    {new Elf("Frosty", 1100, 1400, 8)},
    {new Elf("Twinkle", 1300, 1400, 22)},
    {new Elf("Jingle", 1300, 1800, 15)},
    {new Elf("Spunky", 1500, 2200, 1)},
    {new Elf("Sunny", 1400, 2000, 12)},
    {new Elf("Happy", 1600, 1900, 13)}
};
void candyCalc(List<Elf> elves)
{
    int currentMissingCandy = 0;
    int totalMissingCandy = 0;
    int currentTotalCandy = 0;
    int totalCandy = 0;
    for (int t = 600; t < 2201; t++)
    {
        for (int i = 0; i < elves.Count; i++)
        {
            Elf e = elves[i];

            if (e.timeIn == t)
            {
                Console.WriteLine(e.name + " " + "has clocked in!");
                currentMissingCandy += e.candyConsumed;
                totalCandy += e.candyConsumed;
            }
            else if (e.timeOut == t)
            {
                Console.WriteLine(e.name + " " + "has clocked out!");
                currentMissingCandy -= e.candyConsumed;
                currentTotalCandy -= e.candyConsumed;
            }

        }
        if (currentMissingCandy > totalMissingCandy)
        {
            totalMissingCandy = currentMissingCandy;
        };
        if (currentTotalCandy > totalCandy)
        {
            totalCandy = currentTotalCandy;
        };
    }
    Console.WriteLine("Max Missing Candy:" + " " + totalMissingCandy);
    Console.WriteLine("Total Candy For the Day" + " " + totalCandy);
}
candyCalc(elves);
