using System.Collections.Generic;

namespace InterfaceFürSortieralgorithmen;

public class SortAlgorythm<T> where T : IComparable<T>
{

    public T[] array { get; set; }

    public SortAlgorythm(T[] array)
    {
        this.array = array;
    }

    public void BubbleSorter()
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length-1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T cache = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = cache;
                }
            }
        }

        string val = string.Join(" ,", array);
        Console.WriteLine(val);

       
    }

    public void SelectionSorter()
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minInd = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].CompareTo(array[minInd])<0)
                {
                    minInd = j;
                }
            }

            T cache = array[i];
            array[i] = array[minInd];
            array[minInd] = cache;
            array[minInd] = cache;
        }
        
        string val = string.Join(" ,", array);
        Console.WriteLine(val);
        
        
    }
}