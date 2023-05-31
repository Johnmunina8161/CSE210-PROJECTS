public class WritingAssignment : Assignment
{
    private string _title;

    // The syntax here that the WritingAssignment constructor has 3 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // set of any variables specific to the WritingAssignment class
        _title = title;
    }

    public string GetWritingInformation()
    {
        // here is a calling of getter  because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}