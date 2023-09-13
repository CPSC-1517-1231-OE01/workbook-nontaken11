using static System.Console;

namespace Hockey.Data
{
    public class HockeyPlayer
    {
        // data fields
        private string _firstName;
        private string _lastName;
        private string _birthPlace;
        private DateOnly _dateOfBirth;
        private int _heightInInches;
        private int _weightInPounds;

        //we do not need this
        //private Position _position;
        //private Shot _shot;


        // properties
        public string FirstName
        {
            get 
            { 
                return _firstName; 
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"First name cannot be null or empty.");
                }

                //if we get here then no exception happened
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Last name cannot be null or empty.");
                }

                _lastName = value;
            }
        }
        public string BirthPlace 
        { 
            get
            {
                return _birthPlace;
            }

            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Birth place cannot be null or empty.");
                }

                _birthPlace = value;
            }
        }

        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                if (value >= DateOnly.FromDateTime(DateTime.Now))
                {
                    throw new ArgumentException($"Date of birth cannot be in the future.");
                }

                _dateOfBirth = value;
            }
        }

        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height must be positive.");
                }

                _heightInInches = value;
            }
        }

        public int WeightInPounds
        {
            get
            {
                return _weightInPounds;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Weight must be positive.");
                }

                _weightInPounds = value;
            }
        }

        //Auto-implemented property

        /// <summary>
        /// Represents the position for a player
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Represents the shot hand for a player
        /// </summary>
        public Shot Shot { get; set; }

        // constructors
        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly dateOfBirth,
                            int weightInPounds, int heightInInches, Shot shot, Position position)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthPlace = birthPlace;
            DateOfBirth = dateOfBirth;
            WeightInPounds = weightInPounds;
            HeightInInches = heightInInches;
            Position = position;
            Shot = shot;
        }
    }
}