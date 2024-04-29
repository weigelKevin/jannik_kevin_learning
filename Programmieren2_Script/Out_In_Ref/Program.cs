namespace Out_In_Ref;


class Program
{
    static void Main(string[] args)
    {
        /*
        int y = 42;
        Console.WriteLine($"Y: {y}");
        FancyFunction(ref y);
        Console.WriteLine($"Y: {y}");
        */
        
        /*
        GetNameParts(out string fn, out string ln);
        Console.WriteLine($"{fn}, {ln}");
        */

    }

    //CallByValue
    // if i use y without ref than only a copy of this y is delivered to the function
    // ref allows you to work with the original variable y
    static void FancyFunction(ref int x) => x++;

    
    //in case you use out parameter you do not have to deliver a value to the method assigned to the parameter
    //instead the value related to the parameter will be created in the method and after the method will be delivered to 
    // the console.writeline in this cas
    static void GetNameParts(out string firstname, out string lastname)
    {
        firstname = "Kevin";
        lastname = "Dev";
    }
}