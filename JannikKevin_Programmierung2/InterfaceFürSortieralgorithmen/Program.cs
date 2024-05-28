namespace InterfaceFürSortieralgorithmen;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 2,3,4,1,0 };
        SortAlgorythm<int> test = new SortAlgorythm<int>(arr);
        test.BubbleSorter();
        test.SelectionSorter();
    }
}