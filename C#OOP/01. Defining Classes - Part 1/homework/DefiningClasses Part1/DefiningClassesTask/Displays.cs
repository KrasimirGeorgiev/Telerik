namespace DefiningClassesTask
{
    public class Displays
    {
        public Displays(double size, ulong numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size { get; set; }
        public ulong NumberOfColors { get; set; }
    }
}
