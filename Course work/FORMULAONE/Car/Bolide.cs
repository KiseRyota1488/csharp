using System;

namespace RacingStaff
{
    public class Bolide
    {
        
        public int Number { get; set; } = 0;
        public string Name { get; set; }
        public string LastName { get; set; }

        int MaxSpeed { get; set; }
        int MinSpeed { get; set; }
        public int CurrentSpeed { get; set; }

        public Bolide(int number, string name, string lastName, int maxSpeed, int minSpeed)
        {
            Number = number;
            Name = name;
            LastName = lastName;
            MaxSpeed = maxSpeed;
            MinSpeed = minSpeed;

            CurrentSpeed = ((MaxSpeed - MinSpeed) / 2) + MinSpeed;
        }

    }
}
