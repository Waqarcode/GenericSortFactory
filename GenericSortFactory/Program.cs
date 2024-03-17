


using GenericSortFactory.ArrayFactory.Interface;
using GenericSortFactory.ArrayFactory;
using GenericSortFactory.ArraySortUtility;

public class Program
{
    public static void Main(string[] args){
        IArrayFactory<int[]> intArrayFactory = new IntArrayFactory();
        IArrayFactory<string[]> stringArrayFactory = new StringArrayFactory();
        IArrayFactory<Employee[]> employeeArrayFactory = new EmployeeArrayFactory();

        int[] intArray = intArrayFactory.Create();
        string[] stringArray = stringArrayFactory.Create();
        Employee[] employeeArray = employeeArrayFactory.Create();

        ArraySorter<int> sortIntArray = new ArraySorter<int>();
        sortIntArray.sorting(intArray);
        ArraySorter<string> sortStringArray = new ArraySorter<string>();
        sortStringArray.sorting(stringArray);
        ArraySorter<Employee> sortEmployeeArray = new ArraySorter<Employee>();
        sortEmployeeArray.sorting(employeeArray);

        DisplayArray(intArray, "Int");
        DisplayArray(stringArray, "String");
        DisplayArray(employeeArray, "Employee");
    }

    private static void DisplayArray<T>(T[] array, string s)
    {
        Console.WriteLine("\n");
        Console.WriteLine($"{s} type sorted Array\n") ;
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

/*public interface IArrayFactory<T>{
    T Create();
}

public class IntArrayFactory: IArrayFactory<int[]>
{
    public int[] Create(){
        return new int[] {5, 4, 1, 2, 3, 6};
    }
}

public class StringArrayFactory: IArrayFactory<string[]>
{
    public string[] Create(){
        return  new string[] { "Bob", "Henry", "Andy", "Greg" };
    }
}

public class EmployeeArrayFactory: IArrayFactory<Employee[]>
{
    public Employee[] Create(){
        return  new Employee[]
        {
            new() { Id = 4, Name = "John" },
            new() { Id = 2, Name = "Bob" },
            new() { Id = 3, Name = "Greg" },
            new() { Id = 1, Name = "Tom" }
        };
    }
}

public class  Employee : IComparable<Employee>
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

public class ArraySorter<T> where T:IComparable<T>
{
    public void sorting(T[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n -1; i++)
        {
            for (int j = 0; j < n-i-1; j++)
            {
                if (array[j].CompareTo(array[j+1])> 0)
                {
                    Swap(array, j);
                }
            }
        }
    }

    

    private void Swap(T[] array, int j)
    {
        T temp = array[j];
        array[j] = array[j+1];
        array[j+1] = temp;
    }

}*/