

using GenericSortFactory.ArrayFactory.Interface;

namespace GenericSortFactory.ArrayFactory
{
    public class StringArrayFactory : IArrayFactory<string[]>
    {
        public string[] Create()
        {
            return new string[] { "Bob", "Henry", "Andy", "Greg" };
        }
    }
}
