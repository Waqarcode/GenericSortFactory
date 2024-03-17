

using GenericSortFactory.ArrayFactory.Interface;

namespace GenericSortFactory.ArrayFactory
{
    public class IntArrayFactory : IArrayFactory<int[]>
    {
        public int[] Create()
        {
            return new int[] { 5, 4, 1, 2, 3, 6 };
        }
    }
}
