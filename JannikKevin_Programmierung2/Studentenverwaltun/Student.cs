namespace Studentenverwaltun;

public class Student
{
    private string Name { get; set; }
    private string Matrikelnummer { get; set; }
    private int Alter { get; set; }
    private double Noten { get; set; }
    public List<double> StudentList { get; set; }
    public double AvgGrade { get; set; }



    public Student(string name, string matrikelnummer, int alter, double noten, double avgGrade)
    {
        Name = name;
        Matrikelnummer = matrikelnummer;
        Alter = alter;
        Noten = noten;
        StudentList = new List<double>();
        AvgGrade = avgGrade;

    }

    public void AddGrade(double noten)
    {
        StudentList.Add(noten);
    }

    public void PrintList()
    {
        for (int i = 0; i < StudentList.Count; i++)
        {
            Console.WriteLine(StudentList[i]);
        }
    }

    public void PrintProperties(double test)
    {
        Console.WriteLine($"Name: {Name} \nMatrikelnummer: {Matrikelnummer} \nAlter: {Alter} \nNoten: {Noten} \nAvgGrade: {AvgGrade}\n");
    }

    public double CalculateGradeAvg()
    {
        
        for (int i = 0; i < StudentList.Count; i++)
        {
            Noten = Noten + StudentList[i];
        }

        AvgGrade = Noten / (StudentList[StudentList.Count - 1]);
        return AvgGrade;
    }


}