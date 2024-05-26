namespace Generic_Bubble_Sortt;

public class Bubblesort<T> where T : IComparable<T>
{
    private T[] Array { get; set; }

    public Bubblesort(params T[] array)
    {
        Array = array;
    }

    public void PrintSortedArray()
    {
        string arrAusgabe = string.Join(" ,", Array);
        Console.WriteLine(arrAusgabe);
    }

    public void SortLikeBubble()
    {
        for (int i = 0; i < Array.Length - 1; i++)
        {
            for (int j = 0; j < Array.Length - i - 1; j++)
            {
                if (Array[j].CompareTo(Array[j + 1]) > 0)
                {
                    T cache = Array[j + 1];
                    Array[j + 1] = Array[j];
                    Array[j] = cache;
                }
            }

        }
    }

    public void SortLikeSelection()
    {
        for (int i = 0; i < Array.Length; i++)
        {
            int checkIndex = i;

            for (int j = i + 1; j < Array.Length; j++)
            {
                if (Array[j].CompareTo(Array[checkIndex]) < 0)
                {
                    checkIndex = j;
                }
            }

            T cache = Array[i];
            Array[i] = Array[checkIndex];
            Array[checkIndex] = cache;


            string arr = string.Join(" ,", Array);
            Console.WriteLine(arr);


        }
    }
}
       
    

