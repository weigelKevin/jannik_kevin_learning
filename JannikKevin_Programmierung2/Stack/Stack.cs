namespace Stack;

public class Stackk<T>
{
    protected List<T> Stack_List { get; set; }

    public Stackk( List<T> stackList)
    {
        Stack_List = stackList;
    }

    public void Push(T input)
    {
        Stack_List.Add(input);

        string printString = string.Join(" ,", Stack_List);
        Console.WriteLine(printString);
    }

    public void Pop(int i)
    {
        List<T> overridingList = new List<T>();
        for (int j = 0; j < Stack_List.Count-i; j++)
        {
            overridingList.Add(Stack_List[i]);
        }

        Stack_List = overridingList;
        string printString = string.Join(" ,", Stack_List);
        Console.WriteLine(printString);



    }
}