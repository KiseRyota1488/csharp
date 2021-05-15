using System;
using System.Collections.Generic;

namespace RacingStaff
{
    [Serializable]
    public class Bolide
    {

        public int Number { get; set; } = 0;
        public string Name { get; set; }
        public string LastName { get; set; }
        public int MaxSpeed { get; set; }
        public int MinSpeed { get; set; }
        public int TeamId { get; set; }


        [NonSerialized]
        private double lapsCounter = 0;
        public double LapsCounter
        {
            get
            {
                return lapsCounter;
            }
            set
            {
                lapsCounter = value;
            }
        }
        [NonSerialized]
        private int currentPosition = 0;
        public int CurrentPosition
        {
            get
            {
                return currentPosition;
            }
            set
            {
                if ((currentPosition = value) > 35)
                {
                    currentPosition = 0;
                }
                else
                    currentPosition = value;
            }
        }
        [NonSerialized]
        private int currentSpeed;
        public int CurrentSpeed
        {
            get
            {
                return currentSpeed;
            }
            set
            {
                currentSpeed = value;
            }
        }

        
        public Bolide(int number, string name, string lastName, int maxSpeed, int minSpeed, int teamId)
        {
            Number = number;
            Name = name;
            LastName = lastName;
            MaxSpeed = maxSpeed;
            MinSpeed = minSpeed;
            TeamId = teamId;

            LapsCounter = 0;
            CurrentPosition = 0;

            ChangeCurSpeed();
        }

        public void ChangeCurSpeed()
        {
            Random rnd = new Random();
            CurrentSpeed = rnd.Next((MaxSpeed - MinSpeed)) + MinSpeed;
        }

        

        public override string ToString()
        {
            return $"{Number} {Name} {LastName} \tSpeed: {CurrentSpeed} \tLap: {LapsCounter / 36:F1}";
        }
    }
}
