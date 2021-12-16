namespace santa
{
    public class Elf
    {
        public Elf(string name, int timeIn, int timeOut, int candyConsumed)
        {
            this.name = name;
            this.timeIn = timeIn;
            this.timeOut = timeOut;
            this.candyConsumed = candyConsumed;
        }

        public string name { get; set; }
        public int timeIn { get; set; }
        public int timeOut { get; set; }
        public int candyConsumed { get; set; }
    }
}