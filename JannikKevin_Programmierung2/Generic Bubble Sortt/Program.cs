namespace Generic_Bubble_Sortt;

class Program
{
    static void Main(string[] args)
    {
        Bubblesort<int> b1 = new Bubblesort<int>(100,1,2,3,4,5);
        
        //b1.SortLikeBubble();
        //b1.PrintSortedArray();
        b1.SortLikeSelection();
        
    }
}