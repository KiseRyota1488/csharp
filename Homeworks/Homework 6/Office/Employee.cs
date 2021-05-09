using System;

namespace Office
{
    public class Employee : ICloneable
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public ushort Salary { get; set; }
        public int Contract { get; set; }

        public void InputName(string name, string lastName)
        {
            if (name != null || !name.Equals(""))
                Name = name;
            else
                Console.WriteLine("Error! Name is incorrect");

            if (!lastName.Equals("") || lastName != null)
                LastName = lastName;
            else
                Console.WriteLine("Error! Last name is incorrect");
        }
        public void InputSalary(ushort salary)
        {
             Salary = checked(salary);
        }
        public void AddSalary(ushort add)
        {
            if (add > 0)
                Salary += add;
            else
                Console.WriteLine("You should add more than zero");
        }

        public Employee(string name, string lastName, string position, ushort salary, int contract)
        {
            InputName(name, lastName);
            Position = position;
            InputSalary(salary);
            Contract = contract;
        }

        public override string ToString()
        {
            return $"Name: {Name} Last name: {LastName} Salary: {Salary} Position: {Position} Contract: {Contract}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
