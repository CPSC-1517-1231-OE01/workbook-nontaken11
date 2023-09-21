using static System.Console;
using Utils;

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
        private int _jerseyNumber;

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

            private set
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

            private set
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

            private set 
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

            private set
            {
                if (Utilities.IsInTheFuture(value))
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

            private set
            {
                if (Utilities.IsZeroOrNegative(value))
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

            private set
            {
                if (!Utilities.IsPositive(value))
                {
                    throw new ArgumentException($"Weight must be positive.");
                }

                _weightInPounds = value;
            }
        }

        public int JerseyNumber
        {
            get
            {
                return _jerseyNumber;
            }

            set
            {
                if (value < 1 || value > 98)
                {
                    throw new ArgumentException($"Jersey number must be between 1 and 98.");
                }

                _jerseyNumber = value;
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

        public int Age => (DateOnly.FromDateTime(DateTime.Now).DayNumber - DateOfBirth.DayNumber) / 365;

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        // constructors
        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly dateOfBirth,
                            int weightInPounds, int heightInInches, int jerseyNumber, Position position = Position.Center, Shot shot = Shot.Right)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthPlace = birthPlace;
            DateOfBirth = dateOfBirth;
            WeightInPounds = weightInPounds;
            HeightInInches = heightInInches;
            JerseyNumber = jerseyNumber;
            Shot = shot;
            Position = position;
        }

        // default constructor
        public HockeyPlayer()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthPlace = string.Empty;
            _dateOfBirth = new DateOnly();
            _weightInPounds = 0;
            _heightInInches = 0;
            Shot = Shot.Right;
            Position = Position.Center;
        }
    }
}