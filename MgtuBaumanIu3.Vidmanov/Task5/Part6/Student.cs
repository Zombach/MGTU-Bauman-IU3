namespace MgtuBaumanIu3.Vidmanov.Task5.Part6;

public class Student(string username, string email, int studentId, string grade)
    : User(username, email)
{
    public int StudentId { get; set; } = studentId;
    public string Grade { get; set; } = grade;

    public override string ToString()
    {
        return $"{StudentId}: {Username} ({Grade})";
    }
}
