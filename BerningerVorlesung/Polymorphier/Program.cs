public void MultipleCases(string[] s)
{
    foreach (var element in s)
        Console.WriteLine("{0} {1}"
            , element, element.Substring(element.IndexOf('a')));
}