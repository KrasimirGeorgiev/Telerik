namespace DefiningClassesTask
{
    public class Batteries
    {
        public Batteries(string model, int hoursIdle, int hoursTalk, BatteryTypes batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model { get; set; }
        public int HoursIdle { get; set; }
        public int HoursTalk { get; set; }
        public BatteryTypes BatteryType { get; set; }
    }
}
