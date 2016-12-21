namespace DefiningClassesTask
{
    public class GSM
    {
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Batteries Battery { get; set; }
        public Displays Display { get; set; }
    }
}
