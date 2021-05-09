using System;
using System.Collections;
using System.Collections.Generic;

namespace Office
{
    public class Department : IEnumerable
    {
        List<Employee> employees = new List<Employee>();
        public void AddEmployee()
        {
            string name, lastName, position;
            ushort salary;
            int contract;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter position: ");
            position = Console.ReadLine();
            Console.Write("Enter salary: ");
            salary = ushort.Parse(Console.ReadLine());
            Console.Write("Enter contract number: ");
            contract = int.Parse(Console.ReadLine());

            employees.Add(new Employee(name, lastName, position, salary, contract));
        }
        public void RemoveEmployee()
        {
            int contractId = 0;
            Console.Write("Enter contract id: ");
            contractId = int.Parse(Console.ReadLine());

            int index = -1;
            foreach (var item in employees)
            {
                if (item.Contract == contractId)
                    index = employees.IndexOf(item);
            }
            if (index != -1)
                employees.RemoveAt(index);
            else
                Console.WriteLine("Employee is not found!");
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < employees.Count; i++)
            {
                yield return employees[i];
            }
        }
        public IEnumerable GetReverseEnum()
        {
            for (int i = employees.Count - 1; i >= 0; i--)
            {
                yield return employees[i];
            }
        }

        public IEnumerable GetSalaryEnum()
        {
            int avgSalary = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                avgSalary += employees[i].Salary;
            }
            avgSalary /= employees.Count;

            for (int i = employees.Count - 1; i > 0; i--)
            {
                if (avgSalary > employees[i].Salary)
                    yield return employees[i];
            }
        }




    }
}
