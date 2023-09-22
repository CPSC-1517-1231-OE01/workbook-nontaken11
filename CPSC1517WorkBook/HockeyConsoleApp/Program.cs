using static System.Console;
using Hockey.Data;
using Utils;

WriteLine("Welcome to the HockeyPlayer Test App");

WriteLine("Welcome to the HockeyPlayer Test App");

HockeyPlayer player2 = new HockeyPlayer("Bobby", "Orr", "Parry Sound, ON", new DateOnly(1948, 3, 20),
    196, 73, 28, Position.Defense, Shot.Right);

WriteLine($"Date in future? {Utilities.IsInTheFuture(new DateTime(2023, 9, 12))}");

WriteLine($"The player's name is {player2}, they are born {player2.DateOfBirth} and are {player2.Age} years old.");

