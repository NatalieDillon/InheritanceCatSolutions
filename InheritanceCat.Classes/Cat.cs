namespace InheritanceCat.Classes
{
    public abstract class Cat
    {
        // Attributes
        public string Setting { get; private set; }
        public double AverageHeight { get; private set; }
        public bool IsAsleep { get; private set; }

        // Constructor
        public Cat(string setting, double averageHeight)
        {
            Setting = setting;
            AverageHeight = averageHeight;
        }

        // Methods
        public void GoToSleep()
        {
            IsAsleep = true;
        }
        public void WakeUp()
        {
            IsAsleep = false;
        }
        public abstract string Eat();


    }
}