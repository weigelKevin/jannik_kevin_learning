using System.Collections;

namespace Generics;

class Person
{
    public string _FirstName;
    public string _LastName;
    public string _Gender;

    public Person FirstName(string i)
    {
        _FirstName = i;
        return this;
    }

    public Person LastName(string i)
    {
        _LastName = i;
        return this;
    }

    public Person Gender(string i)
    {
        _Gender = i;
        return this;
    }


    class Prog
    {

        public static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.FirstName("Schmandik").LastName("Schmaier").Gender("Divers");
        }

    }
}
