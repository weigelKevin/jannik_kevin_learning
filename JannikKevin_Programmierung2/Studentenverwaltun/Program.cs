namespace Studentenverwaltun;

class Program
{
    static void Main(string[] args)
    {
        Student st1 = new Student("Kevin","1234",22,1,2.2);

        st1.AddGrade(1.0);
        st1.AddGrade(2.0);
        st1.PrintList();
        double avg = st1.CalculateGradeAvg();
        st1.PrintProperties(avg);
    }
}