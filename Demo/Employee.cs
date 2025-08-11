using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable<Employee>
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString() => $"Id: {Id}, Name: {Name}, Salary: {Salary}";

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1;

            return this.Salary.CompareTo(other.Salary);
        }
    }
    public class EmployeeComparerByName : IComparer<Employee>
    {
        int IComparer<Employee>.Compare(Employee? x, Employee? y)
            => x?.Name?.CompareTo(y?.Name) ?? (y is null ? 0 : -1);
    }
}
