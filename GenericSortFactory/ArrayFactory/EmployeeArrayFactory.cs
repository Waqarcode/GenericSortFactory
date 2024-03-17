

using GenericSortFactory.ArrayFactory.Interface;

namespace GenericSortFactory.ArrayFactory
{
    public class EmployeeArrayFactory : IArrayFactory<Employee[]>
    {
        public Employee[] Create()
        {
            return new Employee[]
            {
            new() { Id = 4, Name = "John" },
            new() { Id = 2, Name = "Bob" },
            new() { Id = 3, Name = "Greg" },
            new() { Id = 1, Name = "Tom" }
            };
        }

    }

    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee? other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"Id {Id} - Name {Name}";
        }
    }

}
