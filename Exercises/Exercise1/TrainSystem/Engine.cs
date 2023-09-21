using Utils;
namespace TrainSystem
{
    public class Engine
    {
        private int _HorsePower;
        private int _Weight;

        public int HorsePower
        {
            get
            {
                return _HorsePower;
            }
            set
            {
                if (Utilities.InHundreds(value))
                {
                    throw new ArgumentException($"Horsepower must be in the hundreds!");
                }

                _HorsePower = value;
            }
        }

        public bool InService { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }

        public int Weight
        {
            get
            {
                return _Weight;
            }

            set
            {
                if (Utilities.IsPositiveNonZero(value))
                {
                    throw new ArgumentException($"Weight must be positive!");
                }

                _Weight = value;
            }
        }

        public Engine(string model, string serialnumber, int weight, int horsepower)
        {
            Model = model;
            SerialNumber = serialnumber;
            Weight = weight;
            HorsePower = horsepower;
            InService = true;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Serial Number: {SerialNumber}, Weight: {Weight} kg, Horsepower: {HorsePower} HP, In Service: {InService}";
        }
    }
}