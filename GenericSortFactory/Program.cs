


public class Program
{
    public static void Main(string[] args){
        ISortableObject<int[]> intSortableObjectArray = new IntArrary();
        ISortableObject<string[]> stringSortableObjectArray = new StringArray();
        ISortableObject<Employee[]> employeeSortableObjectArray = new EmployeeArray();

        int[] intArray = intSortableObjectArray.Create();
        string[] stringArray = stringSortableObjectArray.Create();
        Employee[] employeeArray = employeeSortableObjectArray.Create();

        SortArray<int> sortIntArray = new SortArray<int>();
        sortIntArray.sorting(intArray);
        SortArray<string> sortStringArray = new SortArray<string>();
        sortStringArray.sorting(stringArray);
        SortArray<Employee> sortEmployeeArray = new SortArray<Employee>();
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

public interface ISortableObject<T>{
    T Create();
}

public class IntArrary: ISortableObject<int[]>
{
    public int[] Create(){
        return new int[] {5, 4, 1, 2, 3, 6};
    }
}

public class StringArray: ISortableObject<string[]>
{
    public string[] Create(){
        return  new string[] { "Bob", "Henry", "Andy", "Greg" };
    }
}

public class EmployeeArray: ISortableObject<Employee[]>
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

public class SortArray<T> where T:IComparable<T>
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

}